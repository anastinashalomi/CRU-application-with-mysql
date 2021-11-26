using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using New.Models;

namespace New.Controllers
{
    public class HomeController : Controller
    {


        // method for index page and retrive data from database and feach in to design
        public IActionResult Index()
        {

            List<Customer> customers = new List<Customer>();
        

            // connect to mysql
            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=customer;port=3307;password=root1234"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //feach data
                    Customer customer = new Customer();
                    customer.customerID = Convert.ToInt32(reader["customerID"]);
                    customer.name = reader["name"].ToString();
                    customer.code = reader["code"].ToString();
                    customer.address = reader["address"].ToString();

                    customers.Add(customer);

                }
                reader.Close();

            }
            return View(customers);
        }


        
        // delete method specific field
        public IActionResult Delete(int id)
        {
            using(MySqlConnection con=new MySqlConnection("server=localhost;user=root;database=customer;port=3307;password=root1234"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE customerID=" + id, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();

            }
            return RedirectToAction("Index");
        }


        //method for add customer view
        public IActionResult AddCustomer()
        {
            return View();
        }


        //method for add customer function
        [HttpPost]
        public IActionResult AddCustomer(string name,string code , string address)
        {

            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=customer;port=3307;password=root1234"))
            {
                con.Open();
                
                //MySqlCommand cmd = new MySqlCommand("insert into customer (name,code,address) values ("+name+","+code+","+address+")",con);
                var command = "insert into customer(name, code, address) values('"+name+"','"+code+"','"+address+"')";
                MySqlCommand cmd = new MySqlCommand(command,con);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            return View();
        }


        //method for edit view vith specific field data feach
        public IActionResult Edit(int id)
        {
            Customer customer = new Customer();

            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=customer;port=3307;password=root1234"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer where customerID="+id, con);
                MySqlDataReader reader = cmd.ExecuteReader();


                //feach data
                while (reader.Read())
                {
                    
                    customer.customerID = Convert.ToInt32(reader["customerID"]);
                    customer.name = reader["name"].ToString();
                    customer.code = reader["code"].ToString();
                    customer.address = reader["address"].ToString();

                    
                }
                
                reader.Close();

            }
           
            return View(customer);
        }



        //method for edited data save to db
        [HttpPost]
        public IActionResult Edit(int customerID, string name, string code, string address)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=customer;port=3307;password=root1234"))
            {
                con.Open();


                MySqlCommand cmd = new MySqlCommand( "UPDATE customer SET name='" + name + "',code='" + code + "',address='" + address + "' WHERE customerID="+customerID,con);

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            return RedirectToAction("Index");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
