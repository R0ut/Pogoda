using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogoda
{
    public partial class MainPogoda : Form
    {
        GetHtml getHtml;

        RegEx regEx;

        Connection connection;

        SQL sql;
        public MainPogoda()
        {
            InitializeComponent();

            getHtml = new GetHtml();
            regEx = new RegEx();
            connection = new Connection();
            sql = new SQL(comboBoxState,comboBoxCity);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql.State();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (connection.Internet() == true)
            {
                pictureBoxConnectionStatus.Image = Properties.Resources.good;
                getHtml.side(comboBoxState.Text, comboBoxCity.Text);

                regEx.LoadFile();
                txtInfoDay.Text = regEx.FoundDay;
                txtInfoNight.Text = regEx.FoundNight;
                txtInfoNextDay.Text = regEx.FoundNextDay;
            }
            else
            {
                pictureBoxConnectionStatus.Image = Properties.Resources.bad;
            }

        }

        private void clearBox()
        {
            comboBoxCity.Text = "";
            comboBoxCity.Items.Clear();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            buttonGet.Enabled = false;

            comboBoxCity.Visible = true;
            sql.City();
        }



        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGet.Enabled = true;
        }
    }
}
