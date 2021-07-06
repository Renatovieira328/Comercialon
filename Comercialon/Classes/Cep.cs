using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace Comercialon.Classes
{
    public static class Cep
    {
        public static Xmlcep CepRetornado { get; set; }
        public static Xmlcep Obter(string cep)
        {
            string[] dados = new string[7];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/xml/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                dados[5] = "Servidor indisponível";

            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        XmlSerializer serializer = new XmlSerializer(typeof(Xmlcep));
                        using (StringReader reader = new StringReader(response))
                        {
                            CepRetornado = (Xmlcep)serializer.Deserialize(reader);
                        }

                    }
                }
            }
            return CepRetornado;
        }
    }
}