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
    public partial class Form1 : Form
    {
        GetHtml getHtml;

        RegEx regEx;

        Connection connection;

        public Form1()
        {
            InitializeComponent();

            getHtml = new GetHtml();
            regEx = new RegEx();
            connection = new Connection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxState.Items.AddRange(new object[] {"zachodniopomorskie",
                        "pomorskie",
                        "lubelskie",
                        "wielkopolskie",
                        "mazowieckie"});
            comboBoxState.Text = "Please, select any value";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (connection.Internet() == true)
            {
                pictureBoxConnectionStatus.Image = Properties.Resources.good;
                getHtml.side(comboBoxState.Text, comboBoxCity.Text);
                regEx.LoadFile();
                textBoxInformation.Text = regEx.Found;

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

            if (comboBoxState.SelectedIndex < 0)
            {
                comboBoxState.Text = "Please, select any value";
            }
            else
            {
                comboBoxState.Text = comboBoxState.SelectedText;
                comboBoxCity.Visible = true;
                if (comboBoxState.SelectedItem.ToString() == "zachodniopomorskie")
                {
                    clearBox();

                    comboBoxCity.Items.AddRange(new object[] {"koszalin",
                        "kolobrzeg",
                        "szczecin",
                        "szczecinek"});

                }
                else if (comboBoxState.SelectedItem.ToString() == "mazowieckie")
                {
                    clearBox();

                    comboBoxCity.Items.AddRange(new object[] {"warszawa",
                        "radom",
                        "grojec",
                        "lipsko"});
                }

            }

        }



        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGet.Enabled = true;
        }
    }
}
