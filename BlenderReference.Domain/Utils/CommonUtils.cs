using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlenderReference.Domain.Utils
{
    public static class CommonUtils
    {
        public static int? ConvertBoolToInt(bool? booleanValue)
        {
            if(!booleanValue.HasValue)
            {
                return null;
            }

            if (booleanValue.Value)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public static string GetApplicationPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

       

    }
}
