using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogoda
{
    class Connection
    {
        public bool Internet()
        {
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();

                var result = ping.Send("www.google.pl");

                if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
                    return false;
                else return true;

            }
            catch (PingException ad)
            {
                MessageBox.Show("Internet connection problem");
                return false;
            }
        }
    }
}
