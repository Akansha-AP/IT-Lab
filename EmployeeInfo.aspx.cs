using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Lab6Q4
{
    public partial class EmployeeInfo : System.Web.UI.Page
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                FillCompany();
            }
        }

        public void FillCompany()
        {
            lstCompany.Items.Clear();
            string selectSql = "Select distinct(company_name) from Works";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = reader["company_name"].ToString();
                    item.Value = reader["company_name"].ToString();
                    lstCompany.Items.Add(item);

                }
                reader.Close();
            }
            catch(Exception err)
            {
                lblInfo.Text = "Error retrieving data. ";
                lblInfo.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string insertSql = "Insert into works (person_name,company_name,salary) values (";
            insertSql += "@person,@company,@salary)";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(insertSql, con);
            cmd.Parameters.AddWithValue("@person", txtPerson.Text);
            cmd.Parameters.AddWithValue("@company", txtCompany.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            int insert = 0;
            try
            {
                con.Open();
                insert = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                lblInfo.Text = "Error inserting data. ";
                lblInfo.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
            if(insert>0)
            {
                lblInfo.Text = insert.ToString() + " record inserted.";
                FillCompany();
            }
        }

        protected void lstCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSql = "Select w.person_name,l.city from Lives l,Works w where l.person_name=w.person_name and w.company_name=@company";
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSql, con);
            cmd.Parameters.AddWithValue("@company", lstCompany.SelectedItem.Text);
            SqlDataReader reader;
            lblCompanyInfo.Text = "";
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    lblCompanyInfo.Text += "<br/>Name= " + reader["person_name"].ToString();
                    lblCompanyInfo.Text += "  City= " + reader["city"].ToString();
                   
                }
                
                reader.Close();
            }
            catch (Exception err)
            {
                lblInfo.Text = "Error retrieving data. ";
                lblInfo.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}