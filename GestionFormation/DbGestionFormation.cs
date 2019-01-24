using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace GestionFormation
{
    class DbGestionFormation
    {
        //
        //Properties
        //
        private MySqlConnection dbConn;



        //
        //Methods & functions
        //
        public void InitDb()
        {
            String connString = "Server='127.0.0.1'; User='root'; Password=''; Database='gestion_formation'; SslMode=none";
            
            dbConn = new MySqlConnection(connString);
        }

        public List<ComboValue> GetFormations()
        {
            var comboListeFormations = new List<ComboValue>();
            dbConn.Open();
            var formations = dbConn.Query<Formation>("SELECT * FROM Formation").ToList();
            foreach (Formation uneFormation in formations)
            {
                comboListeFormations.Add(new ComboValue() { Name = uneFormation.Name, Value = uneFormation.Id.ToString() });
            }
            dbConn.Close();

            return comboListeFormations;
        }

        public List<Session> GetSessions(String formationId)
        {
            List<Session> sessions = new List<Session>();
            dbConn.Open();
            sessions = dbConn.Query<Session>("SELECT * FROM session WHERE id_formation = "+formationId).ToList();
            dbConn.Close();

            return sessions;
        }
    }
}
