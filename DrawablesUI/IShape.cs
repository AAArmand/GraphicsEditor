﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawablesUI
{
    public interface IShape : IDrawable
    {
        string Description { get; }
    }
}