using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Customer"] != null)
        {
            Customer c = (Customer)Session["Customer"];
            txtLastName.Text = c.LastName;
            txtFirst.Text = c.FirstName;
            txtEmail.Text = c.Email;
            txtPhone.Text = c.Phone;
        }
        else
        {
            Response.Redirect("Default.aspx");
        }


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string last = txtLastName.Text;
        Response.Redirect("Default3.aspx?lastname=" + last);
    }
}