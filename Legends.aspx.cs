using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Lab6Q2
{
    public partial class Legends : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> genre = new Dictionary<int, string>();
            genre.Add(1, "comedy");
            genre.Add(2, "romance");
            genre.Add(3, "animated");
            lstGenre.DataSource = genre.Values;
            lstGenre.DataBind();

        }

        protected void lstGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSql = "Select * from Legends Where category=@category";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSql, con);
            cmd.Parameters.AddWithValue("@category", lstGenre.SelectedItem.Text);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                
                while(reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = reader["name"].ToString();
                    lstLegends.Items.Add(item);
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

        protected void lstLegends_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSQL = "Select * from Legends Where name=@name";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            cmd.Parameters.AddWithValue("@name", lstLegends.SelectedItem.Text);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                lblInfo.Text = "Name= " + reader["name"];
                lblInfo.Text+= "<br/>Age= " + reader["age"]; 
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
    }
}