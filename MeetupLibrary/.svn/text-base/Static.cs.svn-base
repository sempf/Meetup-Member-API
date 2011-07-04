using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace MeetupLibrary
{
    class Static
    {
        public const string ApiKey = "4b3a6228756638793c624c6a7757241c";
        public static string GetPageAsString(Uri address)
        {
            string result = "";

            // Create the web request  
            var request = WebRequest.Create(address) as HttpWebRequest;

            // Get response  
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                var reader = new StreamReader(response.GetResponseStream());

                // Read the whole contents and return as a string  
                result = reader.ReadToEnd();
            }

            return result;
        }  

    }
}
