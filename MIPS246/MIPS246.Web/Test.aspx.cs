﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StreamReader sr = new StreamReader("c:\\name.");
        string temp="";
        while ((temp=sr.ReadLine()) != null)
        {
            MIPS246UserManager.AddUser(temp);
        }
    }
}