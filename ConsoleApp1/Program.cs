using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    using Oracle.DataAccess.Client;
    using System;
    using System.Data;


    /// <summary>
    /// The program.
    /// </summary>
    public static class Program
    {
        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            string oraStrConnection = "User Id=Ppedrosa; password=testpwd; Data Source=51.103.24.166:1521/CDB1; Pooling=false;";

            using (OracleConnection con = new OracleConnection(oraStrConnection))
            {
                con.Open();
                Console.WriteLine("Connected to Oracle" + con.ServerVersion);

                CustomerTypDemo V_CUSTOMER_TYP_DEMO = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };

                // create command to run your package
                var cmd = new OracleCommand("SYS.GET_CUSTOMER", con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter oracleParameter = new OracleParameter();
                oracleParameter.UdtTypeName = "SYS.CUSTOMER_TYP_DEMO";
                oracleParameter.OracleDbType = OracleDbType.Object;
                oracleParameter.Direction = ParameterDirection.Input;
                oracleParameter.Value = V_CUSTOMER_TYP_DEMO;

                cmd.Parameters.Add(oracleParameter);
                //objCmd.Parameters.Add("cust_name", OracleDbType.VarChar, 100).Value = "Pablo";
                cmd.Parameters.Add("out_cust_id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.Parameters.Add("out_cust_name", OracleDbType.Varchar2, 120, DBNull.Value, ParameterDirection.Output);

                cmd.ExecuteNonQuery();

                // I am lazy to query the database table here, but you should get you data now.
                // watch what happened to element "Third Element_"

                CustomerTypDemo[] V_CUSTOMER_TYP_LIST = new CustomerTypDemo[35];
                V_CUSTOMER_TYP_LIST[0] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[1] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[3] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[4] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[5] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[6] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[7] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[8] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[9] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[10] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[11] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[12] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[13] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[14] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[15] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[16] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[17] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[18] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[19] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[20] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[21] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[22] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[23] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[24] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[25] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[26] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[27] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[28] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[29] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[30] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[31] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[32] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };
                V_CUSTOMER_TYP_LIST[33] = new CustomerTypDemo() { customerId = 42, custFirstName = "Pablo Pedrosa" };
                V_CUSTOMER_TYP_LIST[34] = new CustomerTypDemo() { customerId = 43, custFirstName = "Natalia Seoane" };

                CustomerTypList customerTypList = new CustomerTypList();
                customerTypList.objArticles = V_CUSTOMER_TYP_LIST;

                // create command to run your package
                cmd = new OracleCommand("SYS.GET_CUSTOMER_LIST", con);
                cmd.CommandType = CommandType.StoredProcedure;

                oracleParameter = new OracleParameter();
                oracleParameter.UdtTypeName = "SYS.CUSTOMER_TYP_LIST";
                oracleParameter.OracleDbType = OracleDbType.Array;
                oracleParameter.Direction = ParameterDirection.Input;
                oracleParameter.Value = customerTypList;
                cmd.Parameters.Add(oracleParameter);
                //objCmd.Parameters.Add("cust_name", OracleDbType.VarChar, 100).Value = "Pablo";

                OracleParameter oracleParameter2 = new OracleParameter();
                oracleParameter2.ParameterName = "PO_CUSTOMER_TYP_LIST";
                oracleParameter2.UdtTypeName = "SYS.CUSTOMER_TYP_LIST";
                oracleParameter2.OracleDbType = OracleDbType.Array;
                oracleParameter2.Direction = ParameterDirection.Output;
                oracleParameter2.Size = 50;
                cmd.Parameters.Add(oracleParameter2);

                //cmd.Parameters.Add("PO_CUSTOMER_TYP_LIST", OracleDbType.Array, ParameterDirection.Output);
                //cmd.Parameters.Add("out_cust_name", OracleDbType.VarChar, 120, DBNull.Value, ParameterDirection.Output);

                cmd.ExecuteNonQuery();



                // Close and Dispose OracleConnection object
                con.Close();
                con.Dispose();
                Console.WriteLine("Disconnected");
            }
        }

        #endregion
    }
}
