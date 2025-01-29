using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Participant
    {
        private string nom;
        private string prenom;
        private int anciennete;
        private Session laSession;

        public Participant(string unNom, string unPrenom, int uneAnciennete, Session uneSession)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.anciennete = uneAnciennete;
            this.laSession = uneSession;
        }

        public void setNom(string unNom)
        {
            this.nom = unNom;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setPrenom(string unPrenom)
        {
            this.prenom = unPrenom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void setAnciennete(int uneAnciennete)
        {
            this.anciennete=uneAnciennete;
        }

        public int getAnciennete()
        {
            return this.anciennete;
        }

        public void setLaSession(Session uneSession)
        {
            this.laSession=uneSession;
        }

        public Session getLaSession()
        {
            return this.laSession;
        }
    }
    

}
