using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Lakopark_inform
{
    internal class Adatbazis
    {
        MySqlConnection connetion = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb=new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "lakopark";
            sb.CharacterSet = "utf8";
            connetion = new MySqlConnection(sb.ConnectionString);

            try
            {
                kapcsolatNyit();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            { 
                kapcsolatZár();
            }
        }

        private void kapcsolatZár()
        {
         if (connetion.State !=System.Data.ConnectionState.Closed)
            {
                connetion.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (connetion.State != System.Data.ConnectionState.Open) connetion.Open(); { }

        }

        internal List<Lakopark> parkadatokBetoltese()
        {
            List<Lakopark> lp = new List<Lakopark>();
            return lp;
        }
    }
}
