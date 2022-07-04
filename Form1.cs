using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cbminutos.Items.Add(i);
                cbsegundos.Items.Add(i);
                if (i < 24) { cbhoras.Items.Add(i); }
            }
            cbminutos.SelectedIndex = 0;
            cbsegundos.SelectedIndex = 0;
            cbhoras.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int horas;
        int min;
        int seg;
        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (btniniciar.Text == "Iniciar")
            {
                timer1.Start();
                btniniciar.ForeColor = Color.Firebrick;
                btnpausar.Enabled = true;
                horas = cbhoras.SelectedIndex;
                min = cbminutos.SelectedIndex;
                seg = cbsegundos.SelectedIndex;
                btniniciar.Text = "Restablecer";
            }
            else
            {
                timer1.Stop();
                seg = 0;
                min = 0;
                horas = 0;
                lbtiempo.Text = "00:00:00";
                btniniciar.ForeColor = Color.ForestGreen;
                btnpausar.Enabled = false;
                btnpausar.ForeColor = Color.RoyalBlue;
                btnpausar.Text = "Pausar";
                btniniciar.Text = "Iniciar";
            }
        }

        private void btnpausar_Click(object sender, EventArgs e)
        {
            if (btnpausar.Text == "Pausar")
            {
                timer1.Stop();
                btnpausar.ForeColor = Color.DarkOrange;
                btnpausar.Text = "Reanudar";
            }
            else { 
                timer1.Start();
                btnpausar.ForeColor = Color.RoyalBlue;
                btnpausar.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string minutos = min.ToString();
            string hor = horas.ToString();
            string segundos = seg.ToString();
            if (horas < 10)
            {
                hor = "0" + horas.ToString();

            }
            if (min < 10)
            {
                minutos = "0" + min.ToString();

            }
            if (seg < 10)
            {
                segundos = "0" + seg.ToString();

            }

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if (min == 0 && horas > 0 && seg == 0)
            {
                seg = 60;
                horas -= 1;
                min = 59;
            }

            if (min == 0 && horas == 0 && seg == 0)
            {
                timer1.Stop();
                MessageBox.Show("Se acabo el tiempo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnpausar.Enabled = false;
                btnpausar.Text = "Pausar";
            }
            lbtiempo.Text = hor + ":" + minutos + ":" + segundos;
            seg -= 1;
        }

    }
}
