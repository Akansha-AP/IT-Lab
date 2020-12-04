using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5Q4
{
    public partial class MobileMaster : System.Web.UI.MasterPage
    {
        public string SetLabel
        {
            set { lblMobile.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}