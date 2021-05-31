using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace notesCont.SQL
{
    public partial class DoNow : System.Web.UI.Page
    {
        CRUD cr = new CRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid2();
            }
        }
        public void BindGrid2()
        {
            DataTable dt = new DataTable();
            dt = cr.GetPatients();
            gvPatients2.DataSource = dt;
            gvPatients2.DataBind();
        }

        protected void gvPatients2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPatients2.EditIndex = e.NewEditIndex;
            BindGrid2();
        }

        protected void gvPatients2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvPatients2.EditIndex = -1;
            BindGrid2();
        }

        protected void gvPatients2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = (Label)gvPatients2.Rows[e.RowIndex].FindControl("lblID");
            cr.DeletePatient(int.Parse(id.Text));
            BindGrid2();
        }

        protected void gvPatients2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if(Session["switch"] != null)
            {
                TextBox txtGender = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtGender");
                Patient pt = new Patient();
                if (txtGender.Text == "Male") { pt.gender = false; } else { pt.gender = true; }
                BindGrid2();
                Session["switch"] = null;
            } else
            {
                Label id = (Label)gvPatients2.Rows[e.RowIndex].FindControl("lblID");
                TextBox txtName = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtName");
                TextBox txtAddress = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtAddress");
                DropDownList ddlDiagnosis = (DropDownList)gvPatients2.Rows[e.RowIndex].FindControl("ddlDiagnosis");
                TextBox txtAge = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtAge");
                TextBox txtZip = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtZip");
                TextBox txtSSN = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtSSN");
                DropDownList ddlState = (DropDownList)gvPatients2.Rows[e.RowIndex].FindControl("ddlState");
                TextBox txtSymptoms = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtSymptoms");
                TextBox txtAppointment = (TextBox)gvPatients2.Rows[e.RowIndex].FindControl("txtAppointment");
                
                Patient pt = new Patient();
                pt.name = txtName.Text;
                pt.address = txtAddress.Text;
                pt.ID = int.Parse(id.Text);
                pt.diagnosis = ddlDiagnosis.SelectedValue.ToString();
                //if (txtGender.Text == "False") { } else { }
                pt.age = int.Parse(txtAge.Text);
                pt.zip = int.Parse(txtZip.Text);
                pt.SSN = txtSSN.Text;
                pt.state = ddlState.SelectedValue.ToString();
                pt.symptoms = txtSymptoms.Text;
                pt.appointment = txtAppointment.Text;
                lblShow.Text = cr.UpdatePatientRec(pt);
                gvPatients2.EditIndex = -1;
                BindGrid2();
            }
        }

        protected void btnGender_Click(object sender, EventArgs e)
        {
            //Session["switch"] = "";
            //btnUpdate.PerformClick();
            //document.getElementById('<%= btnUpdate.ClientID %>').click();
            //Patient pt = new Patient();
            Button btnGender = (Button)sender;
            GridViewRow gvr = (GridViewRow)btnGender.NamingContainer;
            Label id = (Label)gvr.FindControl("lblID");
            Label Gender = (Label)gvr.FindControl("lblInvis");
            
            //bool chk = Gender.Text == "false" ? false : true;
            lblShow.Text = cr.UpdatePatientRec(Gender.Text,int.Parse(id.Text));
            gvPatients2.EditIndex = -1;
            BindGrid2();
        }
    }
}