internal class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            // Numero de ganadores y perdedores
            int estudiantesGanaron = 0;
            int estudiantesPerdieron = 0;

            // Ingresar número de estudiantes a calificar
            Console.Clear();
            Console.WriteLine("Sistema de Evaluación Notas de Estudiantes");
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            // ingresar notas de los estudiantes
            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese las notas del Estudiante {i}");

                //Numero de asignaturas 
                Console.Write("¿Cuántas asignaturas cursa el estudiante? ");
                int numAsignaturas = int.Parse(Console.ReadLine());

                // inicio de la variable para el total de las notas
                double sumaNotas = 0;

                // Ingresar las notas de cada asignatura
                for (int j = 1; j <= numAsignaturas; j++)
                {
                    double nota;
                    do
                    {
                        Console.Write($"Ingrese la nota de la asignatura {j} (0 a 5): ");
                    } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 5);

                    sumaNotas += nota;
                }

                // Calcular el promedio
                double promedio = sumaNotas / numAsignaturas;

                // Clasificación según el promedio
                string categoria;
                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                    estudiantesGanaron++;
                }
                else if (promedio >= 4.0)
                {
                    categoria = "Sobresaliente";
                    estudiantesGanaron++;
                }
                else if (promedio >= 3.5)
                {
                    categoria = "Bueno";
                    estudiantesGanaron++;
                }
                else
                {
                    categoria = "Insuficiente";
                    estudiantesPerdieron++;
                }

                // Mostrar resultado del estudiante 
                Console.Clear();
                Console.WriteLine($"Estudiante {i}:");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Categoría: {categoria}");
                Console.WriteLine();
            }

            // Mostrar cuántos estudiantes ganaron y cuántos perdieron 
            Console.WriteLine("Resultados finales:");
            Console.WriteLine($"Estudiantes que ganaron: {estudiantesGanaron}");
            Console.WriteLine($"Estudiantes que perdieron: {estudiantesPerdieron}");

            // Preguntar si desea ingresar otro grupo de estudiantes
            Console.Write("¿Desea ingresar otro grupo de estudiantes? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta != "S")
            {
                continuar = false;
            }
        }

        Console.WriteLine("¡Vuelva pronto Adios!");
    }
}

