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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityCompany ent = new EntityCompany();
            ent.TaxID1 = TxtTaxID.Text;
            ent.CompanyName1 = TxtCname.Text;
            ent.Country1 = TxtCountry.Text;
            ent.City1 = TxtCity.Text;
            ent.PostalCode1 =TxtPostalCode.Text;
            ent.IbanNumber1 = TxtIbanNumber.Text;
            ent.OrderID1 = TxtOrderID.Text;
            ent.ProductID1 =TxtProductID.Text;
            BLLCOMPANY.CompanyAddBLL(ent);




        }
    }
}