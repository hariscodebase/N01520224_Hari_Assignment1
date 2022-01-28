using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01520224_Hari_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST localhost/api/Greeting --> "Hello World!"
        /// <summary>
        /// Posts nothing. Returns "Hello World!"
        /// </summary>
        /// <returns>Returns a string</returns>
        public string Post()
        {
            return "Hello World!";
        }

        //GET localhost/api/Greeting/5 --> "Greetings to 5 people!"
        /// <summary>
        /// Returns the message "Geetings to {id} people" where id can be any integer
        /// </summary>
        /// <param name="id">Accepts an integer</param>
        /// <returns>Returns a string</returns>
        public string Get(int id)
        {
            string greeting = $"Greetings to {id} people!";
            return greeting;
        }
    }
}
