using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string conn = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";

            //var sql = "UPDATE Login SET Name = 'Razaul Karim' WHERE id = 1;";

            //ExecuteQuery(conn, sql);
            var selectQuery = "Select * FROM Login;";
            var result = GetDataUsingAdapter(conn, selectQuery);
           // Console.WriteLine("r :"+result);
            // var result = GetData(conn, selectQuery);
            // //Console.WriteLine("result :" +result[i]);
            // string s ;
            // foreach (var kvp in result)
            // {
            //     foreach (var item in kvp.Values)
            //     {
            //         // s += item.ToString;
            //        Console.WriteLine("result :" + item);

            //     }
            //     // s += kvp.Keys + ' ' +kvp.Values;
            // }
            //// Console.WriteLine(s);

        }
        private static void ExecuteQuery(string conn, string sql)
        {
            

            using (var connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                   
                    using (var command = new SqlCommand(sql, connection))
                    {

                        int a = command.ExecuteNonQuery();
                        if (a == 1)
                        {
                            Console.WriteLine("Data Executed");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Data Not Executed");
                }
                finally
                {
                    connection?.Close();
                }
            }
        }
        private static DataSet GetDataUsingAdapter(string conn, string sql)
        {
            var dataset = new DataSet("test");

            using (var connection = new SqlConnection(conn))
            {

                try
                {
                    connection.Open();


                    using (var command = new SqlCommand(sql, connection))
                    {

                        var adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataset,"Login");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Data Not Executed");
                }
                finally
                {
                    connection?.Close();
                }
            }
            return dataset;


        }
        //private static List<Dictionary<string, object>> GetData(string conn, string sql)
        //{
        //    var allRow = new List<Dictionary<string, object>>();

        //    using (var connection = new SqlConnection(conn))
        //    {

        //        try
        //        {
        //            connection.Open();


        //            using (var command = new SqlCommand(sql, connection))
        //            {

        //                using (var reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        var row = new Dictionary<string, object>();

        //                        for (int i = 0; i < reader.FieldCount; i++)
        //                        {
        //                            var fieldName = reader.GetName(i);
        //                            var fieldValue = reader[i];
        //                            row[fieldName] = fieldValue;
        //                        }
        //                        allRow.Add(row);
        //                    }
        //                   // return allRow;
        //                }
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine("Data Not Executed");
        //        }
        //        finally
        //        {
        //            connection?.Close();
        //        }
        //    }
        //        return allRow;


        //    }
        //private static void Delete()
        //{
        //    const string conn = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";

        //    using (var connection = new SqlConnection(conn))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            var sql = "DELETE FROM Login WHERE id = 6;";
        //            using (var command = new SqlCommand(sql, connection))
        //            {

        //                int a = command.ExecuteNonQuery();
        //                if (a == 1)
        //                {
        //                    Console.WriteLine("Data Deleted");
        //                }



        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine("Data Not Deleted");
        //        }
        //        finally
        //        {
        //            connection?.Close();
        //        }
        //    }
        //}
        //private static void Update()
        //{
        //    const string conn = "Server = DESKTOP-28DHLU6; Database = test; User Id = arafat; Password = 123; ";

        //    using (var connection = new SqlConnection(conn))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            var sql = "UPDATE Login SET Name = 'Rezaul Karim' , Email = 'a@gmail.com',Contact = '123', Address = 'Gulsan', Username = 'reza',Password = '123',Type='user' WHERE id = 6;";
        //            using (var command = new SqlCommand(sql, connection))
        //            {

        //                int a = command.ExecuteNonQuery();
        //                if (a == 1)
        //                {
        //                    Console.WriteLine("Data Updated");
        //                }



        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            Console.WriteLine("Data Not Updated");
        //        }
        //        finally
        //        {
        //            connection?.Close();
        //        }
        //    }
        //}
    }
}
