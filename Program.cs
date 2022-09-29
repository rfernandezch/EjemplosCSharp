using System;

namespace EjemplosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {/*
             //Mostrar valores de direfentes tipos de variable
            //https://learn.microsoft.com/es-es/training/modules/csharp-literals-variables/6-challenge
            string nombre = "Bob";
            int numeroMensajes= 3;
            decimal temperatura = 34.4m;
            Console.WriteLine($"Hello, {nombre}! You have {numeroMensajes} messages. The temperature is {temperatura}");*/
/*
            //Cadena de texto con secuencias de escape de caracteres
            //https://learn.microsoft.com/es-es/training/modules/csharp-basic-formatting/5-challenge
            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t{englishLocation}\n");

            string russianMessage = "\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");*/


            //Convertir temperatura y expresarla con decimales
            //https://learn.microsoft.com/es-es/training/modules/csharp-basic-operations/5-challenge
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * 5/9m;
            Console.WriteLine($"La temperatura es: {celsius} grados.");
/*
            //Tirar dados hasta que se agote la vida del Héroe o del Monstruo (juego de rol)
            //https://learn.microsoft.com/es-es/training/modules/csharp-do-while/3-challenge
            Random random = new Random();
            int saludHeroe = 10;
            int saludMonstruo = 10;

            while ((saludHeroe > 0) | (saludMonstruo > 0))
            {
                int randomDados = random.Next(1, 11);
                saludMonstruo -= randomDados;

                Console.WriteLine($"El Monstruo es atacado y pierde {randomDados} de vida. Le queda {saludMonstruo} de vida");
                
                if (saludMonstruo < 0) break;

                randomDados = random.Next(1, 11);
                saludHeroe -= randomDados;

                Console.WriteLine($"El Heroe es atacado y pierde {randomDados} de vida. Le queda {saludHeroe} de vida");
                
                if (saludHeroe < 0) break;

            }
            if (saludHeroe < 0)
                Console.WriteLine($"Ha ganado el Monstruo");
            else
                Console.WriteLine($"Ha ganado el Heroe");*/
        }
    }
}
