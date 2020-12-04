using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5Q4
{
    public partial class firstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnShowDetails_Click(object sender, EventArgs e)
        {
            Session["Mobile"] = lstMobile.SelectedItem;
            Response.Redirect("secondPage.aspx");
        }

        protected void lstMobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Mobile"] = lstMobile.SelectedItem;
            MobileMaster master = (MobileMaster)this.Master;
            master.SetLabel = lstMobile.SelectedItem.Text;
        }
    }
}