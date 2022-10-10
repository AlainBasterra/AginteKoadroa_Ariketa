using AginteKoadroa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                var bezeroaData = db.Bezeroa //Bezeroa ipini behar da, ez izena.
                    .Include("Saltzailea") // Beste taula bat gehitu
                    .GroupBy(b => b.Saltzailea.Izena)
                    .ToDictionary(g => g.Key, g => g.Count()); // Inner join
                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                        chart1.DataSource = bezeroaData;
                        chart1.Series[0].YValueMembers = "Value"; // Y ardatza
                        chart1.Series[0].XValueMember = "Key"; // X ardatza
                        chart1.DataBind();
                    }
                }
            }
        }
    }
}
