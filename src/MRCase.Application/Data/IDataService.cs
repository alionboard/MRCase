using MRCase.Application.Data.Dtos;
using MRCase.Application.Pagination;
using MRCase.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCase.Application.Data
{
    public interface IDataService
    {
        Task<PagedList<Datum>> GetPagedDataAsync(PagingParameters pagingParameters, string userId);
        Datum GetByIdAsync(int id);
        Task<IQueryable<Datum>> GetAllAsync(string userId);
        void ImportData(Datum[] data, string userId);
        void DeleteAll(IQueryable<Datum> data);
        void DeleteOne(Datum data);
        Task<bool> SaveChangesAsync();

    }
}
