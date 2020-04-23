using ClashRoyaleAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ClashRoyaleAPI.Helpers
{
    public class DataHelper
    {


        public static string GetJSONResult(string endpointURL)
        {
            string finalURL = ConstVariables.BaseURL + endpointURL;
            WebHeaderCollection headers = new WebHeaderCollection();
            headers.Add($"Authorization: Bearer " + ConstVariables.AuthToken);
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(finalURL);
            getRequest.Method = "GET";
            getRequest.Headers = headers;
            WebResponse apiResponse = getRequest.GetResponse();
            StreamReader reader = new StreamReader(apiResponse.GetResponseStream(), Encoding.UTF8);
            string responseString = reader.ReadToEnd();
            reader.Close();
            apiResponse.Close();
            return responseString;
        }

        public static List<CardModel> GetCards()
        {
            string responseString = GetJSONResult(ConstVariables.CardsURL);

            JObject jObject = JObject.Parse(responseString);
            JArray cardList = (JArray)jObject.SelectToken("items");
            List<CardModel> cardModelList = new List<CardModel>();

            foreach (JToken item in cardList)
            {
                CardModel model = new CardModel();
                model.Name = item.SelectToken("name").ToString();
                model.ID = Convert.ToDecimal(item.SelectToken("id"));
                model.MaxLevel = Convert.ToDecimal(item.SelectToken("maxLevel"));
                model.IconURL = StringHelper.GetReplacedURL(item.SelectToken("iconUrls").ToString());
                cardModelList.Add(model);
            }
            return cardModelList;
        }

    }
}