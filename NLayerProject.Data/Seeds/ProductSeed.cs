using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>

    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {

            _ids = ids;


        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Kalem", Price = 10.99m, Stock = 888, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Pilot Kalem", Price = 18.99m, Stock = 88, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Defter", Price = 10.99m, Stock = 888, CategoryId = _ids[1] },
                new Product { Id = 4, Name = "Bütük Boy Defter", Price = 10.99m, Stock = 888, CategoryId = _ids[1] }
                );
        }
    }
}
