using DUE_Complains.Dtos.Commons;
using DUE_Complains.Dtos.Complains.management;
using DUE_Complains.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.IO;

namespace DUE_Complains.Dtos.Complains
{
    public class ManageComplainsService : IComplainsManagement
    {
        private readonly Complains_DUEContext _context;
        private readonly IStorageService _storageService;


        public ManageComplainsService(Complains_DUEContext context, IStorageService storageService)
        {

            _context = context;
            _storageService = storageService;
        }
        public async Task<int> CreateDraft(ComplainsCreateRequest request)
        {
            var complain = new Complain()
            {
                IdStudent = request.IdStudent,
                IdDepartment = request.IdDepartment,
                Title = request.Title,
                Content = request.Content,
                Status = "Bản nháp",
                IsPublic = false,
                //DepInfo = new List<Department>()
                //{
                //    new Department()
                //    {
                //        Name = request.Department
                //    }
                //}

            };
            if (request.ThumbnailImage != null)
            {
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true
                    }
                };
            }
            _context.Complains.Add(complain);
             await _context.SaveChangesAsync();
            return complain.IdComplains;
        }


        public async Task<int> Delete(int idComplain)
        {
            var complain = await _context.Complains.FindAsync(idComplain);
            var images =  _context.ImageComplains.Where( i => i.IdComplain == complain.IdComplains);
            foreach (var item in images)
            {
                await _storageService.DeleteFileAsync(item.Path_image);
            }
            _context.Complains.Remove(complain);
            return await _context.SaveChangesAsync();

        }

        public async Task<int> EditCraft(EditDraftRequest request)
        {
            var complain = await _context.Complains.FindAsync(request.IdComplain);

            complain.Title = request.Title;
            complain.Content = request.Content;
            complain.Date = DateTime.Now;
            complain.IdDepartment = request.IdDepartment;
            if (request.ThumbnailImage != null)
            {
                var thumbnailimage = await _context.ImageComplains.FirstOrDefaultAsync(i => i.IsDefault == true && i.IdComplain == request.IdComplain);
                if (thumbnailimage != null)
                {

                    thumbnailimage.filesize = Convert.ToInt32(request.ThumbnailImage.Length);
                    thumbnailimage.Path_image = await this.SaveFile(request.ThumbnailImage);
                    _context.ImageComplains.Update(thumbnailimage);
                };
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                    }
                };
            }
            return await _context.SaveChangesAsync();

        }

        public async Task<List<ComplainsViewModel>> GetAll()
        {
            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId                       
                        where c.IsPublic.Equals(true)
                        select new { c, d };
           

            var data = await query.Select(x => new ComplainsViewModel()
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
           
            return data;
        }

        public async Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request)
        {

            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where /*c.Content.Contains(request.keyword) &&*/ c.IsPublic.Equals(true)
                        select new {c, d };
            if (!string.IsNullOrEmpty(request.keyword))
            {
                query = query.Where(x => x.c.Content.Contains(request.keyword));
            }

            if(request.idDepartment != null)
            {
                query = query.Where(p => request.idDepartment.Contains(p.d.DepartmentId));
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

        public async Task<ComplainsViewModel> GetbyId(int IDComplain)
        {

            var complain = await _context.Complains.FindAsync(IDComplain);
         


            var complainview = new ComplainsViewModel()
            {
                IdComplains = complain.IdComplains,
                Content = complain.Content,
                Title = complain.Title,
                Date = complain.Date,
                Reply = complain.Reply,
                Status = complain.Status
            };
            return complainview;
        }

        public async Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request)
        {
            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where c.IdStudent.Equals(request.idStudent)
                        select new { c, d };
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

        public async Task<int> PostRequest(EditDraftRequest request)
        {
            var complain = await _context.Complains.FindAsync(request.IdComplain);

            complain.Title = request.Title;
            complain.Content = request.Content;
            complain.Date = DateTime.Now;
            complain.IdDepartment = request.IdDepartment;
            complain.Status = "Chờ duyệt";
            if (request.ThumbnailImage != null)
            {
                var thumbnailimage = await _context.ImageComplains.FirstOrDefaultAsync(i => i.IsDefault == true && i.IdComplain == request.IdComplain);
                if (thumbnailimage != null)
                {

                    thumbnailimage.filesize = Convert.ToInt32(request.ThumbnailImage.Length);
                    thumbnailimage.Path_image = await this.SaveFile(request.ThumbnailImage);
                    _context.ImageComplains.Update(thumbnailimage);
                };
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true
                    }
                };
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ReplyComplain(string reply, int idcomplains)
        {
            var complain = await _context.Complains.FindAsync(idcomplains);

            complain.Reply = reply;
            if (reply != null)
            {
                complain.Status = "Đã duyệt!";
                complain.IsPublic = true;
            }
            return await _context.SaveChangesAsync();

        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var origanalName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(origanalName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
