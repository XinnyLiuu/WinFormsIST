using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTUtil
{
    public class REST
    {
        private string baseUri; // Base URI 
        
        // Constructor
        public REST(string baseUri)
        {
            this.baseUri = baseUri; 
        }

        // Gets data from uri in json
        public string getJSON(string uri)
        {   
            try
            {
                // Connect to api
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + uri);

                // Get response
                WebResponse response = request.GetResponse();

                // Read response
                using (Stream responseStream = response.GetResponseStream()) // using() disposes of anything between the parenthesis as soon as it goes out of scope
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8); // Ensures the reader is taking in UTF8 characters only
                    return reader.ReadToEnd();
                }
            }
            catch(WebException we)
            {
                Console.WriteLine("An error has occurred! Please double check your internet connection and the URL for the api.");
                Console.WriteLine(we.ToString());
                Environment.Exit(1);
            }

            return null;
        }
        
        // Gets data from uri in xml
        public string getXML(string uri)
        {
            return "";
        }
    }
}
