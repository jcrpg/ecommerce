﻿using EcommerceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetById(int id);

        void Insert(Picture picture);

        void Update(Picture picture);

        void Delete(int id);
        
        void Save();

    }
}
