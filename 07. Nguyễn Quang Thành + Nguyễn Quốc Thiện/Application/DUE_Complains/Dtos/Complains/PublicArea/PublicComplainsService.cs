using DUE_Complains.Dtos.Commons;
using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Complains.PublicArea
{
    public class PublicComplainsService : IPublicComplains
    {
        private readonly Complains_DUEContext _context;
        PublicComplainsService(Complains_DUEContext context)
        {

            _context = context;
        }
        public async Task<PageResult<ComplainsViewModel>> GetAllComplainsByDep(GetComplainsPagingRequest request)
        {


            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where c.Content.Contains(request.keyword)
                        select new { c, d };

            if (request.idDepartment != null  && Convert.ToInt32(request.idDepartment) > 0)
            {
                query = query.Where(p => request.idDepartment.Contains(p.c.IdDepartment));
            }
            int rows = await query.CountAsync();

            var data = await query.Skip((request.pageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic
                }).ToListAsync();
            var pageResult = new PageResult<ComplainsViewModel>()
            {
                TotalRecord = rows,
                item = data

            };
            return pageResult;
        }
    }
}
