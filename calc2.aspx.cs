using System;
using System.Web.UI;

namespace notesCont
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0") { 
                Session["num"] = "y";
            }
        }

        protected void div_Click(object sender, EventArgs e)
        {
            Session["op"] = "÷";
            Session["decimal"] = null;
        }

        protected void multi_Click(object sender, EventArgs e)
        {
            Session["op"] = "x";
            Session["decimal"] = null;
        }

        protected void min_Click(object sender, EventArgs e)
        {
            Session["op"] = "-";
            Session["decimal"] = null;
        }

        protected void plus_Click(object sender, EventArgs e)
        {
            Session["op"] = "+";
            Session["decimal"] = null;
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            try {
            float fv;
            try {
                fv = float.Parse(Session["FirstValue"].ToString());
            } catch
            {
                fv = 0;
            }
            float sv = float.Parse(Session["SecondValue"].ToString());
            string op = Session["op"].ToString();
            switch (op)
            {
                case "÷":
                    if (fv != 0 && sv != 0) {
                    txtDisplay.Text = (fv / sv).ToString();
                    } else
                    {
                        txtDisplay.Text = "0";
                    }
                    break;
                case "x":
                    txtDisplay.Text = (fv * sv).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (fv - sv).ToString();
                    break;
                case "+":
                    txtDisplay.Text = (fv + sv).ToString();
                    break;
            }
            Session.Clear();
            Session["FirstValue"] = txtDisplay.Text;
            Session["num"] = "y";
            } catch { }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            AssignValue(9);
        }
        protected void btn8_Click(object sender, EventArgs e)
        {
            AssignValue(8);
        }
        protected void btn7_Click(object sender, EventArgs e)
        {
            AssignValue(7);
        }
        protected void btn6_Click(object sender, EventArgs e)
        {
            AssignValue(6);
        }
        protected void btn5_Click(object sender, EventArgs e)
        {
            AssignValue(5);
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            AssignValue(4);
        }
        protected void btn3_Click(object sender, EventArgs e)
        {
            AssignValue(3);
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            AssignValue(2);
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            AssignValue(1);
        }
        protected void btn0_Click(object sender, EventArgs e)
        {
            AssignValue(0);
        }

        public float AssignValue(float buttonVal)
        {
            string numcheck = Session["num"].ToString();
            try
            {
                string op = Session["op"].ToString();
                try
                {
                    float sv = float.Parse(Session["SecondValue"].ToString());
                    object dec = Session["decimal"];
                    switch (dec)
                    {
                        case "on":
                            Session["SecondValue"] = sv.ToString() + "." + buttonVal.ToString();
                            Session["decimal"] = "off";
                            break;
                        default:
                            Session["SecondValue"] = sv.ToString() + buttonVal.ToString();
                            break;
                    }
                }
                catch
                {
                    object dec = Session["decimal"];
                    switch (dec)
                    {
                        case "on":
                            Session["SecondValue"] = "." + buttonVal;
                            Session["decimal"] = "off";
                            break;
                        default:
                            Session["SecondValue"] = buttonVal;
                            break;
                    }
                }
            }
            catch
            {
                
                if (numcheck == "y" || txtDisplay.Text.Trim( ) == "0")
                {
                    object dec = Session["decimal"];
                    switch (dec)
                    {
                        case "on":
                            Session["FirstValue"] = "." + buttonVal;
                            Session["decimal"] = "off";
                            break;
                        default:
                            Session["FirstValue"] = buttonVal;
                            break;
                    }
                    Session["num"] = "n";
                }
                else
                {
                    float fv = float.Parse(Session["FirstValue"].ToString());
                    object dec = Session["decimal"];
                    switch (dec)
                    {
                        case "on":
                            Session["FirstValue"] = fv.ToString() + "." + buttonVal.ToString();
                            Session["decimal"] = "off";
                            break;
                        default:
                            Session["FirstValue"] = fv.ToString() + buttonVal.ToString();
                            break;
                    }
                }
            }

            string p1, p2, p3;
            try
            {
                p1 = Session["FirstValue"].ToString() + " ";
            }
            catch
            {
                p1 = "0";
            }
            try
            {
                p2 = Session["op"].ToString() + " ";
            }
            catch
            {
                p2 = "";
            }
            try
            {
                p3 = Session["SecondValue"].ToString();
            }
            catch
            {
                p3 = "";
            }
            txtDisplay.Text = p1 + p2 + p3;
            return buttonVal;
        }

        protected void dec_Click(object sender, EventArgs e)
        {
            if (Session["decimal"] == null)
            {
                if (Session["num"].ToString() == "y")
                {
                    AssignValue(0);
                    Session["num"] = "n";
                }
                Session["decimal"] = "on";
            } else if (Session["decimal"].ToString() == "off"){ }
            else
            {
                if (Session["num"].ToString() == "n")
                {
                    Session["num"] = "y";
                }
                Session["decimal"] = null;
            }
        }
    }
}