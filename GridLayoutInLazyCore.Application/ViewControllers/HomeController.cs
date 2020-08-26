using GridLayoutInLazyCore.Application.Views;
using GridLayoutInLazyCore.BusinessLogic.VideoManager;
using LazyCore.Foundation.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GridLayoutInLazyCore.Application.ViewControllers
{
    public class HomeController : ViewControllerBase<IHomeView>
    {
        private readonly IVideoManager _videoManager;

        public HomeController(IViewService viewService, IVideoManager videoManager) : base(viewService)
        {
            _videoManager = videoManager;
        }

        protected override void ViewLoaded()
        {
            View.SendValidationRequest += () =>
            {
            };

            View.ValidateButton.Clicked += (s, e) =>
            {
                DoSafeAsync(Validate);
            };
        }

        public async Task Validate()
        {
            var videos = await _videoManager.GetListOfVideosInAnAlbum();
            var uri = videos.Data[1].Id.ToString();
            var mp4Url = await _videoManager.GetVideoConfig(uri);

            View.SetVideoUrl(mp4Url);
        }
    }
}
