namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var (valor1, valor2, valor3) = (10, 1, 2);
            Console.WriteLine("Los valores son " + valor1 + valor2 + valor3);
            //Operadores relacionales == != >,<, >=, <=

            bool resultado1 = valor1 == valor2;
            Console.WriteLine("Valor1 es igual que valor2? " + resultado1);
            bool resultado2 = valor1 != valor2;
            Console.WriteLine("Valor1 es diferente que valor2? " + resultado2);
            bool resultado3 = valor1 > valor2;
            Console.WriteLine("Valor1 es mayor que valor2? " + resultado3);
            bool resultado4 = valor1 < valor2;
            Console.WriteLine("Valor1 es menor que valor2? " + resultado4);
            bool resultado5 = valor1 >= valor2;
            Console.WriteLine("Valor1 es mayor igual que valor2? " + resultado5);
            bool resultado6 = valor1 == valor2;
            Console.WriteLine("Valor1 es menor igual que valor2? " + resultado6);

            Console.WriteLine("Ricardo Perez ID");
            int altura = 168;
            int edad = 89;
            string nombre = "Ricardo Perez";
            string información = "Nació en Hidalgo. Es estudiante de gastronomía y astronomía";
            var hooby = "deportista";*/

            //string tarjetaIdentificacion = $"La información de Ricardo Perez es la siguiente. " +
            // $"Su edad es 89, su altura es 168";

            /*string tarjetaIdentificacion = $"La información de {nombre} es la siguiente.\n" +
             $"Su edad es {edad}\nSu altura es {altura}\nInformación relevante: {información}\n" +
             $"Su hobby es: {hooby}";
            Console.WriteLine(tarjetaIdentificacion);*/

            //Condicional
            int totalJugador = 0;
            int totalDealer = 0;
            string message = "";
            int carta = 0;
            System.Random random = new System.Random();
            string respuesta = "";
            bool repetir = true;
            //Blackjack consiste en juntar cartas hasta tener 21 puntos como máximo. Ganas si tienes mayor puntuación que el dealer
            /*if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al dealer. Felicidades";
            }
            else if (totalJugador > 21)
            {
                message = "Perdiste. Te pasaste de 21";
            }
            else { message = "Perdiste contra el dealer. Lo siento"; }
            Console.WriteLine(message);*/

            //Switch control
            string switchControl = "menú";
            int fichas = 0;
            int fichasJugada = 0;
            string respuestaOtroJuego = "";
            
            do
            {
                Console.WriteLine("****Bienvenido al C A S I N O****");
                Console.WriteLine("¿Cuántas fichas deseas comprar?");
                fichas = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; fichas>0; i++)
                {
                    repetir = true;
                    while (repetir)
                    {
                        totalJugador = 0;
                        totalDealer = 0;
                        switch (switchControl)
                        {
                            case "menú":
                                Console.WriteLine($"\n\nJugada {i + 1}:");
                                do
                                {
                                    Console.WriteLine($"Tienes {fichas} ficha(s).\nFichas a apostar (<={fichas}): ");
                                    fichasJugada = Convert.ToInt16(Console.ReadLine());
                                    if (fichasJugada > fichas)
                                    {
                                        Console.WriteLine($"No cuentas con {fichasJugada} ficha(s). \nIngresa una cantidad válida");
                                    }
                                } while (fichasJugada > fichas);
                                Console.WriteLine("\nEscribe 21 para jugar 21");
                                switchControl = Console.ReadLine();//i=i-1; para no aumentar el contador por el menú
                                break;
                            case "21":
                                do
                                {
                                   
                                    carta = random.Next(1, 12);//Valor aleatorio de carta
                                    totalJugador = totalJugador + carta;
                                    Console.WriteLine($"Te tocó la carta: {carta}, tienes {totalJugador} puntos");
                                    if (totalJugador < 22)
                                    { 
                                        Console.WriteLine("Deseas otra carta? 1(sí), 0(no)");
                                        respuesta = Console.ReadLine();
                                    }
                                    else Console.WriteLine("Ya no puedes tener más cartas. Te pasaste de 21.");
                                    
                                } while (respuesta == "1" && totalJugador < 22);
                                totalDealer = random.Next(10, 22);
                                if (totalJugador > totalDealer && totalJugador < 22)
                                {
                                    message = $"Venciste al dealer. Felicidades. \nGanaste {fichasJugada} ficha(s)";
                                    fichas=fichas+fichasJugada;
                                }
                                else if (totalJugador > 21)
                                {
                                    message = $"Perdiste. Te pasaste de 21. \nPerdiste {fichasJugada} ficha(s)";
                                    fichas = fichas - fichasJugada;
                                }
                                else
                                {
                                    message = $"Perdiste contra el dealer. Lo siento. \nPerdiste {fichasJugada} ficha(s)";
                                    fichas = fichas - fichasJugada;
                                }
                                Console.WriteLine($"Jugador {totalJugador} vs Dealer {totalDealer}");
                                Console.WriteLine(message);
                                switchControl = "menú";
                                repetir = false;
                                break;
                            default:
                                Console.WriteLine("Valor no válido para el C A S I N O");
                                switchControl = "menú";
                                break;
                        }
                    }
                    if (fichas==0)
                    {
                        Console.WriteLine("\n\nSe terminaron tus fichas\nDeseas comprar más? 1(sí), 0(no)");
                        respuestaOtroJuego = Console.ReadLine();
                        if (respuestaOtroJuego == "1")
                            Console.Clear();
 
                    }
                }
            }
            while (respuestaOtroJuego=="1");
        }
    }
}
