using GridLayoutInLazyCore.Application.Views;
using LazyCore.Foundation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLayoutInLazyCore.Application.ViewControllers
{
    public class HomeController : ViewControllerBase<IHomeView>
    {
        public HomeController(IViewService viewService) : base(viewService)
        {
        }

        protected override void ViewLoaded()
        {
            // View logic
        }
    }
}
