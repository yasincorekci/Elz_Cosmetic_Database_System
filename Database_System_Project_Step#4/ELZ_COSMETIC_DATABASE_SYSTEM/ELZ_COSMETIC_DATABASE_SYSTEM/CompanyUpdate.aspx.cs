using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using ELZ_COSMETIC_DATABASE_SYSTEM;


//namespace ELZ_COSMETIC_DATABASE_SYSTEM
//{
public partial class CompanyUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["TaxID1"].ToString());
            TxtTaxID.Text = x.ToString();
            TxtTaxID.Enabled= false;
            EntityCompany ent = new EntityCompany();    
            List<EntityCompany> list = BLLCOMPANY.BLLDetail(x);
            
            TxtCname.Text =CompanyList[0].CName.ToString();
            TxtCountry.Text = x.ToString();
            TxtCity.Text = x.ToString();
            TxtPostalCode.Text = x.ToString();
            TxtIbanNumber.Text = x.ToString();
            TxtOrderID.Text = x.ToString();
            TxtProductID.Text = x.ToString();
           

        }
    }
