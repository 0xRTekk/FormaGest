using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


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
            //Db locale WAMP
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
        public void AddFormation(String name)
        {
            String strQuery = "INSERT INTO formation (name) VALUES (@theName)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theName", name);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }
        public List<Formation> GetFormations()
        {
            dbConn.Open();
            var formations = dbConn.Query<Formation>("SELECT * FROM formation").ToList();
            dbConn.Close();

            return formations;
        }
        public List<Formation> GetFormationsByPartiId(String idParticipant)
        {
            String strQuery = "SELECT id, name FROM formation WHERE id IN(SELECT formation_id FROM interesser WHERE participant_id = @theId)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", idParticipant);
            dbConn.Open();
            var formations = dbConn.Query<Formation>(strQuery, dynamicParameters).ToList();
            dbConn.Close();

            return formations;
        }
        public void DeleteFormation(String idFormation)
        {
            String strQuery = "DELETE FROM formation WHERE id = @theId";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theId", idFormation);
            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }


        //
        //PARTICIPANTS
        //

        public List<Participant> GetParticipants()
        {
            String strQuery = "SELECT id, name, first_name FROM participant";
            dbConn.Open();
            List<Participant> participants = dbConn.Query<Participant>(strQuery).ToList();
            dbConn.Close();

            return participants;
        }

        public void AddParticipant(String name, String f_name, String email, String tel)
        {
            String strQuery = "INSERT INTO participant (name, first_name, email, telephone, id_session) " +
                "VALUES (@theName,@theFirst_name,@theEmail,@theTel)";
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theName", name);
            dynamicParameters.Add("theFirst_name", f_name);
            dynamicParameters.Add("theEmail", email);
            dynamicParameters.Add("theTel", tel);

            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }

        public int AddParticipantRtnId(String name, String f_name, String email, String tel)
        {
            using (MySqlCommand cmd = new MySqlCommand("addParticipantRtnId", dbConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?Pname", name);
                cmd.Parameters["?Pname"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?Pfirst_name", f_name);
                cmd.Parameters["?Pfirst_name"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?Pemail", email);
                cmd.Parameters["?Pemail"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?Ptelephone", tel);
                cmd.Parameters["?Ptelephone"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PrtnId", MySqlDbType.Int64);
                cmd.Parameters["?PrtnId"].Direction = ParameterDirection.Output;
                
                dbConn.Open();
                // this ALWAYS returns a 0 for this insert
                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                // Now get the OUT parameters
                int idInserted = (int)cmd.Parameters["?PrtnId"].Value;
                dbConn.Close();

                return idInserted;
            }
            
        }

        public void UpdateParticipant(String name, String f_name, String email, String tel, String sess)
        {
            String strQuery = "UPDATE participant SET name = @theName, first_name = @theFirst_name, email = @theEmail, telephone = @theTel, id_session = @theSess";
            
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theName", name);
            dynamicParameters.Add("theFirst_name", f_name);
            dynamicParameters.Add("theEmail", email);
            dynamicParameters.Add("theTel", tel);
            dynamicParameters.Add("theSess", sess);

            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }





        ///
        /// INTERETS
        ///
        public void addInterests(String id_formation, String id_participant)
        {
            using (MySqlCommand cmd = new MySqlCommand("addInteresser", dbConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?Pformation_id", id_formation);
                cmd.Parameters["?Pformation_id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?Pparticipant_id", id_participant);
                cmd.Parameters["?Pparticipant_id"].Direction = ParameterDirection.Input;

                dbConn.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                dbConn.Close();
            }
        }



        ///
        /// CANDIDATER
        ///
        public void updateCandidater(String idSess, String idParti, String accepter, String refus)
        {
            String strQuery = "INSERT INTO candidater(session_id, participant_id, accepter, motif_refus) VALUES (@theIdSess,@theIdParti,@theAccepeter,@theRefus)";

            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("theIdSess", idSess);
            dynamicParameters.Add("theIdParti", idParti);
            dynamicParameters.Add("theAccepeter", accepter);
            dynamicParameters.Add("theRefus", refus);

            dbConn.Open();
            dbConn.Query(strQuery, dynamicParameters);
            dbConn.Close();
        }
    }
}
