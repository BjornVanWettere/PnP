﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Contoso.Intranet.CONTROLTEMPLATES
{
    public partial class ContosoPageLayoutControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = string.Format("Time is {0}", DateTime.Now.ToString());
        }
    }
}
