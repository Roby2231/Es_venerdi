namespace Es1_CalcolatriceBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool insDati = true;
            int x = 0; 
            int y = 0;

       

            Console.WriteLine("--------------------------ARRAY--------------------------");
            int [] array = {5,10, 15, 20, 25, 30};
            Console.WriteLine($"Array di numeri: {array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("--------------------------ARRAY--------------------------");

            while (insDati)
            {
               
                Console.WriteLine("--------------------------***--------------------------");
                Console.WriteLine("Cosa vuoi inserire?\n1 - Numeri\n2 - Operazione\nQ - QUIT");
                Console.WriteLine("--------------------------***--------------------------");
                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "1":
                        Console.WriteLine("--------------------------NUMERI--------------------------");
                        Console.Write("Inserisci il primo numero: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserisci secondo numero: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    case "2":
                        Console.WriteLine("--------------------------OPERAZIONE--------------------------");
                        Console.WriteLine("Scegli un'operazione (+, -, *, /, ^, rad): ");
                        string? inputOp = Console.ReadLine();

                        switch (inputOp)
                        {
                            case "+":
                                int ris = x + y;
                                Console.WriteLine("--------------------------RISULTATO--------------------------");
                                Console.WriteLine($"Il risultato di {x} {inputOp} {y} é {ris}");
                                break;
                            case "-":
                                int ris2 = x - y;
                                Console.WriteLine("--------------------------RISULTATO--------------------------");
                                Console.WriteLine($"Il risultato di {x} {inputOp} {y} é {ris2}");
                                break;
                            case "*":
                                int ris3 = x * y;
                                Console.WriteLine("--------------------------RISULTATO--------------------------");
                                Console.WriteLine($"Il risultato di {x} {inputOp} {y} é {ris3}");
                                break;
                            case "/":
                                if (y != 0)
                                {
                                    int ris4 = x / y;
                                    Console.WriteLine("--------------------------RISULTATO--------------------------");
                                    Console.WriteLine($"Il risultato di {x} {inputOp} {y} é {ris4}");
                                }
                                else
                                {
                                    Console.WriteLine("ERRORE! Non puoi dividere per zero.");
                                }
                                break;

                            case "^":
                                double ris5 = Math.Pow(x, y);
                                Console.WriteLine("--------------------------RISULTATO--------------------------");
                                Console.WriteLine($"Il risultato di {x} {inputOp} {y} è {ris5}");
                                break;
                            case "rad":                              
                                    double ris6 = Math.Sqrt(x);
                                    Console.WriteLine("--------------------------RISULTATO--------------------------");
                                    Console.WriteLine($"La radice quadrata di {x} è {ris6}");
                                break;
                             
                        }
                        break;
                    case "Q":
                        insDati = !insDati;
                        break;
                    default:
                        Console.WriteLine("ERRORE! Comando non riconosciuto.");
                        break;

                    
     }
    }
   }
  }
}
