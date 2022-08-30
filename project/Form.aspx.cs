using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FinalProject
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Değerlendirme Sayfasına Hoş Geldin " + Session["name"];
            Label4.Text = "";

            if (IsPostBack == false)
            {
                DBConnection dbcon = new DBConnection();
                DataSet ds = new DataSet();
                ds = dbcon.getSelect("select type FROM Books GROUP BY type HAVING COUNT(*) > 1");
                DropDownList1.DataTextField = ds.Tables[0].Columns["type"].ToString(); 
                DropDownList1.DataValueField = ds.Tables[0].Columns["type"].ToString(); 
                DropDownList1.DataSource = ds.Tables[0]; 
                DropDownList1.DataBind(); 

                DropDownList1.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                DropDownList1.SelectedIndex = 0;

                PopulateCheckList();
            }
        }
        private void PopulateCheckList()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager
                .ConnectionStrings["conStr"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT typeID,tName from Type order by typeID";
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = sdr["tName"].ToString();
                            item.Value = sdr["typeID"].ToString();
                            item.Selected = false;
                            CheckBoxList1.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Text = "Form gönderildi!";
            // MessageBox.Show("Form gönderildi!", "Bilgilendirme Penceresi");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection con;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            String sqlstr = "Insert into Type(typeID,tName) values(" + TextBox5.Text + ",'" + TextBox6.Text + "')";
            try
            {
                SqlCommand exec = new SqlCommand(sqlstr, con);
                exec.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception) { throw; }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }

            DataSet ds = new DataSet();
            string sqlstr;
            sqlstr = "select * from Type";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, connectionString);
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection con;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            String sqlstr = "Delete from Type where typeID=" + TextBox5.Text + "";
            try
            {
                SqlCommand exec = new SqlCommand(sqlstr, con);
                exec.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            String connectionString;
            SqlConnection con;
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }
            String sqlstr = "UPDATE Type SET tName='" + TextBox6.Text + "' WHERE typeID='" + TextBox5.Text + "'";
            try
            {
                SqlCommand exec = new SqlCommand(sqlstr, con);
                exec.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}