﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika24_1.Type
{
    public class Product
    {
        //Id что бы адекватно удалять
        public int Id { get; set; }
        //название
        public string Title { get; set; }
        //цена
        public int Price { get; set; }
    }
}
