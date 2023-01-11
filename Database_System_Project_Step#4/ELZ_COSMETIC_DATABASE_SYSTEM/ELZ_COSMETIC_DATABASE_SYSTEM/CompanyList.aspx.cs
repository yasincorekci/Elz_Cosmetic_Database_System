using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace ELZ_COSMETIC_DATABASE_SYSTEM
{
    public partial class CompanyList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityCompany> list  = BLLCOMPANY.BLList();
            Repeater1.DataSource= list;
            Repeater1.DataBind();


        }
    }
}