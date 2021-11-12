﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspViolationApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public virtual int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public virtual int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int CalculateArea()
        {
            return _width * _height;

        }
    }
}

