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
        private List<Participant> Participants;

        public Session(int unNumero, DateTime uneDate, int unNbMax)
        {
            this.numero = unNumero;
            this.date = uneDate;
            this.nbMax = unNbMax;
            this.Participants = new List<Participant>();
        }

        public void setNumero(int unNumero)
        {
            this.numero = unNumero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setDate(DateTime uneDate)
        {
            this.date = uneDate;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public void setNbMax(int unNbMax)
        {
            this.nbMax = unNbMax;
        }

        public int getNbMax()
        {
            return this.nbMax;
        }

        public void setParticipants(List<Participant> unParticipants)
        {
            this.Participants = unParticipants;
        }

        public List<Participant> getParticipants()
        {
            return this.Participants;
        }

        public bool estPleine()
        {
            return (nbMax != Participants.Count)? false: true;
            /*if (nbMax != Participants.Count)
            {
                return false;
            }
            else
            {
                return true;
            }*/
        }

        public void addParticipant(Participant p)
        {
            if (!estPleine())
            {
                Participants.Add(p);
            }
            else
            {
                Console.WriteLine($"Session {numero} est pleine");
            }
        }

    }
}
