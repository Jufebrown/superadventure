﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}
