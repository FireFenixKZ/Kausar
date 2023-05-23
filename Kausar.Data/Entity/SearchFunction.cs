﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kausar.Data.Entity
{
    public class SearchFunction
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Url { get; set; }
        public string VisibleFor { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
