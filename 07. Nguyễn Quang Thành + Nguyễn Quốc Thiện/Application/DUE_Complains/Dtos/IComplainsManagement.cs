using DUE_Complains.Dtos.Commons;
using DUE_Complains.Dtos.Complains;
using DUE_Complains.Dtos.Complains.management;
using DUE_Complains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos
{
    public interface IComplainsManagement
    {
        public  Task<int> CreateDraft(ComplainsCreateRequest request);
        public Task<int> Delete(int IdComplain);
        public Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request);
        public Task<List<ComplainsViewModel>> GetAll();
        public Task<ComplainsViewModel> GetbyId(int IDComplain);
        public Task<int> EditCraft(EditDraftRequest request);
        public Task<int> PostRequest(EditDraftRequest request);
        public Task<int> ReplyComplain(string reply, int idcomplains);

        public Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request);
    }
}
