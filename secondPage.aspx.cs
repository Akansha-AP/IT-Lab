using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5Q4
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string mobile = ((ListItem)Session["Mobile"]).Text;
            MobileMaster master = (MobileMaster)this.Master;
            master.SetLabel = mobile;
            switch (mobile)
            {
                case "Samsung":
                    lblInfo.Text = "RAM: 4GB";
                    lblInfo.Text += "<br/>Battery: 4000mAh";
                    lblInfo.Text += "<br/>OS: Android10";
                    break;
                case "Apple":
                    lblInfo.Text = "RAM: 8GB";
                    lblInfo.Text += "<br/>Battery: 6000mAh";
                    lblInfo.Text += "<br/>OS: AppleIOS";
                    break;
                case "Motorola":
                    lblInfo.Text = "RAM: 2GB";
                    lblInfo.Text += "<br/>Battery: 2000mAh";
                    lblInfo.Text += "<br/>OS: Android Pi";
                    break;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("firstPage.aspx");
        }
    }
}