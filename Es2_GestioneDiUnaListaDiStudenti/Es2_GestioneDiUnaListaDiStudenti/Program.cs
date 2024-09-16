using Es2_GestioneDiUnaListaDiStudenti.classes;

namespace Es2_GestioneDiUnaListaDiStudenti
{

    internal class Program
    {
        static List<Studente> studenti = new List<Studente>();


        static void Main(string[] args)
        {

            bool insStu = true;

            while (insStu)
            {
                Console.WriteLine("--------------------------***--------------------------");
                Console.WriteLine($"Cosa vuoi fare?\n" +
                    $"1 - Inserire studenti con voto\n" +
                    $"2 - Visualizzare tutti gli studenti\n" +
                    $"3 - Modificare uno studente\n" +
                    $"4 - Visualizzare gli studenti in base ai voti\n" +
                    $"5 - Eliminare uno studente\n" +
                    $"Q - Uscire");
                Console.WriteLine("--------------------------***--------------------------");
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "1":
                        Console.WriteLine("--------------------------***--------------------------");
                        Console.Write("Inserisci il nome: ");
                        string? varNome = Console.ReadLine();
                        Console.Write("Inserisci il cognome: ");
                        string? varCognome = Console.ReadLine();
                        Console.Write("Inserisci il voto da 0 a 10: ");
                        double varVoto = Convert.ToDouble(Console.ReadLine());
                        studenti.Add(new Studente { Nome = varNome, Cognome = varCognome, Voto = varVoto});
                        Console.WriteLine("Attendere...");
                        Console.WriteLine("Studente aggiunto con succeso!!");
                        Console.WriteLine("--------------------------***--------------------------");
                        break;
                    case "2":
                        {
                            if (studenti.Count == 0)
                            {
                                Console.WriteLine("--------------------------***--------------------------");
                                Console.WriteLine("Nessuno studente presente.\n");
                            }
                            else
                            {
                                foreach (var studente in studenti)
                                {
                                    Console.WriteLine($"Nome: {studente.Nome}, Cognome: {studente.Cognome}, Voto: {studente.Voto}");
                                }
                                
                                Console.WriteLine("--------------------------***--------------------------");
                            }
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("--------------------------***--------------------------");
                            Console.Write("Inserisci il nome dello studente da modificare: ");
                            string nome = Console.ReadLine();

                            var studente = studenti.FirstOrDefault(s => s.Nome == nome);
                            if (studente != null)
                            {
                                Console.Write("Nuovo nome: ");
                                studente.Nome = Console.ReadLine();
                                Console.Write("Nuovo cognome: ");
                                studente.Cognome = Console.ReadLine();
                                Console.Write("Nuovo voto (da 0 a 10): ");
                                studente.Voto = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Dati dello studente modificati con successo!\n");
                                Console.WriteLine("--------------------------***--------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Studente non trovato.\n");
                            }
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine("--------------------------***--------------------------");
                            Console.Write("Inserisci il voto minimo: ");
                            double minVoto = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inserisci il voto massimo: ");
                            double maxVoto = Convert.ToDouble(Console.ReadLine());

                            var studentiFiltrati = studenti.Where(s => s.Voto >= minVoto && s.Voto <= maxVoto).ToList();

                            if (studentiFiltrati.Count == 0)
                            {
                                Console.WriteLine("Nessuno studente trovato in questo intervallo di voti.\n");
                            }
                            else
                            {
                                foreach (var studente in studentiFiltrati)
                                {
                                    Console.WriteLine($"Nome: {studente.Nome}, Cognome: {studente.Cognome}, Voto: {studente.Voto}");
                                }
                                
                                Console.WriteLine("--------------------------***--------------------------");
                            }
                        }
                        break;
                    case "5":
                        {
                            Console.WriteLine("--------------------------***--------------------------");
                            Console.Write("Inserisci il nome dello studente da eliminare: ");
                            string nome = Console.ReadLine();

                            var studente = studenti.FirstOrDefault(s => s.Nome == nome);
                            if (studente != null)
                            {
                                studenti.Remove(studente);
                                Console.WriteLine("Attendere...");
                                Console.WriteLine("Studente eliminato con successo!\n");
                                Console.WriteLine("--------------------------***--------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Studente non trovato.\n");
                                Console.WriteLine("--------------------------***--------------------------");
                            }
                        }
                        break;
                    case "Q":
                        Console.WriteLine("--------------------------***--------------------------");
                        Console.WriteLine("Il programma sta per chiudersi...");
                        Console.WriteLine("--------------------------***--------------------------");
                        insStu = !insStu;
                        break;
                    default:
                        Console.WriteLine("--------------------------***--------------------------");
                        Console.WriteLine("ERRORE! Comando non ricosciuto!");
                        Console.WriteLine("--------------------------***--------------------------");
                        break;
                }
            }
        }
    }
}