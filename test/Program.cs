// See https://aka.ms/new-console-template for more information
class App
{
    public static void Main(string[] arg)
    {
        float numberOne = 0;
        float numberTwo = 0;
        float result = 0;
        float option = 0;

        Console.WriteLine("--- La Super Calculadora de mario ----");
        Calculadora();

        void Calculadora()
        {

            Console.WriteLine("Introduce el primero numero: ");
            numberOne = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("----------------------------");
            Console.WriteLine("Introduce el segundo numero:");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------");
            Console.WriteLine("Escoge una operacion:");
            Console.WriteLine("1 para Suma");
            Console.WriteLine("2 para Resta");
            Console.WriteLine("3 para Multiplicación");
            Console.WriteLine("4 para División");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");

            switch (option)
            {

                case 1:
                    result = numberOne + numberTwo;
                    break;

                case 2:
                    result = numberOne - numberTwo;
                    break;

                case 3:
                    result = numberOne * numberTwo;
                    break;

                case 4:
                    result = numberOne / numberTwo;
                    break;

                default:
                    Console.WriteLine("Opcion erronea Puto");
                    break;

            }
        }

        if (option <= 4)
        {
            Console.WriteLine("El resultado es: " + result);
            doItAgain();
        };

        doItAgain();

        void doItAgain()
        {

            int newCalcInput = 0;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Quieres hacer un nuevo Calculo?");
            Console.WriteLine(" 1 para SI");
            Console.WriteLine(" 2 para NO");

            newCalcInput = Convert.ToInt16(Console.ReadLine());

            if (newCalcInput == 1)
            {
                Calculadora();
            }
            else if (newCalcInput == 2)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Chao Pescao");
                System.Environment.Exit(0);
            }
        }




    }

}