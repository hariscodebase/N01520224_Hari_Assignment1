using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01520224_Hari_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        // GET localhost/api/Square/4 --> 16
        /// <summary>
        /// Returns the square of the integer input {id}.
        /// </summary>
        /// <param name="id">Accepts an integer</param>
        /// <returns>Returns an integer</returns>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
