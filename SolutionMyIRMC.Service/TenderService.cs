using Data.Infrastructure;
using SolutionMyIRMC.Domain;
using SolutionMyIRMC.ServicePattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolutionMyIRMC.Service
{
    public class TenderService : Service<Tender>, ITenderService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
        private static UnitOfWork utw = new UnitOfWork(Dbf);
        public TenderService() : base(utw)
        {
        }


        public void addTender(string titleTender, string description, string contact, string sourceInformation)
        {
            DateTime dateParsed = DateTime.Now;
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/IRMCPI-web/rest/tenders");
            request.Method = "Post";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{""titleTender"": """ + titleTender + @""",""description"": """ + description + @""", ""contact"": """ + contact + @""" , ""sourceInformation"": """ + sourceInformation + @"""  }}");
                sw.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader r = new StreamReader(responseStream))
                            {

                            }
                        }
                    }

                }
            }
        }


        public void deleteTender(int idTender)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/IRMCPI-web/rest/tenders/delete/" + idTender);
            request.Method = "DELETE";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();



        }


        public void editTenders(Tender t)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/IRMCPI-web/rest/tenders/edit/" + t.idTender);
            request.Method = "Put";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{
                        ""titleTender"": """ + t.titleTender + @""",
                        ""description"": """ + t.description + @""",
                        ""contact"": """ + t.contact + @""",
                        ""sourceInformation"": """ + t.sourceInformation + @"""
                        }");
                sw.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader r = new StreamReader(responseStream))
                            {

                            }
                        }
                    }

                }
            }
        }


        /**************** Consomation du web service pour afficher les tenders ********************/

        public IEnumerable<Tender> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/IRMCPI-web/rest/tenders");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();

                }
            }

            var objs = JsonConvert.DeserializeObject<List<Tender>>(content);
            List<Tender> liste = new List<Tender>();
            foreach (Tender r in objs)
            {

                Tender rec = new Tender(r.idTender, r.titleTender, r.description, r.contact, r.sourceInformation);

                liste.Add(rec);
            }
            return liste;
        }

    }
}
