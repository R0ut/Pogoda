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
        private string text, found;

        private string patern;

        public string Found { get; private set; }
        public void LoadFile()
        {
            try
            {

                text = File.ReadAllText(@"C:\Users\Janek\Documents\Visual Studio 2015\Projects\Pogoda\Pogoda\Resources\html.txt");
                
                for (int i = 1; i <= 6; i++)
                {
                    if (i == 1) patern = Properties.Resources.patern1;
                    else if (i == 2) patern = Properties.Resources.patern2;
                    else if (i == 3) patern = Properties.Resources.patern3;
                    else if (i == 4) patern = Properties.Resources.patern4;
                    else if (i == 5) patern = Properties.Resources.patern5;
                    else if (i == 6) patern = Properties.Resources.patern6;
                    Match m = Regex.Match(text, patern);
                    if (i == 1) { found += "Temperatura " + m.Value + "°C"; }
                    else if (i == 2) { found += "\nWiatr " + m.Value.Replace("\t", "").Replace("\n", "") + "km/h"; }
                    else if (i == 3) { found += "\nChmury " + m.Value + "%"; }
                    else if (i == 4) { found += "\nOpady " + m.Value + "mm"; }
                    else if (i == 5) { found += "\nCisnienie " + m.Value + "hPa"; }
                    else if (i == 6) { found += "\nWilgotnosc " + m.Value + "%"; }

                }
                Found = found; 
                found = "";
            }
            catch (Exception aa)
            {
                MessageBox.Show(aa.ToString());
            }
        }
    }
}
