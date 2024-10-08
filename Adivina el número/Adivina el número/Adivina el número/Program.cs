internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            //Ingresando la cantidad de jugadores que van a jugar
            int jugadores = 0;
            while (jugadores < 2 || jugadores > 4);
            {
                Console.Clear();
                Console.WriteLine("\nBienvenido al juego 'Adivina el número'");
                Console.Write("Ingrese cuantas personas van a jugar (2 a 4): ");
                jugadores = Convert.ToInt32(Console.ReadLine());

                //validamos si cumple el requisito para el minimo de jugadores

                if (jugadores < 2 || jugadores > 4)
                {
                    Console.WriteLine("\n¡Número de jugadores no válido! Deben ser entre 2 y 4 jugadores.");
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                }

                //Generar numero aleatorio
                int rangoMin = 0;
                int rangoMax = 0;


                //Ejecutando numero de bloques segun los jugadores

            }


        }
        while (true);
    }
}