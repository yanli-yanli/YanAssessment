using System;
using System.IO;
using System.Net;
using System.Text;

namespace WordOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            TestForGet200_OK("Insurance");
            TestForGet404_NotFound("Insurance");
            TestForGet400_BadRequest("Insurance");
        }

        public static void TestForGet200_OK(string word)
        {
            HttpWebRequest req = null;
            //Set up API url
            string PrimeUrl = "https://od-api.oxforddictionaries.com:443/api/v2/lemmas/en/";
            //add word Insurance for testing
            string uri = PrimeUrl + word;
            req = (HttpWebRequest)HttpWebRequest.Create(uri);

            //These are not network credentials, just custom headers
            req.Headers.Add("app_id", "c58b879c");
            req.Headers.Add("app_key", "76d55a4d4622841e55f737af7b3ddb0d");

            req.Method = WebRequestMethods.Http.Get;
            req.Accept = "application/json";

            using (HttpWebResponse HWR_Response = (HttpWebResponse)req.GetResponse())
            using (Stream respStream = HWR_Response.GetResponseStream())
            using (StreamReader sr = new StreamReader(respStream, Encoding.UTF8))
            {
                string theJson = sr.ReadToEnd();

                Console.WriteLine(theJson);

                //output the outcome for presentation
                Console.WriteLine("TestFor200_OK - Status Code: " + (int)HWR_Response.StatusCode);
            }
            Console.ReadKey();
        }
        public static void TestForGet404_NotFound(string word)
        {
            HttpWebRequest req = null;
            //Set up API url - which is a invalid url from oxford to get 404 Error
            //use lemma instead of use lemmas
            //This will cause HttpWebResponse throw an 404 not found pre-defined exception
            string PrimeUrl = "https://od-api.oxforddictionaries.com:443/api/v2/lemma/en/";
            //add word Insurance for testing
            string uri = PrimeUrl + word;
            req = (HttpWebRequest)HttpWebRequest.Create(uri);

            //These are not network credentials, just custom headers
            req.Headers.Add("app_id", "c58b879c");
            req.Headers.Add("app_key", "76d55a4d4622841e55f737af7b3ddb0d");

            req.Method = WebRequestMethods.Http.Get;
            req.Accept = "application/json";
            try
            {
                using (HttpWebResponse HWR_Response = (HttpWebResponse)req.GetResponse())
                using (Stream respStream = HWR_Response.GetResponseStream())
                using (StreamReader sr = new StreamReader(respStream, Encoding.UTF8))
                {
                    string theJson = sr.ReadToEnd();
                    Console.WriteLine(theJson);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("TestFor404_NotFound - " + ex.Message);
            }
            Console.ReadKey();
        }
        public static void TestForGet400_BadRequest(string word)
        {
            HttpWebRequest req = null;
            //Set up API url
            string PrimeUrl = "https://od-api.oxforddictionaries.com:443/api/v2/lemmas/en/";
            //add word Insurance for testing
            //This will trigger 400 error
            string uri = PrimeUrl + word+ "?lexicalCategory=nou,verb";
            req = (HttpWebRequest)HttpWebRequest.Create(uri);

            //These are not network credentials, just custom headers
            req.Headers.Add("app_id", "c58b879c");
            req.Headers.Add("app_key", "76d55a4d4622841e55f737af7b3ddb0d");

            req.Method = WebRequestMethods.Http.Get;
            req.Accept = "application/json";
            try
            {
                using (HttpWebResponse HWR_Response = (HttpWebResponse)req.GetResponse())
                using (Stream respStream = HWR_Response.GetResponseStream())
                using (StreamReader sr = new StreamReader(respStream, Encoding.UTF8))
                {
                    string theJson = sr.ReadToEnd();
                    Console.WriteLine(theJson);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("TestFor400_BadRequest - " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
