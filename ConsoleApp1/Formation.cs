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
        private List<string> listSession;

        public Formation(string unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
            this.listSession = new List<string>();
        }

        public void affecteParticipants(string Participant , int numeroSession)
        {
            
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

        public void setMesSessions(List<string> uneSessions)
        {
            this.listSession = uneSessions;
        }

        public List<string> getMesSessions()
        {
            return this.listSession;
        }
    }

   
}
