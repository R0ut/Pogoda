using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Pogoda
{
    class GetHtml
    {
        public string html;
        public void side()
        {
            //pobieranie kodu html ze strony
            try
            {
                string url = "http://www.twojapogoda.pl/polska/zachodniopomorskie/koszalin";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                html = sr.ReadToEnd();
                sr.Close();
            }catch(Exception ea)
            {
                MessageBox.Show(ea.ToString());
            }
            //Zapis do pliku w katalogu Pogoda

            try
            {
                System.IO.File.WriteAllText(@"C:/Users/Janek/Documents/Visual Studio 2015/Projects/Pogoda/web/html.txt", html);
            }catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
