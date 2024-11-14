﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_01
{
    internal class Button : Window 
    {
        //Phương thức khởi tạo 
        public Button(int top, int left) : base(top, left)//gọi constructor lớp cơ sở 
        { 
        }

        //ghi đè phương thức 
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }

    }
}