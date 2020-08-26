using GridLayoutInLazyCore.Model.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GridLayoutInLazyCore.BusinessLogic.VideoManager
{
    public interface IVideoManager
    {
        Task<ValidationResponse> Validate();
    }
}
