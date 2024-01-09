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
            sql.CommandText = "Select * from lakopark NATURAL JOIN epuletek";
            try
            {
                kapcsolatNyit();
                using(MySqlDataReader dr= sql.ExecuteReader())
                {
                    int aktualisId = -1;
                    int lakoparkIndex = -1;


                    while (dr.Read())
                    {
                        if(aktualisId != dr.GetInt32("lakoparkId"))
                        {
                            lp.Add(new Lakopark(dr.GetInt32("lakoparkId"), dr.GetString("lakoparkNev"), dr.GetInt32("utcakSzama"), dr.GetInt32("telkekSzama")));
                            aktualisId = dr.GetInt32("lakoparkId");
                            lakoparkIndex++;
                        }
                        lp[lakoparkIndex].HazAdat(dr.GetInt32("utcaSzam"), dr.GetInt32("hazSzam"), dr.GetInt32("emelet"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            finally
            {
                kapcsolatZár();
            }
            return lp;
        }
    }
}
