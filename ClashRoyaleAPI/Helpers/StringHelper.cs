using ClashRoyaleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClashRoyaleAPI.Helpers
{
    public class StringHelper
    {

        public static string GetReplacedURL(string text)
        {
            text = text.Replace("{", "").Replace("}", "").Trim();             
            text = text.Replace(ConstVariables.ReplaceImage, "").Replace(ConstVariables.tirnak, "").Trim();
            return text;
        }
    }
}