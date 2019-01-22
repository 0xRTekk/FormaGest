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

        public List<Formation> GetFormations()
        {
            List<Formation> formations = new List<Formation>();
            dbConn.Open();
            formations = dbConn.Query<Formation>("SELECT * FROM formation").ToList();
            dbConn.Close();

            return formations;
        }

        public List<Session> GetSessions(int formationId)
        {
            List<Session> sessions = new List<Session>();
            dbConn.Open();
            sessions = dbConn.Query<Session>("SELECT * FROM session WHERE id_formation = "+formationId).ToList();
            dbConn.Close();

            return sessions;
        }
    }
}
