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
                DoSafeAsync(Validate);
            };

            View.ValidateButtonClicked += () =>
            {
                var x = 10;
            };

            //View.ValidateButton.Clicked += (s, e) => DoSafeAsync(Validate);
            //View.ValidateButton.Clicked += (s, e) =>
            //{
            //    var x = 10;
            //};
        }

        public async Task Validate()
        {
            var x = await _videoManager.Validate();
        }
    }
}
