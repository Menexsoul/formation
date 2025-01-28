using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Création de la formation et des sessions
        Formation formation = new Formation("F001", "Formation en C#");

        Session session1 = new Session(101, new DateTime(2025, 2, 15), 2);
        Session session2 = new Session(102, new DateTime(2025, 2, 20), 3);

        formation.MesSessions.Add(session1);
        formation.MesSessions.Add(session2);

        // Création des participants
        Participant p1 = new Participant("Dupont", "Marie", 5);
        Participant p2 = new Participant("Durand", "Paul", 3);
        Participant p3 = new Participant("Martin", "Alice", 1);

        // Affectation des participants
        formation.AffecteParticipant(p1, 101);
        formation.AffecteParticipant(p2, 101);
        formation.AffecteParticipant(p3, 102);

        // Tentative d'ajouter un participant à une session pleine
        Participant p4 = new Participant("Roche", "Clara", 2);
        formation.AffecteParticipant(p4, 101);

        // Affichage des participants par session
        foreach (var session in formation.MesSessions)
        {
            Console.WriteLine($"Session {session.Numero} ({session.Date.ToShortDateString()}):");
            foreach (var participant in session.LesParticipants)
            {
                Console.WriteLine($" - {participant.Prenom} {participant.Nom}, ancienneté: {participant.Anciennete} ans");
            }
            Console.WriteLine();
        }
    }
}
}