using System;
using System.Collections.Generic;
using System.Text;

namespace ProductX.BusinessLogic.EnvironmentManager
{
    public class EnvironmentManager : IEnvironmentManager
    {

        public Uri FormatUriForSelectedEnvironment(string action, params object[] methodParameters)
        {
            return new Uri(string.Format(GetUri(action), methodParameters));
        }

        private string GetUri(string action)
        {
            var apiBase = "https://api.vimeo.com";  //TODO choose from selected environment

            if (apiBase.EndsWith("/"))
            {
                apiBase = apiBase.Substring(0, apiBase.Length - 1);
            }

            if (string.IsNullOrEmpty(action))
            {
                return apiBase + "/" + "{0}";
            }

            if (!action.StartsWith("/"))
            {
                action = "/" + action;
            }

            return apiBase + action + "/" + "{0}";
        }
    }
}
