﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RusMProjectApplication.Abstraction
{
    public interface IApplicationSettingsAble
    {
        string ConnectionString { get; }
        public string JwtKey { get; }
    }
}