﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VanishreeConsoleApp
{
    class Item
    {
        String name;
        String brand;
        Int32 price;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public void setBrand(String brand)
        {
            this.brand = brand;
        }
        public String getBrand()
        {
            return brand;
        }
        public void setPrice(Int32 price)
        {
            this.price = price;
        }
    }
}
