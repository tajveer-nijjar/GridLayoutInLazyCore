using GridLayoutInLazyCore.Model.Dto;
using ProductX.BusinessLogic.WebApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GridLayoutInLazyCore.BusinessLogic.VideoManager
{
    public class VideoManager : IVideoManager
    {
        private readonly IWebApiClient _webApiClient;

        public VideoManager(IWebApiClient webApiClient)
        {
            _webApiClient = webApiClient;
        }

        public async Task<ValidationResponse> Validate()
        {
            return await _webApiClient.Validate();
        }
    }
}
