using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txt1.Text)>=0)
            {
                Label3.Text = txt1.Text;
                lblDollars.Text = Convert.ToString(Convert.ToDouble(txt1.Text) * 0.15);
            }
            else
            {
                lblmessage.Text = "error number!";
            }
           
        }
    }
}