using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lab6Q1
{
    public partial class HouseKeeping : System.Web.UI.Page
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HouseKeeping;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                string selectSQL = "SELECT StaffID FROM Staff";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dsStaff = new DataSet();
                try
                {
                    con.Open();
                    adapter.Fill(dsStaff, "Staff");
                }
                catch(Exception err)
                {
                    lblInfo.Text = "Error in retrieving data. ";
                    lblInfo.Text += err.Message;
                }
                finally
                {
                    con.Close();
                }
                foreach(DataRow row in dsStaff.Tables["Staff"].Rows)
                {
                    ListItem item = new ListItem();
                    item.Text = row["StaffID"].ToString();
                    item.Value = row["StaffID"].ToString();
                    lstID.Items.Add(item);
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateSQL = "Update Staff Set City=@city";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(updateSQL, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dbStaff = new DataSet();
            cmd.Parameters.AddWithValue("@city", lstCity.SelectedValue);
            try
            {
                con.Open();
                adapter.Fill(dbStaff, "Staff");
            }
            catch (Exception err)
            {
                lblInfo.Text = "Error in updating data. ";
                lblInfo.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
            lblInfo.Text = "Row Updated.";
        }

        protected void lstID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSql = "Select * from Staff where StaffID=" + lstID.SelectedValue;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSql, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dbStaff = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(dbStaff, "Staff");
            }
            catch (Exception err)
            {
                lblInfo.Text = "Error in retrieving data. ";
                lblInfo.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
            lblInfo.Text = "ID= " + dbStaff.Tables["Staff"].Rows[0]["StaffID"];
            lblInfo.Text += "<br/>First Name= " + dbStaff.Tables["Staff"].Rows[0]["FirstName"];
            lblInfo.Text += "<br/>Last Name= " + dbStaff.Tables["Staff"].Rows[0]["LastName"];
            lblInfo.Text += "<br/>Dno Name= " + dbStaff.Tables["Staff"].Rows[0]["DNo"];
            lblInfo.Text += "<br/>Street= " + dbStaff.Tables["Staff"].Rows[0]["Street"];
            lblInfo.Text += "<br/>City= " + dbStaff.Tables["Staff"].Rows[0]["City"];
            lblInfo.Text += "<br/>State= " + dbStaff.Tables["Staff"].Rows[0]["State"];
            lblInfo.Text += "<br/>Zipcode= " + dbStaff.Tables["Staff"].Rows[0]["ZipCode"];
        }
    }
}