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
    public partial class CompanyDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string x = Convert.ToString(Request.QueryString["TaxID"]);
            Response.Write(x);
            EntityCompany ent = new EntityCompany();
            ent.TaxID1 = x;
            BLLCOMPANY.CompanyDeleteBLL(ent.TaxID1);
            Response.Redirect("CompanyList.Aspx");
        }   
    }
}