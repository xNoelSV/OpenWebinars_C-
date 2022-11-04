﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    public struct ShelvePosition
    {

        public ShelvePosition(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; set; }

        public int Column { get; set; }

    }
}
