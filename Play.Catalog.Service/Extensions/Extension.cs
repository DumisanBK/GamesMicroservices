using Play.Catalog.Service.Dtos;
using Play.Catalog.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service.Extensions
{
    public static class Extension
    {
        public static ItemDto AsDto(this Item item) 
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}
