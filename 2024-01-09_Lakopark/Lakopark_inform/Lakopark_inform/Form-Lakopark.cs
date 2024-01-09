using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lakopark_inform
{
    public partial class Form1 : Form
    {

        List<Lakopark> Lakoparkok= new List<Lakopark>();
        Adatbazis db = new Adatbazis();
        int aktualisParkIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lakoparkok = db.parkadatokBetoltese();
            parkadatokMegjelenitese();
        }

        private void parkadatokMegjelenitese()
        {
            this.Text = $"{Lakoparkok[aktualisParkIndex].LakoparkNeve}  lakópark adatai";
            pictureBoxNevado.Image = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{Lakoparkok[aktualisParkIndex].LakoparkNeve}.jpg");
        }
    }
}
