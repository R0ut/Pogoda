using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//klasa filtrujaca strone html

namespace Pogoda
{
    class RegEx
    {
        private string text, foundDay,foundNight,foundNextDay;

        private string patern;

        public string FoundDay { get; private set; }
        public string FoundNight { get; private set; }
        public string FoundNextDay { get; private set; }
        
        public void LoadFile()
        {
            try
            {
                
                string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/html.txt"; // path of project
                text = System.IO.File.ReadAllText(projectPath);



                for (int i = 1; i <= 6; i++)
                {
                    if (i == 1) patern = Properties.Resources.patern1;
                    else if (i == 2) patern = Properties.Resources.patern2;
                    else if (i == 3) patern = Properties.Resources.patern3;
                    else if (i == 4) patern = Properties.Resources.patern4;
                    else if (i == 5) patern = Properties.Resources.patern5;
                    else if (i == 6) patern = Properties.Resources.patern6;

                    if (i == 1) match(i);
                    else if (i == 2) match(i);
                    else if (i == 3) match(i);
                    else if (i == 4) match(i);
                    else if (i == 5) match(i);
                    else if (i == 6) match(i);

                }
                FoundDay = foundDay;
                foundDay = "";

                FoundNight = foundNight;
                foundNight = "";

                FoundNextDay = foundNextDay;
                foundNextDay = "";

            }
            catch (Exception aa)
            {
                MessageBox.Show(aa.ToString());
            }
        }


        private void match(int i)
        {
            Match match = Regex.Match(text, patern);
            if (match.Success)
            {
                if(i == 1) foundDay += "Temperatura odczuwalna " + match.Value + "°C";
                else if(i == 2)foundDay += "\r\nWiatr " + match.Value.Replace("\t", "").Replace("\n", "") + "km/h";
                else if (i == 3) foundDay += "\r\nChmury " + match.Value + "%"; 
                else if (i == 4) foundDay += "\r\nOpady " + match.Value + "mm";
                else if (i == 5) foundDay += "\r\nCisnienie " + match.Value + "hPa";
                else if (i == 6) foundDay += "\r\nWilgotnosc " + match.Value + "%";
            }

            // Get second match.
            match = match.NextMatch();
            if (match.Success)
            {
                if (i == 1) foundNight += "Temperatura odczuwalna " + match.Value + "°C";
                else if (i == 2) foundNight += "\r\nWiatr " + match.Value.Replace("\t", "").Replace("\n", "") + "km/h";
                else if (i == 3) foundNight += "\r\nChmury " + match.Value + "%";
                else if (i == 4) foundNight += "\r\nOpady " + match.Value + "mm";
                else if (i == 5) foundNight += "\r\nCisnienie " + match.Value + "hPa";
                else if (i == 6) foundNight += "\r\nWilgotnosc " + match.Value + "%";
                
            }

            // Get third match.
            match = match.NextMatch();
            if (match.Success)
            {
                if (i == 1) foundNextDay += "Temperatura odczuwalna " + match.Value + "°C";
                else if (i == 2) foundNextDay += "\r\nWiatr " + match.Value.Replace("\t", "").Replace("\n", "") + "km/h";
                else if (i == 3) foundNextDay += "\r\nChmury " + match.Value + "%";
                else if (i == 4) foundNextDay += "\r\nOpady " + match.Value + "mm";
                else if (i == 5) foundNextDay += "\r\nCisnienie " + match.Value + "hPa";
                else if (i == 6) foundNextDay += "\r\nWilgotnosc " + match.Value + "%";
                
            }
        }

    }
}
