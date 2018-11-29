using AutoInsuranceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsuranceCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly string  connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;
                            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                             ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculator
        (string firstName, string lastName, string emailAddress, string age, string carYear, 
         string carModel, string carMake, int tickets, string dui, string coverageType)
        {
            double Quote = 50;
            // Insuree's age.
            if (age == "Younger than 18") { Quote += 100; }
            if (age == "Bwt. 18-25" || age == "Older than 100") { Quote += 25; }

            // Insuree's car year, make and model. 
            if (carYear == "Before 2000" || carYear == "After 2015") { Quote += 25; }
            if (carModel == "Porsche") { Quote += 25; }
            if (carMake == "911 Carrera") { Quote += 25; }

            // Insuree's speedingTickets, DUI's & prefered coverage.
            Quote += 10 * tickets;
            if (dui == "Yes") { Quote += Quote * 0.25; }
            if (coverageType == "Full") { Quote += Quote * 0.50; }


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {return View("~/Views/Shared/Error.cshtml");}
            else
            {
                string queryString = @"INSERT INTO Insurees (FirstName, LastName, EmailAddress, Age, CarYear, CarModel, CarMake, Tickets, DUI, CoverageType, Quote)
                                    VALUES(@FirstName, @LastName, @EmailAddress, @Age, @CarYear, @CarModel, @CarMake, @Tickets, @DUI, @CoverageType, @Quote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.NVarChar);
                    command.Parameters.Add("@Age", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.NVarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.NVarChar);
                    command.Parameters.Add("@Tickets", SqlDbType.Int);
                    command.Parameters.Add("@DUI", SqlDbType.NVarChar);
                    command.Parameters.Add("@CoverageType", SqlDbType.NVarChar);
                    command.Parameters.Add("@Quote", SqlDbType.Money);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@Age"].Value = age;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@Tickets"].Value = tickets;
                    command.Parameters["@DUI"].Value = dui;
                    command.Parameters["@CoverageType"].Value = coverageType;
                    command.Parameters["@Quote"].Value = Quote;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                ViewBag.TryGetValue = Quote;
                return View("Success");
            }
            
        }
        
        public ActionResult Coverage()
        {
            ViewBag.Message = "Coverage Calculator";
            return View();
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT FirstName, LastName, EmailAddress, Quote FROM Insurees";
            List<AcademyInsurees> insurees = new List<AcademyInsurees>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var insuree = new AcademyInsurees();
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insuree.Quote = Convert.ToDouble(reader["Quote"]);
                    insurees.Add(insuree);
                }

            }
                return View(insurees);
        }
       
    }
}