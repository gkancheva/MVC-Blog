using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Blog.UtilsClasses
{
    public class Utils
    {
        public static string CutText(string text, int maxLength = 100)
        {
            if (text == null || text.Length <= maxLength)
            {
                return text;
            } else
            {
                return text.Substring(0, maxLength) + "...";
            }
        }

        public static string CutTexPostHome(string text, int maxLength = 300)
        {
            if (text == null || text.Length <= maxLength)
            {
                return text;
            }
            else
            {
                return text.Substring(0, maxLength) + "...";
            }
        }
    }
}