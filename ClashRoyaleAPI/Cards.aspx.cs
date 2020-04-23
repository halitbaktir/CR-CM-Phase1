using ClashRoyaleAPI.Helpers;
using ClashRoyaleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClashRoyaleAPI
{
    public partial class Cards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<CardModel> getCardResult = DataHelper.GetCards();
                StringBuilder sb = new StringBuilder();

                foreach (var item in getCardResult)
                {
                    string hREF = ConstVariables.Quot + item.IconURL + ConstVariables.Quot;
                    string blank = "target=" + ConstVariables.Quot + "_blank" + ConstVariables.Quot;

                    sb.Append("<tr>");
                    sb.Append("<td><a href=" + hREF + " " + blank + "></a><img src=" + hREF + " height=\"150px\" /></td>");
                    sb.Append("<td>" + item.Name + "</td>");
                    sb.Append("<td>" + item.MaxLevel + "</td>");
                    sb.Append("</tr>");
                }

                ltCardTable.Text = sb.ToString();
            }
        }
    }
}