﻿using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface ICategoryService:IServices<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
        //Category özgü methodlar burada tanımlanır.
    }
}
