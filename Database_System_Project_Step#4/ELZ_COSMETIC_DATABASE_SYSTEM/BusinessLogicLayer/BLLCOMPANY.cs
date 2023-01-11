using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
   public class BLLCOMPANY
    {
        public static int CompanyAddBLL(EntityCompany p)
        {
            if (p.IbanNumber1 != null)

            {
                return DALCOMPANY.CompanyAdd(p);
            }
            return -1;
        }
        public static List<EntityCompany> BLList()
        {
            return DALCOMPANY.Companylist();


        }
        public static bool CompanyDeleteBLL(string p)
        {
            if (p != null)
            {
                return DALCOMPANY.CompanyDelete(p);
            }
            return false;

        }
        public static List<EntityCompany> BLLDetail(string p)
        {
            return DALCOMPANY.CompanyDetail(p);


        }
    }
}
