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

        public void UpdatePass(int id, String pass)
        {
            String strQuery = "UPDATE user SET pass = @thePass, tentativeCo = 0, demandeChangePass = 0, heurePremiereCo = null WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", id);
            dynamicParameters.Add("thePass", pass);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public List<User> Connection(String login, String pass)
        {
            List<User> user = new List<User>();
            String strQuery = "SELECT * FROM user WHERE login = @theLogin AND pass = @thePass"; //infos connexion en dur car dyna param fonctionnent pas
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theLogin", login);
            dynamicParameters.Add("thePass", pass);
            dbConn.Open();
            user = dbConn.Query<User>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return user;
        }

        public List<User> GetUsers()
        {
            dbConn.Open();
            var users = dbConn.Query<User>("SELECT * FROM user").ToList();
            dbConn.Close();

            return users;
        }

        public List<Formation> GetFormations()
        {
            dbConn.Open();
            var formations = dbConn.Query<Formation>("SELECT * FROM formation").ToList();
            dbConn.Close();

            return formations;
        }

        public List<Session> GetSessions(String formationId)
        {
            List<Session> sessions = new List<Session>();
            String strQuery = "SELECT * FROM session WHERE id_formation = @idFormation";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("idFormation", formationId);
            dbConn.Open();
            sessions = dbConn.Query<Session>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return sessions;
        }

        public List<Participant> GetParticipants()
        {
            List<Participant> participants = new List<Participant>();
            String strQuery = "SELECT * FROM participant";
            dbConn.Open();
            participants = dbConn.Query<Participant>(strQuery).ToList();
            dbConn.Close();

            return participants;
        }

        public List<Participant> GetInscrits(String idSession)
        {
            List<Participant> inscrits = new List<Participant>();
            String strQuery = "SELECT * FROM participant WHERE id_session = @idSession";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("idSession", idSession);
            dbConn.Open();
            inscrits = dbConn.Query<Participant>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return inscrits;
        }
    }
}
