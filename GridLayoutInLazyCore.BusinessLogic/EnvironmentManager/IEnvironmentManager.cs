using System;
using System.Collections.Generic;
using System.Text;

namespace ProductX.BusinessLogic.EnvironmentManager
{
    public interface IEnvironmentManager
    {
        Uri FormatUriForSelectedEnvironment(string action, params object[] methodParameters);
    }
}
