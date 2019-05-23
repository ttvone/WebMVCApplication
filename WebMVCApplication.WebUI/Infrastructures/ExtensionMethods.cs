using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCApplication.WebUI.Infrastructures
{
    public static class ExtensionMethods
    {
        public static Exception GetInnerException(this Exception exception)
        {
            if (exception.InnerException != null)
                return exception.InnerException.GetBaseException();
            return exception;
        }
    }
}