using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01520224_Hari_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET localhost/api/NumberMachine/10 --> 25
        /// <summary>
        /// Performs a simple math operation (adds 4 to the input, subtracts 1 from the input, 
        /// then muliplies both the result and finally divides the result with 5)
        /// on the integer input and returns the final result.
        /// </summary>
        /// <param name="id">Accepts an integer</param>
        /// <returns>Returns an integer</returns>
        public int Get(int id)
        {
            int result = ((id + 4) * (id - 1)) / 5;
            return result;
        }
    }
}
