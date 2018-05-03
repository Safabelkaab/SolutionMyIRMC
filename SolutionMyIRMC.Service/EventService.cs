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
    public class EventService : Service<Event>, IEventService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
        private static UnitOfWork utw = new UnitOfWork(Dbf);
        public EventService() : base(utw)
        {
        }

        public void addEvent(
             string titreEvent, string descriptionEvent, string telEvent)
        {
            DateTime dateParsed = DateTime.Now;
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/IRMCPI-web/rest/Events");
            request.Method = "Post";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{""titreEvent"": """ + titreEvent + @""",""descriptionEvent"": """ + descriptionEvent + @""",
  ""telEvent"": """ + telEvent + @"""  }}");
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





        /**************** Consomation du web service pour afficher les dossier ********************/

        public IEnumerable<Event> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/IRMCPI-web/rest/Events");
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

            var objs = JsonConvert.DeserializeObject<List<Event>>(content);
            List<Event> liste = new List<Event>();
            foreach (Event r in objs)
            {

                Event rec = new Event(r.idEvent, r.titreEvent, r.descriptionEvent, r.lieuxEvent, r.image);

                liste.Add(rec);
            }
            return liste;
        }




        public void delete(int idEvent)
        {
            System.Diagnostics.Debug.WriteLine("SomeText");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/IRMCPI-web/rest/Events/delete/{idEvent}");
            request.Method = "DELETE";
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


        }

    }
}
