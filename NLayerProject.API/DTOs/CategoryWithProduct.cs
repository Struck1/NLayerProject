using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.DTOs
{
    public class CategoryWithProduct : CategoryDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
