using System;

namespace CSharp_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/caracteristicas-de-csharp
            
            //============================= Introducción a C# ===============================//

            #region Ejer_1 - ¡Hola mundo!
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/hola-mundo
            
            // Console.WriteLine("Hola mundo");
            // Console.Read();
            #endregion

            #region Ejer_2 - Imprimir lineas en consola
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/imprimir-lineas-consola
            
            // Console.WriteLine("Hola");
            // Console.WriteLine("Juan");
            // Console.Read();
            #endregion

            #region Ejer_3 - Leer entrada del usuario
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/leer-entrada-usuario
            
            // Console.WriteLine("¿
            //Console.Read();
            // Console.WriteLine("El mio tambien");
            // Console.Read();
            #endregion

            #region Ejer_4 - Almacenar entrada del usuario
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/almacenar-entrada-usuario
            
            // Console.WriteLine("¿Como te llamas?");
            // string x = Console.ReadLine(); //tomar valor de consola
            // Console.WriteLine("encantado de conocerte {0}",x);
            #endregion

            #region Ejer_5 - Comentarios
            //https://www.exercisescsharp.com/es/introduccion-a-csharp/comentarios
            
            //TODO Gabriel Matias Quattrini 13/12/2021
            #endregion

            //============================= Tipos de datos A ================================//
            
            #region Ejer_6 - Calcular dimensiones de esfera
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/calcular-dimensiones-de-esfera

            // Console.WriteLine("Calcular superficie y volumen de: ");
            // //comvertir entrada de consola a float
            // float radio = Convert.ToSingle(Console.ReadLine());
            // float pi = 3.1415926535f;
            //
            // float superficie = 4 * pi * (radio * radio);//radio al cuadrado
            // float volumen = 4 / 3 * pi * (radio * radio * radio); //radio al cubo
            //
            // Console.WriteLine("Superficie: {0}", superficie);
            // Console.WriteLine("Volumen: {0}", volumen);

            #endregion

            #region Ejer_7 - Calculadora básica
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/calculadora-basica

            // Console.WriteLine("Ingrese primer valor:");
            // int v1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese segundo valor:");
            // int v2 = Convert.ToInt32(Console.ReadLine());
            //
            //
            // Console.WriteLine("Suma: {0} + {1} = {2}",v1,v2,v1+v2);
            // Console.WriteLine("Resta: {0} - {1} = {2}",v1,v2,v1-v2);
            // Console.WriteLine("Divición: {0} / {1} = {2}",v1,v2,v1/v2);
            // Console.WriteLine("Multiplicación: {0} * {1} = {2}",v1,v2,v1*v2);

            #endregion

            #region Ejer_8 - Caracteres al revés
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/caracteres-al-reves

            // Console.WriteLine("Ingrese 1er caracter");
            // char c1 = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do caracter");
            // char c2 = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine("Ingrese 3er caracter");
            // char c3 = Convert.ToChar(Console.ReadLine());
            //
            // Console.WriteLine("{0} {1} {2}",c3,c2,c1);
            #endregion

            #region Ejer_9 - "Grados-Centigrados-a-kelvin-fahrenheit" 
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/centigrados-a-kelvin-fahrenheit

            // Console.WriteLine("Ingrese Valor de Grados Centigrados:");
            // float grados = Convert.ToSingle(Console.ReadLine());
            //
            // Console.WriteLine("Grados Kelvin: {0}",grados+273);
            // Console.WriteLine("Grados Fahrenheit: {0}", grados*18/10+32);
            #endregion

            #region Ejer_10 - "Perimetro-Area-Pitagoras" Valor Double
            // https://www.exercisescsharp.com/es/tipos-de-datos-a/valor-double

            // Console.WriteLine("Ingrese Ancho:");
            // double x = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Ingrese Alto:");
            // double y = Convert.ToDouble(Console.ReadLine());
            //
            // double perimetro = x * 2 + y * 2; //suma de los lados
            // double area = x * y;  //Base x Altura
            // double diagonal = Math.Sqrt(x * x + y * y); //pitagoras
            //
            // Console.WriteLine("Perimetro: {0}", perimetro);
            // Console.WriteLine("Area: {0}",area);
            // Console.WriteLine("Diagonal: {0}",diagonal);
            
            #endregion

            #region Ejer_11 - Valor Float
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/valor-float

            // Console.WriteLine("Distancia:");
            // float distance = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("hora:");
            // float hr = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("minutos:");
            // float min = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("segundos:");
            // float seg = Convert.ToSingle(Console.ReadLine());
            //
            // //Tiempo en segundo = 1hr tiene 3600 seg = 1min tiene 60 seg.
            // float timeBySeconds = (hr * 3600) + (min * 60) + seg;
            // float mps = distance / timeBySeconds; //metros sobre seg
            // float kph = (distance / 1000.0f) / (timeBySeconds / 3600.0f); //kilometros por hora
            // float mph = kph / 1.609f; //millas por hora
            //
            // Console.WriteLine("Speed in meter/sec = {0}", mps);
            // Console.WriteLine("Speed in km/h = {0}", kph);
            // Console.WriteLine("Speed in millas/h = {0}", mph);

            #endregion

            #region Ejer_12 - Tabla de multiplicar
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/tabla-multiplicar
            
            // Console.WriteLine("Ingrese Numero:");
            // int num = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
            // }

            #endregion

            #region Ejer_13 - Generar un número al azar
            //https://www.exercisescsharp.com/es/tipos-de-datos-a/generar-numero-al-azar

            //int.Parse comvierte string a int32
            // Console.WriteLine("Ingrese Numero 1");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese Numero 2");
            // int num2 = int.Parse(Console.ReadLine());
            //
            // Random rnd = new Random();
            // int number = rnd.Next(num1, num2);
            //
            // Console.WriteLine("Numero Aleatorio entre {0} y {1} = {2}",num1,num2,number);
            #endregion
            
            //=============================== Aritmética ===================================//

            #region Ejer_14 - Sumas al cuadrado
            //https://www.exercisescsharp.com/es/aritmetica/sumas-al-cuadrado

            // Console.WriteLine("Ingrese Numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Resultado de numero al cuadrado:");
            // Console.WriteLine("{0}x{0} = {1}",num , num*num);

            #endregion

            #region Ejer_15 - Multiplicación de tres factores
            // https://www.exercisescsharp.com/es/aritmetica/multiplicacion-tres-factores

            // Console.WriteLine("Ingrese valor 1:");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese valor 2:");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese valor 3:");
            // int num3 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Resultado de: {0} x {1} x {2} = {3}",num1,num2,num3,num1*num2*num3);
            #endregion

            #region Ejer_16 - División y módulo de división
            //https://www.exercisescsharp.com/es/aritmetica/multiplicacion-tres-factores

            // Console.WriteLine("Ingrese numero a dividir:");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese divisor:");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Resultado división= {0}", num1/num2);
            // Console.WriteLine("Resto= {0}",num1%num2);
            
            #endregion

            #region Ejer_17 - División entre cero
            //https://www.exercisescsharp.com/es/aritmetica/division-entre-cero

            // Console.WriteLine("Ingrese numero a dividir:");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese divisor:");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            //
            // try
            // {
            //     Console.WriteLine("{0} / {1} = {2}" , num1, num2, num1/num2);
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("No se Puede dividir por 0");
            //     throw;
            // }

            #endregion
        }
    }
}