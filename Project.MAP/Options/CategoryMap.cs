﻿using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            Property(x => x.CategoryName).HasColumnName("Kategori Adı");
            Property(x => x.Description).HasColumnName("Açıklama");
            ToTable("Kategoriler");






        }









    }
}