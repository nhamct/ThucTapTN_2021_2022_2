using DUE_Complains.Dtos.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos.Complains
{
    public interface IPublicComplains
    {
        Task<PageResult<ComplainsViewModel>> GetAllComplainsByDep(GetComplainsPagingRequest request);

    }
}
