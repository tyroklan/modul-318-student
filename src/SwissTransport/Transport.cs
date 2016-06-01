using System.IO;
using System.Net;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {                                                                                             
                    var message = new StreamReader(responseStream).ReadToEnd();                               
                    var stations = JsonConvert.DeserializeObject<Stations>(message);                          
                    return stations;                                                                          
                }                                                                                             
            }                                                                                                 
            catch                                                                                             
            {
                MessageBox.Show("Ups, es ist ein Fehler mit der Verbindung aufgetreten. Versuchen Sie es erneut.");                                                                                         
            }                                                                                                 
                                                                                                 
                                                                                                 
            return null;                                                                         
        }                                                                                        
                                                                                                 
        public StationBoardRoot GetStationBoard(string station, string id)                       
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion, DateTime time, DateTime date)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date.ToString("yyyy-MM-dd") + "&time=" + time.ToString("HH:mm"));
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
