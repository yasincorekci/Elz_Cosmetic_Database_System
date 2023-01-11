using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALEMPLOYEE
    {
        public static List<EntityEmployee> Employeelist()
        {

            List<EntityEmployee> value = new List<EntityEmployee>();
            SqlCommand task5 = new SqlCommand("Select *From EMPLOYEE ", Connection.bgl);

            if (task5.Connection.State != ConnectionState.Open)
            {
                task5.Connection.Open();

            }
            SqlDataReader dr = task5.ExecuteReader();
            while (dr.Read())
            {
                EntityEmployee ent = new EntityEmployee();
                ent.Ssn1 = int.Parse(dr["Ssn"].ToString());
                ent.FirstName1 = (dr["FirstName"].ToString());
                ent.LastName1 = (dr["LastName"].ToString());
                ent.Birthdate1 = (dr["Birthdate"].ToString());
                ent.Age1 = int.Parse(dr["Age"].ToString());
                ent.Dno1 = int.Parse(dr["Dno"].ToString());
                ent.Gender1 = (dr["Gender"].ToString());
                ent.Country1 = (dr["Country"].ToString());
                ent.City1 = (dr["City"].ToString());
                ent.Salary1 = int.Parse(dr["Salary"].ToString());
                ent.DName1 = (dr["DName"].ToString());
                value.Add(ent);

            }
            dr.Close();
            return value;
        }

    }
}