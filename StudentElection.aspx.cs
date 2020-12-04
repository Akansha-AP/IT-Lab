using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5Q1
{
    public partial class StudentElection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                string[] candidates = { "Shreyash", "Ayush", "Avneesh", "Vaishali", "Akansha" };
                lstCandidate.DataSource = candidates;
                lstCandidate.DataBind();

                string[] houses = { "Ruby", "Emrald", "Sapphire", "Topaz" };
                lstHouse.DataSource = houses;
                lstHouse.DataBind();

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            
            if (Page.IsValid)
            {
                pnl.Visible = false;
                lblMsg.Text = "Success";
            }
        }
        

        protected void NumberValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            /*try
            {*/
                string no = txtPhone.Text;
                if (no.Length!=10)
                {
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
                }
           /* }
            catch
            {
                args.IsValid = false;
            }*/
        }
    }
}