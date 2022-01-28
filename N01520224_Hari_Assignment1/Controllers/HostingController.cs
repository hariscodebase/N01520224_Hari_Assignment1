using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01520224_Hari_Assignment1.Controllers
{
    public class HostingController : ApiController
    {
        //GET localhost/api/Hosting/14 returns the below output
        //"2 fortnights at $5.50/FN = $11.00 CAD" "HST 13% = $1.43 CAD" "Total = $12.43 CAD"

        /// <summary>
        /// This function will calculate the Total hosting charges including the elapsed days which is the input
        /// and outputs the result including other essential details in the form of list of strings.
        /// </summary>
        /// <param name="id">Accepts an Integer</param>
        /// <returns>Returns an array of strings</returns>
        public IEnumerable<string> Get(int id)
        {
            int daysInFN = 14;
            decimal costPerFN = 5.50m;
            decimal hstPercentage = 13;
            int elaspsedFN = id / daysInFN;
            int noOfFN = 1 + elaspsedFN;
            decimal hostingCharges = Math.Round(costPerFN * noOfFN, 2);
            decimal hstCharges = Math.Round(hstPercentage / 100 * hostingCharges, 2);
            decimal total = Math.Round(hostingCharges + hstCharges, 2);

            return new string[] { 
                $"{noOfFN} fortnights at ${costPerFN}/FN = ${hostingCharges} CAD",
                $"HST {hstPercentage}% = ${hstCharges} CAD",
                $"Total = ${total} CAD"
            };
        }
    }
}
