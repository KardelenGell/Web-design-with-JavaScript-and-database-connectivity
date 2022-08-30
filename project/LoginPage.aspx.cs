using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Data;

namespace FinalProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Label2.Text = "Lütfen kullanıcı adınızı ve şifrenizi giriniz.";
                return;
            }


            DBConnection dbcon = new DBConnection();
            string sqlstr = "select uyeID, fName, lName from Uye where fName='" + TextBox1.Text + "' and uyeID=" + TextBox2.Text;
            DataSet ds = new DataSet();
            ds = dbcon.getSelect(sqlstr);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Session["id"] = ds.Tables[0].Rows[0]["uyeID"].ToString();
                Session["name"] = ds.Tables[0].Rows[0]["fName"].ToString() + " " + ds.Tables[0].Rows[0]["lName"].ToString();
                Response.Redirect("Form.aspx");
            }
           
             Label2.Text = "Yanlış kullanıcı adı veya şifre!";
        }
}
}