using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//klasa filtrujaca strone html

namespace Pogoda
{
    class RegEx
    {
        public string text = "asd 20 bsdf 21 345";
        public string patern = @"\d\d";
        public void wypisz(){
        Match m = Regex.Match(text, patern);
            Console.WriteLine(m.Value);
    }
    }
}
