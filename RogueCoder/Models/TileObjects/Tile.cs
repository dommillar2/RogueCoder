﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RogueCoder.Models
{
    [Serializable]
    public class Tile : BaseGameObject
    {
        public string FileName {get;set;}
        public int row { get; set; }
        public int col { get; set; }
        public string[] directionImage { get; set; }
        public bool canMove {get;set;}
        public bool blocked { get; set; }                 
        public bool visible { get; set; }
        public bool HasLaptop { get; set; }
    }
}

