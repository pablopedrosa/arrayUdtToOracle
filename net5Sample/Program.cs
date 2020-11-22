using System;
using System.Collections.Generic;
using System.Data;
//using Oracle.ManagedDataAccess.Client;
using Devart.Data.Oracle;


namespace net5Sample
{
    class CUSTOMER_TYP_DEMO
    {
        public int customer_id;
        public string cust_first_name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string oraStrConnection = "User Id=Ppedrosa; password=testpwd; Data Source=51.103.24.166:1521/CDB1; Pooling=false; License key=trial:C:\\ProgramData\\Devart\\dotConnect\\License\\Devart.Data.Oracle.key;";

            List<CustomerTypDemo> lstCustomer = new List<CustomerTypDemo>();
            lstCustomer.Add(new CustomerTypDemo(1, "Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(2, "asPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(3, "dssadPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(4, "saddsdPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(5, "dsaPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(6, "jjgvbPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(7, "54fhfablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(8, "gfdgdfPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(9, "df Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(10, "f Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(11, "fdd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(12, "fd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(13, "fdg Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(14, "dfgd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(15, "fdgf Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(16, "df  Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(17, "ddf Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(18, "gggg Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(1, "Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(2, "asPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(3, "dssadPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(4, "saddsdPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(5, "dsaPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(6, "jjgvbPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(7, "54fhfablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(8, "gfdgdfPablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(9, "df Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(10, "f Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(11, "fdd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(12, "fd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(13, "fdg Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(14, "dfgd Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(15, "fdgf Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(16, "df  Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(17, "ddf Pablo Pedrosa"));
            lstCustomer.Add(new CustomerTypDemo(18, "gggg Pablo Pedrosa"));

            CustomerTypDemo[] V_CUSTOMER_TYP_DEMO = new CustomerTypDemo[3];
            V_CUSTOMER_TYP_DEMO[0] = new CustomerTypDemo();
            V_CUSTOMER_TYP_DEMO[0].CustomerId = 41;
            V_CUSTOMER_TYP_DEMO[0].CustFirstName = "Pablo Pedrosa";
            V_CUSTOMER_TYP_DEMO[2] = new CustomerTypDemo();
            V_CUSTOMER_TYP_DEMO[2].CustomerId = 42;
            V_CUSTOMER_TYP_DEMO[2].CustFirstName = "Nati Seoane";
            V_CUSTOMER_TYP_DEMO[1] = new CustomerTypDemo();
            V_CUSTOMER_TYP_DEMO[1].CustomerId = 2;
            V_CUSTOMER_TYP_DEMO[1].CustFirstName = "Martin Pedrosa";

            CustomerTypList arrList = new CustomerTypList(lstCustomer.ToArray());

            using (Devart.Data.Oracle.OracleConnection con = new Devart.Data.Oracle.OracleConnection(oraStrConnection))
            {
                con.Open();

                string response = null;
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = con;
                objCmd.CommandText = "SYS.GET_LIST";
                objCmd.CommandType = CommandType.StoredProcedure;


                NativeOracleObject obj = new NativeOracleObject("SYS.CUSTOMER_TYP_DEMO", con);

                OracleParameter oracleParameter = new OracleParameter();
                oracleParameter.ParameterName = "CUSTOMER_TYP_LIST";
                oracleParameter.ObjectTypeName = "SYS.CUSTOMER_TYP_LIST";
                oracleParameter.OracleDbType = OracleDbType.Array;
                oracleParameter.Size = 200;
                oracleParameter.Direction = ParameterDirection.Input;
                oracleParameter.Value = arrList; 

                objCmd.Parameters.Add(oracleParameter);
                //objCmd.Parameters.Add("cust_name", OracleDbType.Varchar2, 100).Value = "Pablo";
                objCmd.Parameters.Add("out_cust_id", OracleDbType.Number, ParameterDirection.Output);
                objCmd.Parameters.Add("out_cust_name", OracleDbType.VarChar, ParameterDirection.Output);

                objCmd.ExecuteNonQuery();

            }
        }
    }
}
