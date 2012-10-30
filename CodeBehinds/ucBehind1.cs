using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUAY.HUBOX.CodeBehinds
{
    public partial class ucBehind1 : ucBehind1Base
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Texto do controle1";
            
        }
    }
}