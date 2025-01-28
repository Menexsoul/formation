using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Formation
    {
        private string code;
        private string libelle;
        private List<Session> mesSessions;

        public Formation(string unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
            this.mesSessions = new List<Session>();
        }

        public void affecteParticipants(Participant p , int numeroSession)
        {
           Session session = MesSessions.Find(s => s.Numero == numeroSession);
            if (session != null)
            {
                session.AjouteParticipant(participant);
            }
            else
            {
                Console.WriteLine($"Session {numeroSession} introuvable.");
            }
        }

        public void setCode(string unCode)
        {
            this.code = unCode;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setLibelle(string unLibelle)
        {
            this.libelle = unLibelle;
        }

        public string getLibelle()
        {
            return this.libelle;
        }

        public void setMesSessions(List<Session> uneSessions)
        {
            this.mesSessions = uneSessions;
        }

        public List<Session> getMesSessions()
        {
            return this.mesSessions;
        }
    }

   
}
