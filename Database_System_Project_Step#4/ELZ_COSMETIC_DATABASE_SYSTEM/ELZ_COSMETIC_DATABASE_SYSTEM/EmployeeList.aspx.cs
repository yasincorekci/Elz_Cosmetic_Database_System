
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
using System;

namespace ELZ_COSMETIC_DATABASE_SYSTEM
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityEmployee> list = BLLEMPLOYEE.BLListe();
            Repeater2.DataSource = BLLEMPLOYEE.BLListe();
            Repeater2.DataBind();

        }
    }
}