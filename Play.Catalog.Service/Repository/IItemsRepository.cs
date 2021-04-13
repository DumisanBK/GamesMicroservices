using Play.Catalog.Service.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Play.Catalog.Service.Repository
{
    public interface IItemsRepository
    {
        Task CreateAsync(Item entity);
        Task<IReadOnlyCollection<Item>> GetAllAysnc();
        Task<Item> GetAsync(Guid guid);
        Task RemoveAsync(Guid guid);
        Task UpdateAsync(Item entity);
    }
}