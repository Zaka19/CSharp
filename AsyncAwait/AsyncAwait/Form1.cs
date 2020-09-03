using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {

        List<string> _generic;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            tbTime.Text = "Son les " + DateTime.Now.ToString("HH:mm:ss");
        }


        private async void btnListBox1_Click(object sender, EventArgs e)
        {
            //List<string> LB_Secuencial = new List<string>();
            await ListaSecuencial();
        }

        private async void btnListBox2_Click(object sender, EventArgs e)
        {
            await ListaParalel();
        }

        public async Task ListaSecuencial()
        {
            _generic = new List<string>();
            Stopwatch clock = new Stopwatch();
            clock.Restart();

            foreach (string d in Directory.GetDirectories(@"C:\Users\USER\Documents\prova"))
            {
                foreach (string s in Directory.GetFiles(d))
                {
                    _generic.Add(s);
                    System.Threading.Thread.Sleep(1);
                }
            }

            LB1.DataSource = _generic;

            clock.Stop();
            tbTimeLB1.Text = clock.Elapsed.TotalSeconds.ToString() + " segons";
        }

        public async Task ListaParalel()
        {
            _generic = new List<string>();
            Stopwatch clock = new Stopwatch();
            clock.Restart();

            Parallel.ForEach(Directory.GetDirectories(@"C:\Users\USER\Documents\prova"), i =>
            {
                foreach (string s in Directory.GetFiles(i))
                {
                    _generic.Add(s);
                    System.Threading.Thread.Sleep(1);
                }
            });

            LB2.DataSource = _generic;

            clock.Stop();
            tbTimeLB2.Text = clock.Elapsed.TotalSeconds.ToString() + " segons";
        }
    }
}
