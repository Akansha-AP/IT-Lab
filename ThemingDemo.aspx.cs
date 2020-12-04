using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5Q3
{
    public partial class ThemingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string[] themes = { "Summer", "Monsoon" };
                DropDownList1.DataSource = themes;
                DropDownList1.DataBind();
            }
            if (Session["Theme"] != null)
            {
                DropDownList1.Items.FindByText(((ListItem)Session["Theme"]).Text).Selected = true;

            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["Theme"] != null)
            {
                Page.Theme =((ListItem)Session["Theme"]).Text;
                /*if (Session["Theme"].ToString() == "Summer")
                {
                    pageBody.Attributes.Add("bgcolor", "#B7FFFF");
                    Label1.Text = "Summer";
                }
                else if (Session["Theme"].ToString() == "Monsoon")
                {
                    pageBody.Attributes.Add("bgcolor", "#D8D8D8");
                    Label1.Text = "Monsoon";
                }*/
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Theme"] = DropDownList1.SelectedItem;
            Response.Redirect(Request.FilePath);
        }
    }
}