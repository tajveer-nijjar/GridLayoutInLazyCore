using LazyCore.Foundation.UI.Controls;
using LazyCore.Foundation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace GridLayoutInLazyCore.Application.Views
{
    public interface IHomeView : IView
    {
        event Action SendValidationRequest;
        event Action ValidateButtonClicked;

        void SetVideoUrl(string mp4Url);


        IButton ValidateButton { get; set; }
    }
}
