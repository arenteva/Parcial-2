internal class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.Creditos = ObtenerEntrada("Ingrese la cantidad de créditos: ", "Por favor, ingrese un número válido.");
            estudiante.Estrato = ObtenerEntrada("Ingrese el estrato del estudiante (1, 2 o 3): ", "Por favor, ingrese un número válido entre 1 y 3.");

            decimal costoMatricula = estudiante.CalcularMatricula();
            decimal subsidio = estudiante.CalcularSubsidio();

            Console.WriteLine($"\nEl costo de la matrícula es: {costoMatricula:C}");
            Console.WriteLine($"El valor del subsidio es: {subsidio:C}\n");

            Console.Write("¿Desea calcular la matrícula de otro estudiante? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            continuar = respuesta == "s";
        }
    }

    static int ObtenerEntrada(string mensaje, string mensajeError)
    {
        int valor;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor) && valor > 0)
                return valor;
            else
                Console.WriteLine(mensajeError);
        }
    }
}