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

        //
        //DB
        //
        public void InitDb()
        {
            String connString = "Server='127.0.0.1'; User='root'; Password=''; Database='gestion_formation'; SslMode=none";
            
            dbConn = new MySqlConnection(connString);
        }



        //
        //TICKETS
        //
        public List<Incident> GetTickets()
        {
            dbConn.Open();
            try
            {
                var incidents = dbConn.Query<Incident>("SELECT id, libelle FROM incident").ToList();
                return incidents;
            }
            catch (Exception e)
            {
                String exep = e.Message;
                throw;
            }
            dbConn.Close();
        }

        public void CreateTicket(String libelle, String description, DateTime date_emission, String etat, int niveau, int idUser)
        {
            String strQuery = "INSERT INTO incident (libelle, description, date_emission, date_resolution, niveau, etat, id_user) VALUES (@theLibelle, @theDescri, @theDateEmission , @theDateReso, @theNiveau ,@theEtat, @theUser)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theLibelle", libelle);
            dynamicParameters.Add("theDescri", description);
            dynamicParameters.Add("theDateEmission", date_emission);
            dynamicParameters.Add("theDateReso", "0000-00-00 00:00:00");
            dynamicParameters.Add("theNiveau", niveau);
            dynamicParameters.Add("theEtat", etat);
            dynamicParameters.Add("theUser", idUser);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }


        

        //
        // USERS
        //
        public void ResetPass(int id)
        {
            String strQuery = "UPDATE user SET pass = '12345', demandeChangePass = 1 WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", id);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
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
            String strQuery = "SELECT * FROM user WHERE login = @theLogin AND pass = @thePass";
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

        public void AddUser(String login, String pass, String role, int tentativeCo, int demandeChangePass)
        {
            String strQuery = "INSERT INTO user (login, pass, role, tentativeCo, demandeChangePass) VALUES (@theLogin, @thePass, @theRole, @theTentativeCo, @theDemandeChangePass)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theLogin", login);
            dynamicParameters.Add("thePass", pass);
            dynamicParameters.Add("theRole", role);
            dynamicParameters.Add("theTentativeCo", tentativeCo);
            dynamicParameters.Add("theDemandeChangePass", demandeChangePass);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public void UpdateUser(int id, String login, String role)
        {
            String strQuery = "UPDATE user SET login = @theLogin, role = @theRole WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", id);
            dynamicParameters.Add("theLogin", login);
            dynamicParameters.Add("theRole", role);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public void DeleteUser(int idUser)
        {
            String strQuery = "DELETE FROM user WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", idUser);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }




        //
        //SESSIONS
        //
        public List<Session> GetSessions(String formationId)
        {
            String strQuery = "SELECT id, date, hour_begin, hour_end, place FROM session WHERE id_formation = @idFormation";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("idFormation", formationId);
            dbConn.Open();
            List<Session> sessions = dbConn.Query<Session>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return sessions;
        }

        public void AddSession(DateTime date, string hourBegin, string hourEnd, string place, String formationId)
        {
            String strQuery = "INSERT INTO session (date, hour_begin, hour_end, place, id_formation) VALUES (@theDate, @theHBegin, @theHEnd, @thePlace, @theFormaId)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theDate", date);
            dynamicParameters.Add("theHBegin", hourBegin);
            dynamicParameters.Add("theHEnd", hourEnd);
            dynamicParameters.Add("thePlace", place);
            dynamicParameters.Add("theFormaId", formationId);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public void UpdateSession(String id, DateTime date, string hourBegin, string hourEnd, string place)
        {
            String strQuery = "UPDATE session SET date = @theDate, hour_begin = @theHBegin, hour_end = @theHEnd, place = @thePlace WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", id);
            dynamicParameters.Add("theDate", date);
            dynamicParameters.Add("theHBegin", hourBegin);
            dynamicParameters.Add("theHEnd", hourEnd);
            dynamicParameters.Add("thePlace", place);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public void DeleteSession(String idSession)
        {
            String strQuery = "DELETE FROM session WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", idSession);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }



        //
        //FORMATIONS
        //
        public List<Formation> GetFormations()
        {
            dbConn.Open();
            var formations = dbConn.Query<Formation>("SELECT * FROM formation").ToList();
            dbConn.Close();

            return formations;
        }



        //
        //PARTICIPANTS
        //

        public List<Participant> GetInscrits(String idSession)
        {
            String strQuery = "SELECT name, first_name FROM participant WHERE id_session = @idSession";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("idSession", idSession);
            dbConn.Open();
            List<Participant> inscrits = dbConn.Query<Participant>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return inscrits;
        }
    }
}
