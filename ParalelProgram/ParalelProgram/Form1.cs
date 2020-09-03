using Newtonsoft.Json;
using ParalelProgram.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParalelProgram
{
    public partial class Form1 : Form
    {
        List<Usuario> _users = new List<Usuario>();
        Stopwatch timer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            _users = ReadJSON();

            Modular();
            timer.Reset();
            Paralel();

        }

        public List<Usuario> ReadJSON()
        {
            string json = File.ReadAllText("people.json");
            return JsonConvert.DeserializeObject<List<Usuario>>(json);
        }

        private void Modular()
        {
            ListViewItem _list;
            string [] _valores;

            timer.Start();

            foreach (Usuario _user in _users)
            {
                _valores = modular(_user);
                _list = new ListViewItem(_valores[0]);
                _list.SubItems.Add(_valores[1]);
                _list.SubItems.Add(_valores[2]);
                listJson.Items.Add(_list);
            }

            timer.Stop();
            tvTemps.AppendText(timer.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
        }

        private void Paralel()
        {

            ListViewItem _list;
            string[] _valores;

            timer.Start();

            foreach (Usuario _user in _users)
            {
                _valores = parallel(_user);
                _list = new ListViewItem(_valores[0]);
                _list.SubItems.Add(_valores[1]);
                _list.SubItems.Add(_valores[2]);
                listJSON2.Items.Add(_list);
            }

            timer.Stop();
            tvTemps.AppendText(" " + timer.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
        }

        public string [] modular(Usuario _user)
        {
            string [] _fila = new string[3];

            if (!_user.ComprobarNom())
                _fila[0] = _user.Name;
            else
                _fila[0] = "NO NAME";

            if (_user.ComprobarEmail())
                _fila[1] = _user.email;
            else
                _fila[1] = "NO EMAIL";

            if (_user.ComprobarDNI())
                _fila[2] = _user.dni;
            else
                _fila[2] = "NO DNI";

            return _fila;
        }

         public string[] parallel(Usuario _user)
         {
            string[] _fila = new string[3];

            Parallel.Invoke(() =>
                 {
                     if (!_user.ComprobarNom())
                         _fila[0] = _user.Name;
                     else
                         _fila[0] = "NO NAME";
                 },  
                 () =>
                 {
                     if (_user.ComprobarEmail())
                         _fila[1] = _user.email;
                     else
                         _fila[1] = "NO EMAIL";
                 }, 
                 () =>
                 {
                     if (_user.ComprobarDNI())
                         _fila[2] = _user.dni;
                     else
                         _fila[2] = "NO DNI";
                 }
             );

            return _fila;
         }

        private void button3_Click(object sender, EventArgs e)
        {
            listJson.Items.Clear();
            tvTemps.ResetText();
            timer.Reset();
        }
    }
}
