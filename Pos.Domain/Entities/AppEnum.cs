﻿using CloudDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain.Entities
{
    public class AppEnum : DefaultEntity
    {
        public string Name { get; set; }
        public int Type { get; set; }

        public List<Application> Applications { get; set; }
    }
}
