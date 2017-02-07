using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
namespace Pogoda
{
    class GetHtml
    {
        public string html;
        public void side(string woj, string miasto)
        {
            //pobieranie kodu html ze strony
            try
            {
                string url = "http://www.twojapogoda.pl/polska/" + Replice(woj) + "/" + Replice(miasto);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Proxy = null;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                html = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
            }
            //Zapis do pliku w katalogu Pogoda

            try
            {
                
                System.IO.File.WriteAllText(@"C:\Users\Janek\Documents\Visual Studio 2015\Projects\Pogoda\Pogoda\Resources\html.txt", html);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private string Replice(string str)
        {
            string input = str.Trim().ToLower();
            string tmp = input.Replace("ą", "a");
            tmp = tmp.Replace("ć", "c");
            tmp = tmp.Replace("ę", "e");
            tmp = tmp.Replace("ł", "l");
            tmp = tmp.Replace("ń", "n");
            tmp = tmp.Replace("ó", "o");
            tmp = tmp.Replace("ś", "s");
            tmp = tmp.Replace("ź", "z");
            tmp = tmp.Replace("ż", "z");
            string output = tmp.Replace(" ", "-");
            return output;
        }

    }
}
