﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR_BusinessLayer.Classes
{
    public class PreviewObject
    {
        public Image Img;
        public string Confidence;
        public List<TextLine> Lines;
        public string Path;
        public string Lang;
        public List<PossitionOfWord> ListOfKeyPossitions;
        public List<Column> ListOfKeyColumn;
        public Evidence Evidence;
        public List<Client> Clients;

    }
}
