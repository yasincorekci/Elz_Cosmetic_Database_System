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
    public class DALCOMPANY
    {
        public static int CompanyAdd(EntityCompany parametre)
        { 
            SqlCommand task1= new SqlCommand("insert into COMPANY TaxID,CompanyName,Country,City,PostalCode,IbanNumber,OrderID,ProductID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",Connection.bgl);
            if (task1.Connection.State != ConnectionState.Open) 
                {

                    task1.Connection.Open();
                }
                task1.Parameters.AddWithValue("@p1", parametre.TaxID1);
                task1.Parameters.AddWithValue("@p2", parametre.CompanyName1);
                task1.Parameters.AddWithValue("@p3", parametre.Country1);
                task1.Parameters.AddWithValue("@p4", parametre.City1);
                task1.Parameters.AddWithValue("@p5", parametre.PostalCode1);
                task1.Parameters.AddWithValue("@p6", parametre.IbanNumber1);
                task1.Parameters.AddWithValue("@p7", parametre.OrderID1);
                task1.Parameters.AddWithValue("@p8", parametre.ProductID1);
                return task1.ExecuteNonQuery();

        }
        public static  List<EntityCompany> Companylist()
        {

            List<EntityCompany> values = new List<EntityCompany>();
            SqlCommand task2 = new SqlCommand("Select *From COMPANY", Connection.bgl);

            if (task2.Connection.State != ConnectionState.Open)
            {
                task2.Connection.Open();

            }
            SqlDataReader dr = task2.ExecuteReader();
            while (dr.Read())
            {
                EntityCompany ent = new EntityCompany();
                ent.TaxID1 = (dr["TaxID"].ToString());
                ent.CompanyName1 = (dr["CompanyName"].ToString());
                ent.Country1 = (dr["Country"].ToString());
                ent.City1 = (dr["City"].ToString());
                ent.PostalCode1 = (dr["PostalCode"].ToString());
                ent.IbanNumber1 = (dr["IbanNumber"].ToString());
                ent.OrderID1 = (dr["OrderID"].ToString());
                ent.ProductID1 = (dr["ProductID"].ToString());
                values.Add(ent);

            }
            dr.Close();
            return values;
        }
        public static bool CompanyDelete(string parametre)
        {
            SqlCommand task3 = new SqlCommand("Delete From COMPANY Where TaxID=@p1", Connection.bgl);
            if (task3.Connection.State != ConnectionState.Open)
            {
                task3.Connection.Open();

            }
            task3.Parameters.AddWithValue("@p1", parametre);
            return task3.ExecuteNonQuery() > 0;
        }
        public static List<EntityCompany> CompanyDetail(string id)
        {

            List<EntityCompany> values = new List<EntityCompany>();
            SqlCommand task4 = new SqlCommand("Select *From COMPANY Where TaxID=@P1 ", Connection.bgl);
            task4.Parameters.AddWithValue("@p1", id);
            if (task4.Connection.State != ConnectionState.Open)
            {
                task4.Connection.Open();

            }
            SqlDataReader dr = task4.ExecuteReader();
            while (dr.Read())
            {
                EntityCompany ent = new EntityCompany();
                ent.TaxID1 = (dr["TaxID"].ToString());
                ent.CompanyName1 = (dr["CompanyName"].ToString());
                ent.Country1 = (dr["Country"].ToString());
                ent.City1 = (dr["City"].ToString());
                ent.PostalCode1 = (dr["PostalCode"].ToString());
                ent.IbanNumber1 = (dr["IbanNumber"].ToString());
                ent.OrderID1 = (dr["OrderID"].ToString());
                ent.ProductID1 = (dr["ProductID"].ToString());
                values.Add(ent);

            }
            dr.Close();
            return values;
        }
    }
}








