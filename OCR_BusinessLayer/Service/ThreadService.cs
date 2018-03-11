﻿using OCR_BusinessLayer.Classes;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static OCR_BusinessLayer.CONSTANTS;

namespace OCR_BusinessLayer.Service
{
    public class ThreadService
    {
        private List<FileToProcess> _filesToProcess;
        private List<PreviewObject> _previewObjects;
        private string _lang = string.Empty;
        public List<PreviewObject> Preview { get { return _previewObjects; } }

        public ThreadService(List<FileToProcess> filesTorocess, string lang)
        {
            _filesToProcess = filesTorocess;
            _previewObjects = new List<PreviewObject>();
            _lang = lang;
        }

        public async Task StartService()
        {
            foreach (FileToProcess s in _filesToProcess)
            {
                TesseractService tess = new TesseractService(_lang);
                var progress = new Progress<int>(percent =>
                {
                    if ((s.ProgressBar.Value + percent) > 100)
                        s.ProgressBar.Value = 100;
                    else
                        s.ProgressBar.Value = s.ProgressBar.Value + percent;

                });
                await Task.Run(() =>
                {
                    var _cvService = OpenCVImageService.GetInstance();
                    _cvService.PrepareImage(s.Path, null, _lang);
                    Mat image = _cvService.Rotated;

                    var id = CheckForPattern(tess, image);
                    if (id == -1)
                    {
                        PreviewObject p = tess.ProcessImage(image, progress);
                        p.Path = s.Path;
                        _previewObjects.Add(p);
                    }
                    else
                    {
                        PreviewObject prew;
                        //nasiel som pattern tak idem podla neho
                        tess.CheckImageForPatternAndGetDataFromIt(image, GetKeysPossitions(id),progress,out prew);
                        prew.Path = s.Path;
                        _previewObjects.Add(prew);
                    }
                });

                s.ProgressBar.Value = 100;
                s.Button.Enabled = true;
            }
        }

        private int CheckForPattern(TesseractService tess, Mat image)
        {
            Database db = new Database();
            string SQL = "SELECT Pattern_ID FROM OCR_2018.dbo.T003_Pattern";
            SqlDataReader data = (SqlDataReader)db.Execute(SQL, Operation.SELECT);
            List<int> patterns = new List<int>();
            while (data.Read())
            {
                patterns.Add((int)data[0]);
            }
            data.Close();

            foreach (int id in patterns)
            {
                PreviewObject p;
                if (tess.CheckImageForPatternAndGetDataFromIt(image, GetKeysPossitions(id, db, true),null,out p, true))
                {
                    return id;
                }
            }

            return -1;

        }
        private List<PossitionOfWord> GetKeysPossitions(int id, Database db = null, bool test = false)
        {
            List<PossitionOfWord> list = new List<PossitionOfWord>();
            if (db == null)
            {
                db = new Database();
            }
            string SQL;
            if (test)
            {
                SQL = $"SELECT TOP 5 * FROM OCR_2018.dbo.T004_Possitions WHERE Pattern_ID = {id} AND (Word_Key NOT LIKE '%Meno%' OR Word_Key NOT LIKE '%Ulica%' OR " +
                    $"Word_Key NOT LIKE '%Psč%' OR Word_Key NOT LIKE '%Štát%') AND K_X != 0 AND K_Y != 0";

                /*
                   OR Word_Key NOT LIKE '%Dodávateľ%' OR Word_Key NOT LIKE '%Odberateľ%' OR " +
                   $"Word_Key NOT LIKE '%Konečný príjemca%' OR Word_Key NOT LIKE '%Poštová adresa%' OR Word_Key NOT LIKE '%Adresa%' OR Word_Key NOT LIKE '%Sídlo firmy%' OR " +
                   $"Word_Key NOT LIKE '%Korešpondenčná adresa%'
                */
            }
            else
            {
                SQL = $"SELECT * FROM OCR_2018.dbo.T004_Possitions WHERE Pattern_ID = {id}";
            }
            SqlDataReader data = (SqlDataReader)db.Execute(SQL, Operation.SELECT);
            while (data.Read())
            {
                var pos = new PossitionOfWord();
                pos.Key = data[2].ToString();
                pos.Value = data[3].ToString();
                pos.KeyBounds = new System.Drawing.Rectangle((int)data[4], (int)data[5], (int)data[6], (int)data[7]);
                pos.ValueBounds = new System.Drawing.Rectangle((int)data[8], (int)data[9], (int)data[10], (int)data[11]);
                list.Add(pos);
            }
            data.Close();
            db.Close();
            return list;
        }

    }
}
