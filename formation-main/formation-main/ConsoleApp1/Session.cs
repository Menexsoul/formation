using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Session
    {

        private int numero;
        private DateTime date;
        private int nbMax;
        private List<Session> Participants;

        public Session (int unNumero, DateTime uneDate, int unNbMax) 
        {
            this.numero = unNumero;
            this.date = uneDate;
            this.nbMax = unNbMax;
            this.Participants = new List<Session>();
        }

        public void setNumero(int unNumero)
        {
            this.numero = unNumero ;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setDate(DateTime uneDate)
        {
            this.date = uneDate ;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public void setNbMax(int unNbMax)
        {
            this.nbMax=unNbMax;
        }

        public int getNbMax()
        {
            return this.nbMax;
        }

        public void setParticipants(List<Session> unParticipants)
        {
            this.Participants=unParticipants;
        }

        public List<Session> getParticipants()
        {
            return this.Participants;
        }


    }

    
}
