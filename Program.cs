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
/*
            //Convertir temperatura y expresarla con decimales
            //https://learn.microsoft.com/es-es/training/modules/csharp-basic-operations/5-challenge
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * 5/9m;
            Console.WriteLine($"La temperatura es: {celsius} grados.");*/
/*
            //Cual número es mayor con el método System.Match()
            //https://learn.microsoft.com/es-es/training/modules/csharp-call-methods/5-challenge
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);*/
/*
            //Comprobar si ha expirado una suscripción
            //https://learn.microsoft.com/es-es/training/modules/csharp-if-elseif-else/4-challenge
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration <= 10)
            {
                if (daysUntilExpiration == 0)
                {
                    Console.WriteLine("Your subscription has expired.");
                }else if (daysUntilExpiration == 1)
                {
                    discountPercentage = 20;
                    Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
                }else if (daysUntilExpiration <= 5)
                {
                    discountPercentage = 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
                }
            }*/
/*
            //Encontrar valores en un array
            //https://learn.microsoft.com/es-es/training/modules/csharp-arrays/4-challenge
            string[] pedidosID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
            
            foreach (var pedidoID in pedidosID)
            {
                if (pedidoID.StartsWith("B"))
                    Console.WriteLine(pedidoID);
            }*/
/*
            //Cara o Cruz
            //https://learn.microsoft.com/es-es/training/modules/csharp-evaluate-boolean-expressions/4-challenge-1
            Random random = new Random();
            int moneda = random.Next(0, 2);
            Console.WriteLine((moneda == 0) ? "Cara" : "Cruz");*/

/*
            //Búsqueda de un producto SKU con switch
            //https://learn.microsoft.com/es-es/training/modules/csharp-switch-case/3-challenge
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                type = "Sweat shirt";
                break;
                case "02":
                type = "T-Shirt";
                break;
                default:
                type = "Sweat pants";
                break;
            }
              switch (product[1])
            {
                case "BL":
                color = "Black";
                break;
                case "MN":
                color = "Maroon";
                break;
                default:
                color = "White";
                break;
            }
            switch (product[2])
            {
                case "S":
                size = "Small";
                break;
                case "M":
                size = "Medium";
                break;
                case "L":
                size = "Large";
                break;
                default:
                size = "One Size Fits All";
                break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");*/

            //FizzBuzz
            //https://learn.microsoft.com/es-es/training/modules/csharp-for/3-challenge

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
