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
        public Image img;
        public string confidence;
        public List<TextLine> Lines;
        public string path;
        public string lang;
        public List<PossitionOfWord> listOfKeyPossitions;

    }
}