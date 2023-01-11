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
    public class BLLEMPLOYEE
    {
        public static List<EntityEmployee> BLListe()
        {
            return DALEMPLOYEE.Employeelist();


        }
    }
}
