internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            //Ingresando la cantidad de jugadores que van a jugar
            int jugadores = 0;
            while (jugadores < 2 || jugadores > 4)
            {
                Console.Clear();
                Console.WriteLine("\nBienvenido al juego 'Adivina el número'");
                Console.Write("Ingrese cuantas personas van a jugar (2 a 4): ");
                jugadores = int.Parse(Console.ReadLine());

                //validamos si cumple el requisito para el minimo de jugadores

                if (jugadores < 2 || jugadores > 4)
                {
                    Console.WriteLine("¡Número de jugadores no válido! Deben ser entre 2 y 4 jugadores.");
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                }
            }

            //Generar numero aleatorio
            int rangoMin = 0;
            int rangoMax = 0;

            //ejecuatando opciones segun numero de jugadores

            switch (jugadores)
            {
                case 2:
                    rangoMax = 50;
                    break;
                case 3:
                    rangoMax = 100;
                    break;
                case 4:
                    rangoMax = 200;
                    break;
            }

            Random random = new Random();
            int numeroAleatorio = random.Next(rangoMin, rangoMax + 1);  // +1 porque el rango es inclusivo

            //Proceso del Juego
            int turno = 0;  // Indice para el jugador actual
            bool haGanado = false;
            int[] intentos = new int[jugadores];

            while (!haGanado)
            {
                Console.Clear();
                Console.WriteLine($"Jugador {turno + 1}, es tu turno!");
                Console.Write($"Introduce un número entre {rangoMin} y {rangoMax}: ");

                int intento;
                while (!int.TryParse(Console.ReadLine(), out intento) || intento < rangoMin || intento > rangoMax)
                {
                    Console.WriteLine($"Por favor, introduce un número válido entre {rangoMin} y {rangoMax}.");
                    Console.Write($"Jugador {turno + 1}, intenta de nuevo: ");
                }

                // Verificar si el número es correcto
                if (intento == numeroAleatorio)
                {
                    Console.Clear();
                    Console.WriteLine($"¡Jugador {turno + 1} HAS GANADO! El número era {numeroAleatorio}.");
                    haGanado = true;
                }
                else if (intento < numeroAleatorio)
                {
                    Console.WriteLine("¡El número es mayor!");
                }
                else
                {
                    Console.WriteLine("¡El número es menor!");
                }

                // Incrementar el turno, y volver al primer jugador si es necesario
                turno = (turno + 1) % jugadores;

                // Pausa antes de continuar 
                if (!haGanado)
                {
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                }
            }

            // Preguntar si quieren jugar nuevamente
            Console.Write("¿Desean jugar otra vez? (s/n): ");
        } while (Console.ReadLine().ToLower() == "s");

        Console.WriteLine("¡Gracias por jugar! Presiona Enter para salir...");
        Console.ReadLine();
    }
}