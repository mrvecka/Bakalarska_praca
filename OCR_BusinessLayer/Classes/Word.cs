﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR_BusinessLayer.Classes
{
    public class Word
    {
        public string Text { get; set; }
        public Rectangle Bounds { get; set; }
    }
}