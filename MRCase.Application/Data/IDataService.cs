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
        Task<PagedList<Datum>> Get(PagingParameters pagingParameters, string userId);
        void ImportData(Datum[] data,string userId);
        Task<bool> SaveChangesAsync();
    }
}
