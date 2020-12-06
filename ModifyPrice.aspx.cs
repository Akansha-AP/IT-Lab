using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lab6Q3
{
    public partial class ModifyPrice : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=SSPI";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                string selectSQL = "Select flavour from Items";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        ListItem item = new ListItem();
                        item.Text = item.Value = reader["flavour"].ToString();
                        lstItems.Items.Add(item);
                    }
                    reader.Close();
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
            }
        }

        protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL = "Select price from Items where flavour=@flavour";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.AddWithValue("@flavour", lstItems.SelectedItem.Text);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                lblInfo.Text = "Price= " + reader["price"];
                reader.Close();
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
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateSQL = "Update Items Set price=@price where flavour=@flavour";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(updateSQL, con);
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
            cmd.Parameters.AddWithValue("@flavour", lstItems.SelectedItem.Text);
            int updated = 0;
            try
            {
                con.Open();
                updated = cmd.ExecuteNonQuery();
                lblInfo.Text = "Price of " + lstItems.SelectedItem.Text + " changes to " + txtPrice.Text;
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
        }
    }
}