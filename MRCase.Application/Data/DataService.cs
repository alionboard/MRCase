using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MRCase.Application.Data.Dtos;
using MRCase.Application.Pagination;
using MRCase.Core.Data;
using MRCase.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCase.Application.Data
{
    public class DataService : IDataService
    {
        private readonly ApplicationDbContext context;

        public DataService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<PagedList<Datum>> Get(PagingParameters pagingParameters, string userId)
        {
            var query = context.Data.Where(x => x.UserId == userId);
            return await Task.FromResult(PagedList<Datum>.ToPagedList(query, pagingParameters.PageNumber, pagingParameters.PageSize));
        }

        public void ImportData(Datum[] data, string userId)
        {
            foreach (var item in data)
                item.UserId = userId;

            context.AddRange(data);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await context.SaveChangesAsync()) > 0;
        }
    }
}
