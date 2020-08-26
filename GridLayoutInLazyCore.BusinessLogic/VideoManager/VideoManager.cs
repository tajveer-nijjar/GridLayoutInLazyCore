using GridLayoutInLazyCore.Model.Dto;
using ProductX.BusinessLogic.WebApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VimeoDotNet;

namespace GridLayoutInLazyCore.BusinessLogic.VideoManager
{
    public class VideoManager : IVideoManager
    {
        private readonly IWebApiClient _webApiClient;

        private string accessToken = "686d8b1cb9aed775f933af6de095dd7b";

        public VideoManager(IWebApiClient webApiClient)
        {
            _webApiClient = webApiClient;
        }

        public async Task Authorize()
        {
            VimeoClient vimeoClient = new VimeoClient(accessToken: accessToken);
            try
            {
                var authCheck = await vimeoClient.GetAccountInformationAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<VimeoDotNet.Models.Paginated<VimeoDotNet.Models.Video>>GetListOfVideosInAnAlbum()
        {
            VimeoClient vimeoClient = new VimeoClient(accessToken: accessToken);

            var videos = await vimeoClient.GetAlbumVideosAsync(121979314, 7483158);
            return videos;
        }

        public async Task<string> GetVideoConfig(string uri)
        {
            var response = await _webApiClient.GetVideoConfig(uri);
            return response;
        }

        public async Task<ValidationResponse> Validate()
        {
            return await _webApiClient.Validate();
        }
    }
}
