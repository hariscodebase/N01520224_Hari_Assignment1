using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01520224_Hari_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //We can define the api requests and responses here..
        

        // GET localhost/api/AddTen/5 --> 15
        /// <summary>
        /// Adds up 10 to the integer input.
        /// </summary>
        /// <param name="id">Accepts an integer</param>
        /// <returns>returns an integer</returns>
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }
}