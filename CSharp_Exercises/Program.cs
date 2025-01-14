﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CSharp_Exercises
{
    class Program
    {
        public static string nombreBaseDatos = "out.sqlite";
        public static string DatabaseFileName = "persons.sqlite";
        
        //https://www.exercisescsharp.com/es/introduccion-a-csharp/caracteristicas-de-cshar
        static void Main(string[] args)
        {
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

            #region Ejer_3 - Leer entrada del usuario - Read()

            //https://www.exercisescsharp.com/es/introduccion-a-csharp/leer-entrada-usuario

            /*
             * Documentacion Read:
             * https://docs.microsoft.com/en-us/dotnet/api/system.console.read?view=net-6.0
             */
            
            // Console.WriteLine("¿Cuál es tu animal favorito?");
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

            #region Ejer_10 - "Perimetro-Area-Pitagoras" - Valor Double

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

            #region Ejer_18 - Orden de prioridad

            //https://www.exercisescsharp.com/es/aritmetica/orden-de-prioridad

            // Console.WriteLine("Por favor ingrese un numero por consola");
            // int num = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Resultado:");
            // Console.WriteLine("-6 + {0} * 5 = {1}",num, -6 + num * 5);
            // Console.WriteLine("(13-2) * {0} = {1}",num, (13-2) * num);
            // Console.WriteLine("({0} + -2) * (20 / 10) = {1}",num,(num + -2) * (20 / 10));
            // Console.WriteLine("(12 + {0}) / (5 - 4) = {1}",num,(12 + num) / (5 - 4));

            #endregion

            #region Ejer_19 - Media aritmética

            //https://www.exercisescsharp.com/es/aritmetica/media-aritmetica
            // Console.WriteLine("Ingrese 1er numero");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 3er numero");
            // int num3 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 4to numero");
            // int num4 = Convert.ToInt32(Console.ReadLine());
            //
            // //para calcular la media sumar los 4 numeros y dividirlos x su cantidad 
            // int result = (num1 + num2 + num3 + num4) / 4;
            // Console.WriteLine(result);

            #endregion

            #region Ejer_20 - Operaciones equivalentes

            //https://www.exercisescsharp.com/es/aritmetica/operaciones-equivalentes

            // Console.WriteLine("Ingrese valor de a");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese valor de b");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese valor de c");
            // int c = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("(a+b)*c = ({0}+{1})*{2} = {3}", a,b,c,(a+b)*c);
            // Console.WriteLine("a*c + b*c = {0}*{2} + {1}*{2} = {3}",a,b,c,a*c + b*c);

            #endregion

            #region Ejer_21 - Calcular valores de una función

            //https://www.exercisescsharp.com/es/aritmetica/calcular-valores-funcion

            // Console.WriteLine("Ingrese valor de x1");
            // int x1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese valor de x2");
            // int x2 = Convert.ToInt32(Console.ReadLine());
            //
            // int y;
            //
            // for (int x = x1; x <= x2; x++)
            // {
            //     y= x*x-2*x+1;
            //     Console.Write("{0} ",y);
            // }

            #endregion

            //=============================== Geometría A ===================================//

            #region Ejer_22 - Dibujar un cuadrado

            //https://www.exercisescsharp.com/es/geometria-a/dibujar-cuadrado

            // Console.WriteLine("numero con el cual 'pintar'");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ancho del cuadrado");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 0; i < num2; i++)//filas
            // {
            //     for (int j = 0; j < num2; j++)//columnas
            //     {
            //         Console.Write(num1);
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_22 - Dibujar un rectángulo

            //https://www.exercisescsharp.com/es/geometria-a/dibujar-rectangulo

            // Console.WriteLine("Ingrese numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 0; i < 5; i++)//filas
            // {
            //     for (int j = 0; j < 3; j++)//columnas
            //     {
            //         Console.Write(x);
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_23 - Dibujar un triángulo

            //https://www.exercisescsharp.com/es/geometria-a/dibujar-triangulo

            // Console.WriteLine("Ingrese numero con el cual 'pintar'");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese Ancho y Alto del triangulo");
            // int y = Convert.ToInt32(Console.ReadLine());
            //
            // int alto = y;
            // int ancho = y;
            //
            // for (int i = 0; i < alto; i++)//fila
            // {
            //     for (int j = 0; j < ancho; j++)
            //     {
            //         Console.Write(x);
            //     }
            //     Console.WriteLine();
            //     --ancho;
            // }

            #endregion

            #region Ejer_24 - Dibujar un triángulo nordeste

            //https://www.exercisescsharp.com/es/geometria-a/dibujar-triangulo-nord-este

            // Console.WriteLine("ingrese Ancho-Alto");
            // int x = Convert.ToInt32(Console.ReadLine());
            //
            // int a = x;
            // int b = 0;
            //
            // for (int i = 0; i < x; i++)
            // {
            //     for (int j = 0; j < b; j++)
            //     {
            //         Console.Write(" ");
            //     }
            //
            //     for (int k = 0; k < a; k++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            //     a--;
            //     b++;
            // }

            #endregion

            #region Ejer_25 - Dibujar un triángulo alineado a la derecha - Substring

            //https://www.exercisescsharp.com/es/geometria-a/dibujar-triangulo-alineado-derecha

            // Console.WriteLine("Ingrese texto");
            // string text = Console.ReadLine();
            //
            // int aux=1;
            // for (int i = text.Length-1 ; i >= 0; i--)//fila
            // {
            //     Console.WriteLine(text.Substring(i,aux));
            //     aux++;
            // }

            #endregion

            #region Ejer_26 - Mostrar el gráfico de una función

            //https://www.exercisescsharp.com/es/geometria-a/mostrar-grafico-de-funcion

            // Console.WriteLine("1er Numero");
            // int x1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("2do Numero");
            // int x2 = Convert.ToInt32(Console.ReadLine());
            // int y = 0;
            //
            // for (int x = x1; x <= x2; x++)
            // {
            //     y = (x-4)*(x-4); // y=(x-4)²
            //     for (int j = 0; j < y; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            //============================== Condiciones A ==================================//

            #region Ejer_27 - Calculadora básica usando if

            // Console.WriteLine("valor 1");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("operacion");
            // string operacion = Console.ReadLine();
            // Console.WriteLine("valor 2");
            // int b = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine( a +"  "+ b +"  "+operacion);
            // if (operacion == "x")
            // {
            //     Console.WriteLine("{0} * {1} = {2}",a,b,a*b);
            // }else if (operacion == "/")
            // {
            //     Console.WriteLine("{0} / {1} = {2}",a,b,a/b);
            // }else if (operacion == "-")
            // {
            //     Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
            // }else if (operacion == "+")
            // {
            //     Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
            // }
            // else
            // {
            //     Console.WriteLine("no Se Reconoce la operacion seleccionada.");
            // }

            #endregion

            #region Ejer_28 - Calculadora básica usando switch

            //https://www.exercisescsharp.com/es/condiciones-a/calculadora-basica-usando-switch

            // Console.WriteLine("valor 1");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("operacion");
            // char operacion = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine("valor 2");
            // int b = Convert.ToInt32(Console.ReadLine());
            //
            // switch (operacion)
            // {
            //     case 'x': Console.WriteLine("{0} x {1} = {2}",a,b,a*b); break;
            //     case '/': Console.WriteLine("{0} / {1} = {2}",a,b,a/b); break;
            //     case '+': Console.WriteLine("{0} + {1} = {2}",a,b,a+b); break;
            //     case '-': Console.WriteLine("{0} - {1} = {2}",a,b,a-b); break;
            //     default: Console.WriteLine("No se reconoce la operacion"); break;
            // }

            #endregion

            #region Ejer_29 - Positivo y Negativo

            // Console.WriteLine("Ingrese Numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            //
            // if (x >= 0)
            // {
            //     Console.WriteLine("Positivo");
            // }
            // else
            // {
            //     Console.WriteLine("Negativo");
            // }

            #endregion

            #region Ejer_30 - El mayor de tres números

            //https://www.exercisescsharp.com/es/condiciones-a/mayor-de-tres-numeros

            // Console.WriteLine("1er Numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("2do Numero");
            // int y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("3er Numero");
            // int z = Convert.ToInt32(Console.ReadLine());
            //
            // if (x>y && x>z)
            // {
            //     Console.WriteLine(x);
            // }
            // else if (y>x && y >z)
            // {
            //     Console.WriteLine(y);   
            // }else if (z>x && z>y)
            // {
            //     Console.WriteLine(z);
            // }

            #endregion

            #region Ejer_31 - Usando la instrucción while

            //https://www.exercisescsharp.com/es/condiciones-a/usando-la-instruccion-while

            // int num = 1;

            // while (num != 0)
            // {
            //     Console.WriteLine("Ingrese numero");
            //     num = Convert.ToInt32(Console.ReadLine());
            //     if (num!=0)
            //     {
            //         Console.WriteLine("{0}", num*10);
            //     }
            // }

            #endregion

            #region Ejer_32 - Usando la instrucción do-while

            //https://www.exercisescsharp.com/es/condiciones-a/usando-instruccion-do-while

            // int n;
            // do
            // {
            //     Console.WriteLine("ingrese numero");
            //     n = Convert.ToInt32(Console.ReadLine());
            //     if (n != 0)
            //     {
            //         Console.WriteLine("{0}",n*10);
            //     }
            // } while (n != 0);

            #endregion

            #region Ejer_33 - Rango de números

            //https://www.exercisescsharp.com/es/condiciones-a/rango-de-numeros

            // Console.WriteLine("Ingrese origen x");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese destino y");
            // int y = Convert.ToInt32(Console.ReadLine());
            //
            // //solucion a
            // while (x<=y)
            // {
            //     Console.WriteLine(x);
            //     x++;
            // }
            // //solucion b
            // for (int i = x; i <= y; i++)
            // {
            //     Console.Write("{0} ", i);
            // }

            #endregion

            #region Ejer_34 - Suma de números infinita

            //https://www.exercisescsharp.com/es/condiciones-a/suma-numeros-infinita

            // int cont = 0;
            // int x = 1;
            //
            // do
            // {
            //     Console.WriteLine("Ingrese numero a sumar");
            //     x = Convert.ToInt32(Console.ReadLine());
            //     if (x!=0)
            //     {
            //         cont += x;
            //         Console.WriteLine("suma = {0}" ,cont);
            //     }
            // } while (x !=0);
            //
            // Console.WriteLine("terminado");

            #endregion

            #region Ejer_35 - Estadísticas matemáticas

            //https://www.exercisescsharp.com/es/condiciones-a/estadisticas-matematicas

            //mi respuesta
            // int max = Int32.MinValue;
            // int min = Int32.MaxValue;
            // int sum = 0;
            // int avg = 0;
            //
            // Console.WriteLine("ingrese valor 1");
            // int x1 = Convert.ToInt32(Console.ReadLine());
            // if (x1 > max)
            //     max = x1;
            // if (x1 < min)
            //     min = x1;
            // Console.WriteLine("ingrese valor 2");
            // int x2 = Convert.ToInt32(Console.ReadLine());
            // if (x2 > max)
            //     max = x2;
            // if (x2 < min)
            //     min = x2;
            // Console.WriteLine("ingrese valor 3");
            // int x3 = Convert.ToInt32(Console.ReadLine());
            // if (x3 > max)
            //     max = x3;
            // if (x3 < min)
            //     min = x3;
            // Console.WriteLine("ingrese valor 4");
            // int x4 = Convert.ToInt32(Console.ReadLine());
            // if (x4 > max)
            //     max = x4;
            // if (x4 < min)
            //     min = x4;
            // Console.WriteLine("ingrese valor 5");
            // int x5 = Convert.ToInt32(Console.ReadLine());
            // if (x5 > max)
            //     max = x5;
            // if (x5 < min)
            //     min = x5;
            //
            // sum = x1 + x2 + x3 + x4 + x5;
            // avg = sum / 5;
            //
            // Console.WriteLine("Suma: {0}", sum);
            // Console.WriteLine("Media: {0}", avg);
            // Console.WriteLine("Max: {0}", max);
            // Console.WriteLine("Min: {0}", min);
            //
            // //respuesta pagina
            // int total = 5;
            // int[] numeros = new int[total];
            //
            // for (int i = 0; i < total; i++) 
            // {
            //     numeros[i] = int.Parse(Console.ReadLine());
            // }
            //
            // int suma = 0,
            //     media = 0,
            //     max = int.MinValue,
            //     min = int.MaxValue;
            //
            // for (int i = 0; i < total; i++)
            // {
            //     int num = numeros[i];
            //
            //     suma += num;
            //
            //     if (num > max) 
            //     {
            //         max = num;
            //     }
            //
            //     if (num < min) 
            //     {
            //         min = num;
            //     }
            // }
            //
            // media = suma / total;
            //
            // Console.WriteLine("Suma: " + suma);
            // Console.WriteLine("Media: " + media);
            // Console.WriteLine("Max: " + max);
            // Console.WriteLine("Min: " + min);

            #endregion

            //============================== Condiciones B ==================================//

            #region Ejer_36 - Número repetido

            //https://www.exercisescsharp.com/es/condiciones-b/numero-repetido

            // Console.WriteLine("Ingrese Numero");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese total de veces a repetir");
            // int b = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 0; i < b; i++)
            // {
            //     Console.Write(a);
            // }

            #endregion

            #region Ejer_37 - Números múltiplos

            //https://www.exercisescsharp.com/es/condiciones-b/numeros-multiplos

            // for (int i = 0; i < 500; i++)
            // {
            //     if( i%3==0 && i%5==0)
            //         Console.Write("{0} ",i);
            // }

            #endregion

            #region Ejer_38 - Control de acceso

            //https://www.exercisescsharp.com/es/condiciones-b/control-de-acceso

            // int user, pass;
            // int intentos = 0;
            // bool load = false;
            //
            // do
            // { 
            //     Console.WriteLine("ingrese numero de usuario");
            //     user = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("ingrese contraseña numerica");
            //     pass = Convert.ToInt32(Console.ReadLine());
            //  
            //     if (user == 12 && pass == 1234)
            //         load = true;
            //     else
            //         Console.WriteLine("Error de Inicio de sesión");
            //     
            //     Console.WriteLine("-------------------------");
            //     intentos++;
            //     
            // } while (intentos<3 && !load);
            //
            // if(load)
            // {
            //     Console.WriteLine("Inicio de sesión");
            // }

            #endregion

            #region Ejer_39 - Divisiones infinitas

            //https://www.exercisescsharp.com/es/condiciones-b/divisiones-infinitas

            // int num1, num2;
            // do
            // {
            //     Console.WriteLine("ingrese Nro a dividir");
            //     num1 = Convert.ToInt32(Console.ReadLine());
            //     if (num1 != 0)
            //     {
            //         Console.WriteLine("ingrese divisor");
            //         num2 = Convert.ToInt32(Console.ReadLine());
            //         if (num2 == 0)
            //             Console.WriteLine("No se puede dividir por 0");
            //         else
            //         {
            //             Console.WriteLine("resultado de la division es: {0}", num1 / num2);
            //             Console.WriteLine("el resto es: {0}", num1 % num2);
            //         }
            //         Console.WriteLine("======================");
            //     }
            // } while (num1 != 0);
            //
            // Console.WriteLine("¡Adios!");

            #endregion

            #region Ejer_40 - Tablas de multiplicar infinitas

            // https://www.exercisescsharp.com/es/condiciones-b/tablas-de-multiplicar-infinitas

            // int num1, num2;
            //
            // Console.WriteLine("ingrese 1er numero");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese 2do numero");
            // num2 = Convert.ToInt32(Console.ReadLine());
            //
            // if (num2>num1)
            // {
            //     for (int i = num1; i <= num2; i++)
            //     {
            //         for (int j = 1; j <= 10; j++)
            //         {
            //             Console.WriteLine("{0} x {1} = {2}",i,j, i*j);
            //         }
            //
            //         Console.WriteLine();
            //     }
            // }

            #endregion

            #region Ejer_41 - Switch, break y default

            //https://www.exercisescsharp.com/es/condiciones-b/switch-break-y-default

            // Console.WriteLine("Ingrese Nota del alumno");
            // int nota = Convert.ToInt32(Console.ReadLine());
            // switch (nota)
            // {
            //     case 10:
            //         Console.WriteLine("Matrícula de honor");
            //         break;
            //     case 9:
            //         Console.WriteLine("Sobresaliente");
            //         break;
            //
            //     case 7:
            //     case 8:
            //         Console.WriteLine("Notable");
            //         break;
            //
            //     case 6:
            //         Console.WriteLine("Bien");
            //         break;
            //     case 5:
            //         Console.WriteLine("Aprobado");
            //         break;
            //     default:
            //         Console.WriteLine("Suspenso");
            //         break;
            // }

            #endregion

            #region Ejer_42 - Estructuras repetitivas

            //https://www.exercisescsharp.com/es/condiciones-b/estructuras-repetitivas

            // Console.WriteLine("Ingrese 1er numero");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do numero");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // int aux1 = num1;
            //
            //
            // for (int i = num1; i <= num2; i++)
            // {
            //     Console.Write(i);
            // }
            //
            // Console.WriteLine();
            // while (num1<=num2)
            // {
            //     Console.Write(num1);
            //     num1++;
            // }
            //
            // Console.WriteLine();
            // do
            // {
            //     Console.Write(aux1);
            //     aux1++;
            // } while (aux1<=num2);

            #endregion

            #region Ejer_43 - Dígitos en un número

            //https://www.exercisescsharp.com/es/condiciones-b/digitos-en-un-numero

            // Console.WriteLine("ingrese numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int digitos = 0;
            //
            // if (x < 0)
            // {
            //     Console.WriteLine("(Advertencia: es un numero negativo)");
            //     x = -x;
            // }
            //
            // while (x > 0)
            // {
            //     x /= 10;
            //     digitos++;
            // }
            //
            // if (digitos == 0)
            // {
            //     digitos = 1;
            // }
            //
            // Console.WriteLine("{0} digitos", digitos);
            //

            #endregion

            //============================== Condiciones C ==================================//

            #region Ejer_44 - Abecedario de char

            //https://www.exercisescsharp.com/es/condiciones-iii/abecedario-de-char

            // for (char i = 'A'; i <= 'Z'; i++)
            // {
            //     Console.Write("{0} ",i);
            // }

            #endregion

            #region Ejer_45 - ABS - Valor absoluto

            //https://www.exercisescsharp.com/es/condiciones-iii/abs-valor-absoluto

            // Console.WriteLine("Ingrese Numero");
            // int num = Convert.ToInt32(Console.ReadLine());
            //
            // if (num < 0)
            // {
            //     num = -num;
            // }
            //
            // Console.WriteLine("El valor absoluto es {0}", num);

            #endregion

            #region Ejer_46 - Producto de un número

            //https://www.exercisescsharp.com/es/condiciones-iii/producto-de-numero

            // Console.WriteLine("ingrese 1er numero");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese 2do numero");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            //
            // int result = 0;
            // for (int i = 0; i < n2; i++)
            // {
            //     result += n1;
            // }
            //
            // Console.WriteLine("{0} x {1} = {2}",n1,n2,result);

            #endregion

            #region Ejer_47 - Número primo

            //https://www.exercisescsharp.com/es/condiciones-iii/numero-primo

            // Console.WriteLine("ingrese numero");
            // int n = Convert.ToInt32(Console.ReadLine());
            //
            // if(n%2 != 0)
            //     Console.WriteLine("Es primo");
            // else
            //     Console.WriteLine("Es par");

            #endregion

            #region Ejer_48 - Números impares en descendente

            //https://www.exercisescsharp.com/es/condiciones-iii/numeros-impares-descendentes

            // Console.WriteLine("ingrese 1er valor");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese 2do valor");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = n1; i >= n2; i--)
            // {
            //     if (i%2 != 0)
            //     {
            //         Console.Write("{0} ",i);
            //     }
            // }

            #endregion

            #region Ejer_49 - Devolver el cambio

            //https://www.exercisescsharp.com/es/condiciones-iii/devolver-el-cambio

            // Console.WriteLine("Ingrese total caja");
            // int caja = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese costo compra");
            // int total = Convert.ToInt32(Console.ReadLine());
            //
            // int cambio = caja - total;
            //
            // while (cambio>=50)
            // {
            //     Console.Write("50 ");
            //     cambio -= 50;
            // }
            // while (cambio>=20)
            // {
            //     Console.Write("20 ");
            //     cambio -= 20;
            // }
            // while (cambio>=10)
            // {
            //     Console.Write("10 ");
            //     cambio -= 10;
            // }
            // while (cambio>=5)
            // {
            //     Console.Write("5 ");
            //     cambio -= 5;
            // }
            // while (cambio>=2)
            // {
            //     Console.Write("2 ");
            //     cambio -= 2;
            // }
            //
            // while (cambio>=1)
            // {
            //     Console.Write("1 ");
            //     cambio -= 1;
            // }

            #endregion

            #region Ejer_50 - Operador condicional - "(?)"

            //https://www.exercisescsharp.com/es/condiciones-iii/operador-condicional

            // Console.WriteLine("ingrese 1er numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese 2er numero");
            // int y = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine(x > 0 ? "A es positivo" : "A no es positivo");
            // Console.WriteLine(y > 0 ? "B es positivo" : "B no es positivo");
            // Console.WriteLine((x > 0) && (y > 0) ? "Ambos son positivos" : "Ambos no son positivos");

            #endregion

            #region Ejer_51 - Operador condicional anidada

            //https://www.exercisescsharp.com/es/condiciones-iii/operador-condicional-anidado

            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            //
            // int cantidad = ((a > 0) && (b > 0)) ? 2 : ((a > 0) || (b > 0)) ? 1 : 0;

            #endregion

            //==============================  Geometría B ==================================//

            #region Ejer_52 - Dibujar un cuadrado hueco

            // Console.WriteLine("ingrese numero con el cual pintar");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese numero alto-ancho");
            // int y = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 0; i <= y; i++) //filas
            // {
            //     for (int j = 0; j < y; j++) //columna
            //     {
            //         if (i > 0 && i < y)
            //         {
            //             Console.Write((j > 0 && j < y - 1) ? " " : x);
            //         }
            //         else
            //         {
            //             Console.Write(x);
            //         }
            //     }
            //
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_53 - Dibujar un rectángulo hueco

            //https://www.exercisescsharp.com/es/geometria-b/dibujar-rectangulo-hueco

            // Console.WriteLine("ingrese numero con el cual pintar");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese numero alto");
            // int y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese numero ancho");
            // int z = Convert.ToInt32(Console.ReadLine());
            //
            // for (int i = 0; i <= y; i++) //filas
            // {
            //     for (int j = 0; j < z; j++) //columna
            //     {
            //         if (i > 0 && i < y)
            //         {
            //             Console.Write((j > 0 && j < z - 1) ? " " : x);
            //         }
            //         else
            //         {
            //             Console.Write(x);
            //         }
            //     }
            //
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_54 - Dibujar un paralelogramo

            //https://www.exercisescsharp.com/es/geometria-b/dibujar-paralelogramo

            // Console.WriteLine("ingrese numero alto");
            // int y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese numero ancho");
            // int z = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese numero con el cual pintar");
            // string x = Console.ReadLine();
            //
            // for (int i = 0; i < y; i++)
            // {
            //     for (int j = 0; j < i; j++)
            //     {
            //         Console.Write(" ");
            //     }
            //
            //     for (int j = 0; j < z; j++)
            //     {
            //         Console.Write(x);
            //     }
            //
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_55 - Dibujar una pirámide

            //https://www.exercisescsharp.com/es/geometria-b/dibujar-piramide

            // Console.WriteLine("ingrese palabra");
            // string p = Console.ReadLine();
            //
            // int a = p.Length/2;
            // int b = 1;
            //
            // //si el tamaño de la palabra es impar le agrego un espacio al final
            // if (p.Length % 2 != 0)
            // {
            //     p += " ";
            // }
            //
            //
            // //imprimir la palabra de a pedacitos
            // for (int i = 1; i < p.Length + 1 / 2; i++)
            // {
            //     int x = 0;
            //     while (x<a)
            //     {
            //         Console.Write(" ");
            //         x++;
            //     }
            //
            //     if (a + b < p.Length)
            //     {
            //         Console.WriteLine(p.Substring(a, b));
            //         a--;
            //         b += 2;
            //     }
            // }

            #endregion

            //============================= Tipos de datos B ================================//

            #region Ejer_56 - Comprobar vocales con switch

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/comprobar-vocales-con-switch
            //
            // Console.WriteLine("Ingrese una Letra");
            // char l = Convert.ToChar(Console.ReadLine());
            // //ToLower();
            //
            // switch (l)
            // {
            //     case 'a': 
            //     case 'e': 
            //     case 'i': 
            //     case 'o': 
            //     case 'u': Console.WriteLine("Vocal");
            //         break;
            //     default: Console.WriteLine("Otro simbolo");
            //         break;
            // }

            #endregion

            #region Ejer_57 - Comprobar números con excepciones

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/comprobar-numeros-con-excepciones

            // Console.WriteLine("Ingrese text");
            // try
            // {
            //     int l = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Es un Numero");
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("No es un numero");
            // }

            #endregion

            #region Ejer_58 - Boolean y operador condicional

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/boolean-y-operador-condicional
            // Console.WriteLine("ingrese 1er valor");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingrese 2do valor");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            //
            // //respuesta 2
            // bool ambos = ((n1 + n2) % 2 == 0 ? true : false);
            // Console.WriteLine(ambos);

            #endregion

            #region Ejer_59 - Producto de factores primos

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/producto-de-factores-primos

            // Console.WriteLine("Ingrese numero");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int divisor = 2;
            //
            // while (x > 1)
            // {
            //     while (x % 2 == 0)
            //     {
            //         Console.Write(2 + "x");
            //         x = x / 2;
            //     }
            //     divisor++;
            // }
            // Console.Write(1);

            #endregion

            #region Ejer_60 - Convertir número a Binario y Hexadecimal

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/convertir-numero-a-binario-y-hexadecimal

            // int n;
            // do
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     n = Convert.ToInt32(Console.ReadLine());
            //     if (n!=0)
            //     {
            //         Console.WriteLine("Hexadecimal: {0}",Convert.ToString(n,16));//Hexadecimal
            //         Console.WriteLine("Binario: {0}",Convert.ToString(n,2));//Binario
            //     }
            // } while (n!=0);

            #endregion

            #region Ejer_61 - Tabla hexadecimal del 0 al 255

            //https://www.exercisescsharp.com/es/tipos-de-datos-b/tabla-hexadecimal-del-0-al-255
            // int x = 0;
            // for (int i = 0; i < 16; i++)
            // {
            //     for (int j = 0; j < 16; j++)
            //     {
            //         string value = Convert.ToString(x, 16);
            //         Console.Write(value.Length==1 ? "0"+value+" " : value+" ");
            //         x++;
            //     }
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_62 - struct

            /*
             * Documentacion:
             * https://www.tutorialsteacher.com/csharp/csharp-struct
             */
            
            //https://www.exercisescsharp.com/es/tipos-de-datos-b/struct

            // Console.WriteLine("Ingrese nombre");
            // string name = Console.ReadLine();
            // Console.WriteLine("Ingrese edad");
            // int edad = Convert.ToInt32(Console.ReadLine());
            //
            // Person p = new Person(name,edad);
            //
            // Console.WriteLine("¡Hola {0}!", p.Nombre);

            #endregion

            //================================ Matrices =====================================//

            #region Ejer_63 - Matriz en orden inverso - Array.Reverse

            //https://www.exercisescsharp.com/es/matrices/matriz-orden-inverso
            // int[] arr = new int [5];
            //
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Array.Reverse(arr);
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write("{0} ",arr[i]);
            // }

            #endregion

            #region Ejer_64 - Buscar en una matriz de enteros

            //https://www.exercisescsharp.com/es/matrices/buscar-matriz-de-enteros
            //
            // Console.WriteLine("Ingrese tamaño del arreglo");
            // int tam = Convert.ToInt32(Console.ReadLine());
            //
            // int[] arr = new int[tam];
            // for (int i = 0; i < tam; i++)
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //
            // Console.WriteLine("---------------------");
            // string n = "";//inicializo string
            //
            // do
            // {
            //     Console.WriteLine("Numero a Buscar");
            //     n = Console.ReadLine();
            //     int nToInt = Convert.ToInt32(n);
            //
            //     //devuelve el indice si encuantra el numero agregado dentro del arreglo
            //     if (Array.BinarySearch(arr,nToInt) >= 0)
            //     {
            //         Console.WriteLine("¡El Numero {0} Existe!", n);
            //     }
            //     else
            //     {
            //         Console.WriteLine("¡El Numero {0} No Existe!", n);
            //     }
            //
            // } while (n != "fin");

            #endregion

            #region Ejer_65 - Buscar números pares

            //https://www.exercisescsharp.com/es/matrices/buscar-numeros-pares
            // int total = 10;
            // int[] arr = new int[total];
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine("Agrege Numero");
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //
            // for (int i = 0; i < total; i++)
            // {
            //     if (arr[i]%2 ==0)
            //     {
            //         Console.Write("{0} ",arr[i]);
            //     }
            // }

            #endregion

            #region Ejer_66 - Buscar números positivos y negativos

            //https://www.exercisescsharp.com/es/matrices/buscar-numeros-positivos-negativos
            // int total = 10;
            // int[] arr = new int [total];
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine("Agregar Numero");
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.WriteLine("---------------------------");
            //
            // int sumPositivos = 0, cantPositivos = 0;
            // int sumNegativos = 0, cantNegativos = 0;
            //
            // for (int i = 0; i < total; i++)
            // {
            //     if (arr[i] >= 0)
            //     {
            //         sumPositivos += arr[i];
            //         cantPositivos++;
            //     }
            //     else
            //     {
            //         sumNegativos += arr[i];
            //         cantNegativos++;
            //     }
            // }
            //
            // Console.WriteLine( cantNegativos!=0 ? "La media de Numeros Negativos es: " + sumNegativos /cantNegativos : "no hay Numeros Negativos");
            // Console.WriteLine( cantPositivos!=0 ? "La media de Numeros Positivos es: " + sumPositivos /cantPositivos : "no hay Numeros Negativos");

            #endregion

            //TODO investigar funcionamiento de Banner y como replicarlo

            #region Ejer_67 - Comando Banner en Unix

            //https://www.exercisescsharp.com/es/matrices/comando-banner-en-unix


            #endregion

            #region Ejer_68 - Ordenamiento de burbuja

            //https://www.exercisescsharp.com/es/matrices/ordenamiento-de-burbuja

            // int total = 10;
            // int[] arr = new int[total];
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine("Agregar Numero");
            //     arr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //
            // for (int x = 0; x < total; x++)
            // {
            //     //   -1 es para no  llegar al final del arreglo
            //     for (int indiceActual = 0; indiceActual < total - 1; indiceActual++)
            //     {
            //         int indiceSiguienteElemento = indiceActual + 1;
            //         // Si el actual es mayor que el que le sigue a la derecha...
            //         if (arr[indiceActual] > arr[indiceSiguienteElemento])
            //         {
            //             int temporal = arr[indiceActual];
            //             arr[indiceActual] = arr[indiceSiguienteElemento];
            //             arr[indiceSiguienteElemento] = temporal;
            //         }
            //     }
            // }
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.Write("{0} ",arr[i]);
            // }

            #endregion

            #region Ejer_69 - Matriz bidimensional

            //https://www.exercisescsharp.com/es/matrices/matriz-bidimensional
            // int totalGrupo = 10;
            // float[,] matiz = new float[totalGrupo,totalGrupo];
            //
            // for (int i = 0; i < 2; i++) //fila
            // {
            //     for (int j = 0; j < totalGrupo; j++)//columnas
            //     {
            //         Console.WriteLine("Ingrese Numero");
            //         matiz[i,j] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            //
            // float sumaNotas = 0;
            // for (int i = 0; i < 2; i++)
            // {
            //     for (int j = 0; j < totalGrupo; j++)
            //     {
            //         sumaNotas += matiz[i, j];
            //     }
            //     Console.WriteLine("Promedio del Grupo {0}° : {1}",i+1,sumaNotas/totalGrupo);
            // }

            #endregion

            #region Ejer_70 - Matriz bidimensional de caracteres

            //https://www.exercisescsharp.com/es/matrices/matriz-bidimensional-de-caracteres
            // char[,] matriz = new char[20, 70];
            //
            // for (int i = 0; i < 20; i++)
            // {
            //     for (int j = 0; j < 70; j++)
            //     {
            //         matriz[i, j] = 'x';
            //     }
            // }
            //
            // for (int i = 0; i < 20; i++)
            // {
            //     for (int j = 0; j < 70; j++)
            //     {
            //         Console.Write(matriz[i, j]);
            //     }
            //
            //     Console.WriteLine();
            // }

            #endregion

            #region Ejer_71 - Matriz de struct

            //https://www.exercisescsharp.com/es/matrices/matriz-de-struct
            // Cars[] arr = new Cars[3];
            //
            // Cars auto = new Cars();
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Modelo del Auto");
            //     auto.Modelo = Console.ReadLine();
            //     Console.WriteLine("Anio De Fabricacion");
            //     auto.AnioFabricacion = Convert.ToInt32(Console.ReadLine());
            //     arr[i] = auto;
            // }
            //
            // for (int i = 0; i < 3 - 1; i++)
            // {
            //     for (int j = i + 1; j < 3; j++)
            //     {
            //         if (arr[i].AnioFabricacion > arr[j].AnioFabricacion)
            //         {
            //             var aux = arr[i];
            //
            //             arr[i] = arr[j];
            //             arr[j] = aux;
            //         }
            //     }
            // }
            //
            // for (int i = 0; i < 3; i++)
            // {
            //     arr[i].Imprimir();
            // }

            #endregion

            #region Ejer_71 - Estadísticas matemáticas

            //https://www.exercisescsharp.com/es/matrices/estadisticas-matematicas
            // int total = 1000; //total de numeros permitidos
            // int contador = 0; //pos de nemeros agregados
            // int[] numeros = new int[total];
            //
            // int maxNumber = int.MinValue;
            // int minNumber = int.MaxValue;
            // int suma = 0;
            //
            // int n = 0; //variable aux para ingrese de numeros
            // int x = 0; //variable para el menu
            //
            // do
            // {
            //     Console.WriteLine("Menu:");
            //     Console.WriteLine("1. Añadir");
            //     Console.WriteLine("2. Ver");
            //     Console.WriteLine("3. Buscar");
            //     Console.WriteLine("4. Estadísticas");
            //     Console.WriteLine("5. Salir");
            //     Console.WriteLine("Introduzca una opción (1-5):");
            //
            //     try
            //     {
            //         x = Convert.ToInt32(Console.ReadLine());
            //     }
            //     catch (FormatException)
            //     {
            //         Console.WriteLine("No es un Numero");
            //     }
            //     catch (OverflowException)
            //     {
            //         Console.WriteLine("El Numero supera el tamaño permitido");
            //     }
            //
            //     switch (x)
            //     {
            //         case 1:
            //             Console.WriteLine("Ingrese numero para agregar");
            //             n = Convert.ToInt32(Console.ReadLine());
            //
            //             if (contador <= total)
            //             {
            //                 if (n > maxNumber)
            //                     maxNumber = n;
            //                 else if (n < minNumber) minNumber = n;
            //
            //                 numeros[contador] = n;
            //                 suma += n;
            //                 contador++;
            //             }
            //             else
            //             {
            //                 Console.WriteLine("No se Pueden ingresar mas numeros");
            //             }
            //
            //             break;
            //
            //         case 2:
            //             if (contador > 0)
            //             {
            //                 for (int i = 0; i < contador; i++)
            //                 {
            //                     Console.Write("{0} ", numeros[i]);
            //                 }
            //
            //                 Console.WriteLine();
            //             }
            //
            //             break;
            //
            //         case 3:
            //             Console.WriteLine("Ingrese numero a buscar");
            //             n = Convert.ToInt32(Console.ReadLine());
            //             bool search = false;
            //             
            //             for (int i = 0; i < contador; i++)
            //             {
            //                 if (numeros[i] == n)
            //                 {
            //                     search = true;
            //                 }
            //             }
            //             Console.WriteLine(search ? "Numero Encontrado": "Numero No Encontrado");
            //             
            //             break;
            //             
            //
            //         case 4:
            //             Console.WriteLine("Total de Numeros Agregados: {0}",contador);
            //             Console.WriteLine("Suma Total de Valores: {0}",suma);
            //             Console.WriteLine("Media aritmética: {0}", suma/contador);
            //             Console.WriteLine("Valor Maximo: {0}", maxNumber);
            //             Console.WriteLine("Valor Minimo: {0}",minNumber);
            //             break;
            //     }
            //
            //     Console.WriteLine("===============================");
            // } while (x != 5);

            #endregion

            #region Ejer_72 - Circunferencia en pantalla

            //https://www.exercisescsharp.com/es/matrices/circunferencia-en-pantalla

            /*
             * Documentacion:
             * https://docs.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?view=net-6.0
             */
            
            // double x, y;
            // double radio;
            //
            // for (int i = 0; i < 360; i += 5)
            // {
            //     radio = i * Math.PI / 180.0;
            //
            //     x = 35 + 8 * Math.Cos(radio);
            //     y = 10 + 8 * Math.Sin(radio);
            //
            //     Console.SetCursorPosition((int)x, (int)y);
            //     Console.Write("X");
            // }
            //
            // Console.SetCursorPosition(1, 20);


            #endregion

            //================================ Funciones A =====================================//

            #region Ejer_73 - Función saludo y despedida

            // https://www.exercisescsharp.com/es/funciones-a/funcion-saludo-despedida
            // Saludar();
            // Despedirse();

            #endregion

            #region Ejer_74 - Función con parámetros

            //https://www.exercisescsharp.com/es/funciones-a/funcion-con-parametros
            // Console.WriteLine("Ingrese un Nombre");
            // string name = Console.ReadLine();
            // Saludar(name);

            #endregion

            #region Ejer_75 - Función que retorna valor

            //https://www.exercisescsharp.com/es/funciones-a/funcion-que-retorna-valor
            // Console.WriteLine("Ingrese 1er Valor");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do Valor");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Resultado Suma: {0}", Sumar(n1, n2));

            #endregion

            #region Ejer_76 - Función contar espacios de un texto

            //https://www.exercisescsharp.com/es/funciones-a/funcion-contar-espacios-de-texto
            // Console.WriteLine("Ingrese texto");
            // string s = Console.ReadLine();
            // Console.WriteLine("El total de espacios en blancos es: {0}", ContarEspacios(s));

            #endregion

            #region Ejer_77 - Función escribir texto con formato

            //https://www.exercisescsharp.com/es/funciones-a/funcion-escribir-texto-formato
            // Console.WriteLine("Ingrese Texto");
            // string s = Console.ReadLine();
            // EscribirCentradoSubrayado(s);

            #endregion

            #region Ejer_78 - Función sumar una matriz de enteros

            //https://www.exercisescsharp.com/es/funciones-a/funcion-sumar-matriz-enteros
            // int total = 5;
            // int count = 0;
            // int[] arr = new int[total];
            //
            // while (count < 5)
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     arr[count] = Convert.ToInt32(Console.ReadLine());
            //     count++;
            // }
            //
            // Console.WriteLine("Resultado de la Suma: {0}",Sumar(arr));

            #endregion

            #region Ejer_79 - Función calcular el doble de un número

            //https://www.exercisescsharp.com/es/funciones-a/funcion-calcular-doble-número
            // Console.WriteLine("Ingrese Un Numero");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("El Doble es: {0}", Doble(n));

            #endregion

            #region Ejer_80 - Función con parámetros por referencia

            //https://www.exercisescsharp.com/es/funciones-a/funcion-parametros-referencia
            // Console.WriteLine("Ingrese Numero");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int origin = n;
            // DobleReferencia(ref n);
            // Console.WriteLine("Valor Original: {0}, valor editado por referencia: {1}",origin,n);

            #endregion

            #region Ejer_81 - Intercambiar parámetros por referencia

            //https://www.exercisescsharp.com/es/funciones-a/intercambiar-parametros-referencia
            // Console.WriteLine("Ingrese 1er Numero");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do Numero");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // Swap(ref n1,ref n2);
            // Console.WriteLine("Numero Invertidos: 1er = {0}, 2do = {1}",n1,n2);

            #endregion

            //================================ Funciones B =====================================//

            #region Ejer_82 - Función para modificar un caracter de un texto

            //https://www.exercisescsharp.com/es/funciones-b/funcion-modificar-caracter-de-texto

            // Console.WriteLine("Ingrese Palabra");
            // string palabra = Console.ReadLine();
            // Console.WriteLine("Ingrese Posicion que desea editar");
            // int pos = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese Letra que colocar");
            // char letra = Convert.ToChar(Console.ReadLine());
            // Console.WriteLine();
            // CambiarLetra(ref palabra, pos, letra);
            // Console.WriteLine(palabra);

            #endregion

            #region Ejer_83 - Función para sumar los dígitos de un número

            //https://www.exercisescsharp.com/es/funciones-b/funcion-sumar-digitos-de-numero
            // Console.WriteLine("Ingrese cadena de Numero");
            // string cadena = Console.ReadLine();
            // Console.WriteLine("Resultado de la Suma es: {0}", SumarDigitos(cadena));

            #endregion

            #region Ejer_84 - Función para mostrar una cadena invertida

            //https://www.exercisescsharp.com/es/funciones-b/funcion-mostrar-cadena-invertida
            // Console.WriteLine("Ingrese Cadena de texto");
            // string cadena = Console.ReadLine();
            // InvertirCadena(cadena);

            #endregion

            #region Ejer_85 - Buscar el mayor valor en una matriz

            //https://www.exercisescsharp.com/es/funciones-b/funcion-buscar-mayor-valor-en-matriz
            // int total = 5;
            // int count = 0;
            // int[] numbers = new int[5];
            // while (count<total)
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     numbers[count] = Convert.ToInt32(Console.ReadLine());
            //     count++;
            // }
            //
            // Console.WriteLine("El Mayo de los Numeros Ingresados es: {0}",BuscarMayorValor(numbers));

            #endregion

            #region Ejer_86 - Función para calcular la potencia de un número

            //https://www.exercisescsharp.com/es/funciones-b/funcion-calcular-potencia-de-número
            // Console.WriteLine("Ingrese numero");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese potencia");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("El Resultado de {0} potencia de {1} es: {2}",n1,n2, Potencia(n1,n2));

            #endregion

            #region Ejer_87 - Función para escribir texto con formato título

            //https://www.exercisescsharp.com/es/funciones-b/funcion-escribir-texto-formato-titulo
            // Console.WriteLine("Ingrese Texto");
            // string s = Console.ReadLine();
            // EscribirTitulo(s);

            #endregion

            //================================ Funciones C =====================================//

            #region Ejer_88 - Función para comprobar si un texto es alfabético

            //https://www.exercisescsharp.com/es/funciones-c/funcion-comprobar-texto-alfabetico
            // Console.WriteLine("Ingrese Texto");
            // string text = Console.ReadLine();
            // Console.WriteLine("Es Alfabetico: {0}",EsAlfabetico(text));

            #endregion

            #region Ejer_89 - Función para comprobar si un texto es número

            //https://www.exercisescsharp.com/es/funciones-c/funcion-comprobar-texto-es-numero

            // Console.WriteLine("Ingrese Texto");
            // string text = Console.ReadLine();
            // Console.WriteLine("Es Numerico: {0}",EsNumerico(text));

            #endregion

            #region Ejer_90 - Calculadora con parámetros de Main

            //---------------------------------------------------//
            // int num1 = Convert.ToInt32(args[0]);
            // char oper = Convert.ToChar(args[1]);
            // int num2 = Convert.ToInt32(args[2]);
            //
            // switch (oper)
            // {
            //     case '+':
            //         Console.WriteLine(num1 + num2);
            //         break;
            //     case '-':
            //         Console.WriteLine(num1 - num2);
            //         break;
            //     case 'x':
            //     case 'X':
            //     case '*':
            //         Console.WriteLine(num1 * num2);
            //         break;
            //     case '/':
            //         Console.WriteLine(num1 / num2);
            //         break;
            // }
            //---------------------------------------------------//

            // Console.WriteLine("Ingrese 1er Valor");
            // float n1 = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Ingrese 2do Valor");
            // float n2 = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Ingrese Operacion");
            // string operacion =Console.ReadLine();
            //
            // Calculadora(n1,n2,operacion);

            #endregion

            #region Ejer_90 - Retornar valor desde Main

            //https://www.exercisescsharp.com/es/funciones-c/retornar-valor-desde-main

            //Console.WriteLine(CalculadoraInfo(args));

            #endregion

            #region Ejer_91 - Buscar el mínimo y máximo en un array

            //https://www.exercisescsharp.com/es/funciones-c/buscar-minimo-y-maximo-en-array

            // int total = 5;
            // int max = int.MinValue;
            // int min = int.MaxValue;
            // int[] arr = new int[total];
            // int count = 0;
            //
            // do
            // {
            //     Console.WriteLine("Ingrese Numero");
            //     arr[count] = Convert.ToInt32(Console.ReadLine());
            //     count++;
            // } while (count < total);
            //
            // BuscarMinMax(ref max, ref min, arr);
            // Console.WriteLine("El valor maximo agregados es: {0}, el valor minimo es: {1}",max,min);

            #endregion

            #region Ejer_92 - Función para comprobar palíndromo

            //https://www.exercisescsharp.com/es/funciones-c/funcion-comprobar-palindromo

            // Console.WriteLine("Ingrese palabra");
            // string cadena = Console.ReadLine();
            // Console.WriteLine(Palindromo(cadena));

            #endregion

            //================================ Recursividad =====================================//

            #region Ejer_93 - Calcular una potencia de manera recursiva

            //https://www.exercisescsharp.com/es/recursividad/calcular-potencia-manera-recursiva
            // Console.WriteLine("Ingrese un Numero");
            // int numero = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese Un Exponente");
            // int exponente = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine(Potencia(numero, exponente));

            #endregion

            #region Ejer_94 - Crear una función recursiva para multiplicar

            //https://www.exercisescsharp.com/es/recursividad/crear-funcion-recursiva-multiplicar
            // Console.WriteLine("Ingrese Un Numero");
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero para multiplicarlo");
            // int n2 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine(MultiplicarRecursivo(n1,n2));

            #endregion

            #region Ejer_95 - Calcular números de la serie de Fibonacci

            //https://www.exercisescsharp.com/es/recursividad/calcular-numeros-serie-fibonacci

            // Console.WriteLine("Ingrese catidad de repeticiones");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("El resultado es: {0}",Fibonacci(n));

            #endregion

            #region Ejer_96 - Calcular el factorial de un número

            //https://www.exercisescsharp.com/es/recursividad/calcular-factorial-de-numero

            // Console.WriteLine("Ingrese un Numero");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(Factorial(n));

            #endregion

            #region Ejer_97 - Invertir una cadena de forma recursiva

            //https://www.exercisescsharp.com/es/recursividad/invertir-cadena-recursiva
            // Console.WriteLine("Ingrese Cadena De Texto");
            // string text = Console.ReadLine();
            // Console.WriteLine(InvertirRecursivo(text));

            #endregion

            #region Ejer_98 - Comprobar palíndromo de forma recursiva

            //https://www.exercisescsharp.com/es/recursividad/comprobar-palindromo-de-forma-recursiva

            // Console.WriteLine("ingrese in texto");
            // string text = Console.ReadLine();
            // Console.WriteLine("Es Palindromo: {0}",PolindromoRecursivo(text));
            //

            #endregion

            //================================ POO =====================================//

            #region Ejer_99 - Primera clase y método ToString()

            //https://www.exercisescsharp.com/es/poo/primera-clase-metodo-tostring
            // int total = 3;
            // Persona[] personas = new Persona[total];
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine("Ingrese un Nombre");
            //     personas[i] = new Persona()
            //     {
            //         Nombre = Console.ReadLine()
            //     };
            //
            // }
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine(personas[i]);
            // }

            #endregion

            #region Ejer_100 - Constructores y destructores

            // int total = 3;
            // Persona_Ejer_100[] personas = new Persona_Ejer_100[total];
            //
            // for (int i = 0; i < total; i++)
            // {
            //     personas[i] = new Persona_Ejer_100(Console.ReadLine());
            // }
            //
            // for (int i = 0; i < total; i++)
            // {
            //     Console.WriteLine(personas[i].ToString());
            // }

            #endregion

            #region Ejer_101 - Clase persona, estudiante y profesor

            //https://www.exercisescsharp.com/es/poo/clase-persona-estudiante-profesor

            // Console.WriteLine("Ingrese Nombre Persona");
            // string name = Console.ReadLine();
            // Console.WriteLine("Ingrese Edad");
            // int edadPerson = Convert.ToInt32(Console.ReadLine());
            //     
            // Console.WriteLine("Ingrese Nombre Estudiante");
            // string nameEstudent = Console.ReadLine();
            // Console.WriteLine("Ingrese Edad Estudiante");
            // int edadEstudent = Convert.ToInt32(Console.ReadLine());
            //     
            // Console.WriteLine("Ingrese Nombre Profesor");
            // string nameTeacher = Console.ReadLine();
            // Console.WriteLine("Ingrese Edad Profesor");
            // int edadTeacher = Convert.ToInt32(Console.ReadLine());
            //     
            // //----------------------------------------------------//
            // PersonaPadre p = new PersonaPadre(name, edadPerson);
            // p.Saludar();
            // //----------------------------------------------------//
            // Estudiante e = new Estudiante(nameEstudent, edadEstudent);
            // e.Saludar();
            // e.Estudiar();
            // e.VerEdad();
            // //----------------------------------------------------//
            // Profesor t = new Profesor(nameTeacher, edadTeacher);
            // t.Saludar();
            // t.Explicar();

            #endregion

            #region Ejer_102 - Clase álbum de fotos

            //https://www.exercisescsharp.com/es/poo/clase-album-de-fotos

            // AlbumFotos a1 = new AlbumFotos();
            // Console.WriteLine("Album constructor predeterminado");
            // Console.WriteLine(a1.GetNumerosDePaginas());
            // Console.WriteLine();
            // Console.WriteLine("Album constructor Especifico");
            // Console.WriteLine("ingrese tamaño");
            // int cant = Convert.ToInt32(Console.ReadLine());
            // AlbumFotos a2 = new AlbumFotos(cant);
            // Console.WriteLine(a2.GetNumerosDePaginas());
            // Console.WriteLine();
            // SuperAlbumFotos a3 = new SuperAlbumFotos();
            // Console.WriteLine("Super Album de fotos");
            // Console.WriteLine(a3.GetNumerosDePaginas());

            #endregion

            #region Ejer_103 - Herencia de objetos

            //https://www.exercisescsharp.com/es/poo/herencia-de-objetos

            // int total = 3;
            // PersonaEjer_103[] personas = new PersonaEjer_103[total];
            //
            // for (int i = 0; i < total; i++)
            // {
            //     if (i == 0)
            //     {
            //         Console.WriteLine("Ingrese Nombre");
            //         string name = Console.ReadLine();
            //         Console.WriteLine("ingrese edad");
            //         int edad = Convert.ToInt32(Console.ReadLine());
            //         personas[i] = new ProfesorEjer_103(name,edad);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Ingrese Nombre");
            //         string name = Console.ReadLine();
            //         Console.WriteLine("ingrese edad");
            //         int edad = Convert.ToInt32(Console.ReadLine());
            //         personas[i] = new EstudianteEjer_103(name,edad);
            //     }
            // }
            //
            // for (int i = 0; i < total; i++)
            // {
            //     if (i == 0)
            //     {
            //         ((ProfesorEjer_103)personas[i]).Explicar();
            //
            //     }
            //     else
            //     {
            //         ((EstudianteEjer_103)personas[i]).Estudiar();
            //     }
            // }

            #endregion

            #region Ejer_104 - Formas - Diagrama de clases

            //https://www.exercisescsharp.com/es/poo/formas-diagrama-de-clases

            #endregion

            #region Ejer_105 - Interfaces

            //https://www.exercisescsharp.com/es/poo/clases-abstractas   

            // Perro perro = new Perro();           
            //perro.SetNombre(Console.ReadLine()); 
            //Console.WriteLine(perro.GetNombre());
            //perro.Comer();

            #endregion
            
            //======================== Archivos de texto A ==========================// 

            #region Ejer_106 - Leer un archivo de texto - SteanReader
            
            //https://www.exercisescsharp.com/es/archivos-de-texto-a/leer-archivo-texto
            
            /*
             * Documentacion:
             * https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-6.0
             */
            
            // string linea;
            // string nombreArchivo = "input.txt";
            //
            // StreamReader sr = new StreamReader(nombreArchivo);
            // linea = sr.ReadLine();
            //
            // while (linea != null)
            // {
            //     Console.WriteLine(linea);
            //     linea = sr.ReadLine();
            // }
            // sr.Close();

            #endregion

            #region Ejer_107 - Leer un archivo de texto con using  - Using

            //https://www.exercisescsharp.com/es/archivos-de-texto-a/leer-archivo-texto-con-using
            
            /*
             * Documentacion:
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
             */
            
            // string linea;
            // string nombreArchivo = "input.txt";
            //
            // using (StreamReader sr = new StreamReader(nombreArchivo))
            // {
            //     linea = sr.ReadLine();
            //
            //     while (linea != null)
            //     {
            //         Console.WriteLine(linea);
            //         linea = sr.ReadLine();
            //     }
            // }

            #endregion

            #region Ejer_108 - Leer un archivo de texto con File - File

            //https://www.exercisescsharp.com/es/archivos-de-texto-a/leer-archivo-texto-con-file

            /*
             * Documentacion:
             * https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0
             */
            
            // string path = @"C:\Users\gabri\RiderProjects\CSharp-Excercises\input.txt";
            // //la ruta es donde se encuentra mi proyecto en Rider
            //
            //     string archivo = "input.txt";
            //     string textArchivo = File.ReadAllText(archivo);
            //     Console.WriteLine(textArchivo);
            //     Console.WriteLine();

            // if (!File.Exists(path)) Si no Existe lo crea
            // {
            //     // Create a file to write to.
            //     using (StreamWriter sw = File.CreateText(path))
            //     {
            //         sw.WriteLine("Hello");
            //         sw.WriteLine("And");
            //         sw.WriteLine("Welcome");
            //     }
            // }

            // if (File.Exists(path))
            // {
            //     using (StreamReader sr = File.OpenText(path))
            //     {
            //         string s;
            //         while ((s=sr.ReadLine()) != null)
            //         {
            //             Console.WriteLine(s);
            //         }
            //     }
            //
            //     File.OpenText(path);
            // }
            // else
            // {
            //     Console.WriteLine("Archivo No existe");
            // }

            #endregion

            #region Ejer_109 - Buscar lineas en un archivo de texto

            //https://www.exercisescsharp.com/es/archivos-de-texto-a/buscar-lineas-archivo-texto
            // string archivo = "input.txt";
            // string[] lineas = File.ReadAllLines(archivo);
            //
            // bool salir = false;
            // do
            // {
            //     Console.WriteLine("Ingrese palabra o frase");
            //     string texto = Console.ReadLine();
            //
            //     if (texto != "")
            //     {
            //         for (int i = 0; i < lineas.Length; i++)
            //         {
            //             if (lineas[i].Contains(texto))
            //             {
            //                 Console.WriteLine(lineas[i]);
            //             }
            //         }
            //     }
            //     else
            //     {
            //         salir = true;
            //     }
            // } while (!salir);

            #endregion

            #region Ejer_110 - Escribir en fichero de texto

            //https://www.exercisescsharp.com/es/archivos-de-texto-a/escribir-fichero-texto

            // string nombreArchivo = "out.txt";
            // using (StreamWriter archivo = File.CreateText(nombreArchivo))
            //     
            // {
            //     string linea;
            //     do
            //     {
            //         linea = Console.ReadLine();
            //
            //         if (linea.Length != 0)
            //         {
            //             archivo.WriteLine(linea);
            //         }
            //     }
            //     while (linea.Length != 0);
            // }

            #endregion

            #region Ejer_111 - Actualizar un archivo de texto

            //https://www.exercisescsharp.com/es/archivos-de-texto-a/actualizar-un-archivo-texto
            
            // string nombreArchivo = "out.txt";
            // using (StreamWriter archivo = File.AppendText(nombreArchivo))
            // {
            //     string linea;
            //     do
            //     {
            //         linea = Console.ReadLine();
            //
            //         if (linea.Length != 0)
            //         {
            //             archivo.WriteLine(linea);
            //         }
            //     }
            //     while (linea.Length != 0);
            // }

            #endregion
            
            //======================== Archivos de texto B ==========================// 

            #region Ejer_112 - Contar las palabras de un archivo

            //https://www.exercisescsharp.com/es/archivos-de-texto-b/contar-palabras-de-archivo
            
            //mi Solucion
            // string archivo = "input.txt";
            // string linea;
            // int contador = 0;
            // string[] lineas = File.ReadAllLines(archivo);
            //
            //  for (int i = 0; i < lineas.Length; i++)
            //  {
            //      contador += lineas[i].Split(' ').Length;
            //  }
            //
            //  Console.WriteLine("El total de palabras es {0}",contador);

             
             //solucion dada por la pagina
            // using (StreamReader texto = File.OpenText(archivo))
            // {
            //     do
            //     {
            //         linea = texto.ReadLine();
            //         if (linea != null)
            //         {
            //             contador += linea.Split(' ').Length;
            //         }
            //     } while (linea != null);
            // }
            //
            // Console.WriteLine(contador);
             #endregion

             #region Ejer_113 - Convertir el texto de un archivo a mayúsculas

             //https://www.exercisescsharp.com/es/archivos-de-texto-b/convertir-texto-archivo-mayusculas
             // string entrada = "input.txt";
             // string salida = "output.txt";
             //
             // string textoArchivo = File.ReadAllText(entrada);
             // textoArchivo = textoArchivo.ToUpper();
             //
             // File.WriteAllText(salida, textoArchivo);
             #endregion

             #region Ejer_114 - Cifrar un archivo de texto

             //https://www.exercisescsharp.com/es/archivos-de-texto-b/cifrar-archivo-texto
           
             // string entrada = "input.txt";
             // string salida = "output.txt";
             //
             // string textoArchivo = File.ReadAllText(entrada);
             //
             // string textoCifrado = string.Empty;
             // byte clave = 13;
             // foreach (char letra in textoArchivo)
             // {
             //     textoCifrado += (char)(letra + clave);
             // }
             //File.WriteAllText(salida, textoCifrado);
             
             #endregion

             #region Ejer_115 - Invertir texto de un archivo

             //https://www.exercisescsharp.com/es/archivos-de-texto-b/invertir-texto-de-archivo
             // string entrada = "input.txt";
             // string salida = "input.inv";
             //
             // string[] lineas = File.ReadAllLines(entrada);
             //
             // using (StreamWriter escritor = File.CreateText(salida))
             // {
             //     for (int i = lineas.Length - 1; i >= 0; i--)
             //     {
             //         escritor.WriteLine(lineas[i]);
             //     }
             // }

             #endregion

             #region Ejer_116 - Programa More

             //https://www.exercisescsharp.com/es/archivos-de-texto-b/programa-more
             // string nombreArchivo = "input.txt";
             //
             // using (StreamReader archivo = new StreamReader(nombreArchivo))
             // {
             //     string linea;
             //     int i = 0;
             //
             //     do
             //     {
             //         linea = archivo.ReadLine();
             //         if (linea != null)
             //         {
             //             if (i > 0 && i % 24 == 0)
             //             {
             //                 Console.WriteLine();
             //                 Console.WriteLine("Presione Enter para continuar...");
             //                 Console.ReadLine();
             //             }
             //
             //             if (linea.Length > 79)
             //             {
             //                 linea = linea.Substring(0, 79);
             //             }
             //
             //             Console.WriteLine(linea);
             //         }
             //         i++;
             //     }
             //     while (linea != null);
             // }
             

             #endregion
             
             //========================== Archivos binarios ============================//  
             
             //Ejercicios que analice su funcionamiento 

             #region Ejer_117 - Leer etiquetas ID3 v1 de archivo MP3

             //https://www.exercisescsharp.com/es/archivos-binarios/leer-etiquetas-id3-v1-de-archivo-mp3
             
             // const int TAMANYO = 128;
             // byte[] datos = new byte[TAMANYO];
             //
             // ID3v1Etiquetas tag = new ID3v1Etiquetas();
             //
             // // Leer datos archivo .mp3
             // string nombreArchivo = "input.mp3";
             // using (FileStream archivo = File.OpenRead(nombreArchivo))
             // {
             //     archivo.Seek(-128, SeekOrigin.End);
             //
             //     archivo.Read(tag.Id, 0, tag.Id.Length);
             //     archivo.Read(tag.Titulo, 0, tag.Titulo.Length);
             //     archivo.Read(tag.Artista, 0, tag.Artista.Length);
             //     archivo.Read(tag.Album, 0, tag.Album.Length);
             //     archivo.Read(tag.Anyo, 0, tag.Anyo.Length);
             //     archivo.Read(tag.Comentario, 0, tag.Comentario.Length);
             //     archivo.Read(tag.Genero, 0, tag.Genero.Length);
             // }
             //
             // if (tag.EsID3v1Etiqueta())
             // {
             //     Console.WriteLine(tag.ToString());
             // }

             #endregion

             #region Ejer_118 - Leer dimensiones de imagen BMP

             //https://www.exercisescsharp.com/es/archivos-binarios/leer-dimensiones-imagen-bmp
             
             // string nombreArchivo = "logo.bmp";
             // int tamanyo = 54, ancho, alto;
             // byte[] datos = new byte[tamanyo];
             //
             // using (FileStream archivo = File.OpenRead(nombreArchivo))
             // {
             //     archivo.Read(datos, 0, tamanyo);
             // }
             //
             // if (datos[0] != 'B' || datos[1] != 'M')
             // {
             //     return; // No es un archivo BMP
             // }
             //
             // ancho = datos[18] + (datos[19] * 256) +
             //         (datos[20] * 256 * 256) +
             //         (datos[21] * 256 * 256 * 256);
             //
             // alto = datos[22] + (datos[23] * 256) +
             //        (datos[24] * 256 * 256) +
             //        (datos[25] * 256 * 256 * 256);
             //
             // Console.WriteLine("{0}x{1}", ancho, alto);

             #endregion

             #region Ejer_118 - Cifrar una imagen BMP - FileStream

             //https://www.exercisescsharp.com/es/archivos-binarios/cifrar-imagen-bmp
             
             /*
              * Documentacion:
              * https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-6.0
              */
             
             // string nombreArchivo = "logo.bmp";
             //
             // using (FileStream archivo = File.Open(nombreArchivo, FileMode.Open, FileAccess.ReadWrite))
             // {
             //     char b1 = (char)archivo.ReadByte();
             //     char b2 = (char)archivo.ReadByte();
             //
             //     if (b1 != 'B' || b2 != 'M')
             //     {
             //         return; // No es un archivo BMP
             //     }
             //     else
             //     {
             //         archivo.Seek(0, SeekOrigin.Begin);
             //         archivo.WriteByte((byte)'M');
             //         archivo.WriteByte((byte)'B');
             //     }
             // }

             #endregion

             #region Ejer_120 - Archivo invertido

             //https://www.exercisescsharp.com/es/archivos-binarios/archivo-invertido
             
             // string entrada = "app.exe";
             // string salida = "app.inv";
             //
             // using (FileStream archivo = File.OpenRead(entrada))
             // {
             //     long tamanyo = archivo.Length;
             //     byte[] datos = new byte[tamanyo];
             //
             //     archivo.Read(datos, 0, (int)tamanyo);
             //
             //     using (FileStream archivoSalida = File.Create(salida))
             //     {
             //         for (long i = tamanyo - 1; i >= 0; i--)
             //         {
             //             archivoSalida.WriteByte(datos[i]);
             //         }
             //     }
             // }

             #endregion

             #region Ejer_121 - Copiador de archivos

             //https://www.exercisescsharp.com/es/archivos-binarios/copiador-archivos
             
             // const int TAMANYO_BUFFER = 512 * 1024;
             // byte[] datos = new byte[TAMANYO_BUFFER];
             //
             // string entrada = "app.exe";
             // string salida = "app-copy.exe";
             //
             // using (FileStream archivoEntrada = File.OpenRead(entrada))
             // {
             //     using (FileStream archivoSalida = File.Create(salida))
             //     {
             //         int totalLeido;
             //         do
             //         {
             //             totalLeido = archivoEntrada.Read(datos, 0, TAMANYO_BUFFER);
             //             archivoSalida.Write(datos, 0, totalLeido);
             //         }
             //         while (totalLeido == TAMANYO_BUFFER);
             //     }
             // }

             #endregion

             #region Ejer_122 - Dividir archivos

             //https://www.exercisescsharp.com/es/archivos-binarios/dividir-archivos
             // int TAMANYO_BUFFER = 5 * 1024;
             // byte[] datos = new byte[TAMANYO_BUFFER];
             //
             // int totalLeido;
             // int contador = 1;
             //
             // string nombreEntrada = "app";
             // string ext = ".exe";
             //
             // using (FileStream inputFile = File.OpenRead(nombreEntrada + ext))
             // {
             //     do
             //     {
             //         totalLeido = inputFile.Read(datos, 0, TAMANYO_BUFFER);
             //
             //         if (totalLeido > 0)
             //         {
             //             using (FileStream nuevoArchivo = File.Create(nombreEntrada + "-" + contador.ToString("00")))
             //             {
             //                 nuevoArchivo.Write(datos, 0, totalLeido);
             //                 contador++;
             //             }
             //         }
             //     }
             //     while (totalLeido == TAMANYO_BUFFER);
             // }

             #endregion

             #region Ejer_123 - Visor hexadecimal

            //https://www.exercisescsharp.com/es/archivos-binarios/visor-hexadecimal
             
             // const int TAMANYO_BUFFER = 16;
             //
             // string nombreArchivo = "app.exe";
             //
             // using (FileStream archivo = File.OpenRead(nombreArchivo))
             // {
             //     byte[] datos = new byte[TAMANYO_BUFFER];
             //
             //     int cantidad;
             //     int c = 0;
             //     string linea = string.Empty;
             //
             //     do
             //     {
             //         Console.Write(ToHex(archivo.Position, 8));
             //         Console.Write("  ");
             //
             //         cantidad = archivo.Read(datos, 0, TAMANYO_BUFFER);
             //
             //         for (int i = 0; i < cantidad; i++)
             //         {
             //             Console.Write(ToHex(datos[i], 2) + " ");
             //
             //             if (datos[i] < 32)
             //             {
             //                 linea += ".";
             //             }
             //             else
             //             {
             //                 linea += (char) datos[i];
             //             }
             //         }
             //
             //
             //         if (cantidad < TAMANYO_BUFFER)
             //         {
             //             for (int i = cantidad; i < TAMANYO_BUFFER; i++)
             //             {
             //                 Console.Write("   ");
             //             }
             //         }
             //
             //         Console.WriteLine(linea);
             //         linea = "";
             //
             //         c++;
             //         if (c == 24)
             //         {
             //             Console.ReadLine();
             //             c = 0;
             //         }
             //     } while (cantidad == TAMANYO_BUFFER);
             //
             // }
        
             #endregion
 
             //========================== Bases de datos SQLite ============================//

             #region Ejer_124 - Leer lista de bases de datos 
             
             //https://www.exercisescsharp.com/sqlite-databases/read-list-from-databases
             
             // Read();
             //
             // foreach (var person in Persons)
             // {
             //     Console.WriteLine(person.Name);
             //     Console.WriteLine(person.Age);
             // }
             
             #endregion
             
             #region Ejer_125 - Crear base de datos y tablas

             //https://www.exercisescsharp.com/sqlite-databases/read-list-from-databases
             
             // CrearBaseDatosSiNoExiste();
             // CrearTablasSiNoExisten();

             #endregion

             #region Ejer_126 - Crear base de datos en memoria

             //https://www.exercisescsharp.com/es/bases-datos-sqlite/crear-base-datos-en-memoria
             //
             // CrearTablas();

             #endregion

             #region Ejer_128 - Operaciones CRUD

             //https://www.exercisescsharp.com/es/bases-datos-sqlite/operaciones-crud
             
             // CrearBaseDatosSiNoExiste();
             // CrearTablasSiNoExistenCRUD();
             //
             // do
             // {
             //     VerMenu();
             //
             //     switch (OpcionMenu)
             //     {
             //         case 1: Agregar(); break;
             //         case 2: Ver(); break;
             //         case 3: Editar(); break;
             //         case 4: Eliminar(); break;
             //     }
             // } while (OpcionMenu != 5);
             
             #endregion
             
             //========================== Serialización de datos ============================//

             #region Ejer_129 - BinaryFormatter: Serialización binaria - BinaryFormatter

             /*
              * Documentacion
              * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=net-6.0
              */
             
             //https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter?view=net-6.0
             
             // Persona persona = new Persona()
             // {
             //     Nombre = "Nauj",
             //     Edad = 26,
             //     Ciudad = new Ciudad()
             //     {
             //         Nombre = "Spain",
             //         Poblacion = 13456766
             //     }
             // };
             //
             // Serializar(persona);
             // persona = Deserializar();
             //
             // Console.WriteLine(persona.ToString());

             #endregion
             
             #region Ejer_130 - XmlSerialization: Serializar objetos

             //https://www.exercisescsharp.com/es/serializacion-datos/serializar-objetos-xmlserialization
             
             // Persona person = new Persona()
             // {
             //     Nombre = "Nauj",
             //     Edad = 26,
             //     Ciudad = new Ciudad()
             //     {
             //         Nombre = "Spain",
             //         Poblacion = 13456766
             //     }
             // };
             //
             // Serializar(person);
             // person = Deserializar();
             //
             // Console.WriteLine(person.ToString());

             #endregion
             
             #region Ejer_131 - JavaScriptSerializer: Serializar objetos
             
             //https://www.exercisescsharp.com/es/serializacion-datos/serializar-objetos-javascriptserializer

             // Persona persona = new Persona()
             // {
             //     Nombre = "Nauj",
             //     Edad = 26,
             //     Ciudad = new Ciudad()
             //     {
             //         Nombre = "Spain",
             //         Poblacion = 13456766
             //     }
             // };
             //
             // SerializarJavascript(persona);
             // persona = DeserializarJavascript();
             //
             // Console.WriteLine(persona.ToString());
             // Console.ReadLine();

             #endregion

             #region Ejer_132 - DataContractJsonSerializer: Serializar objetos 

             //https://www.exercisescsharp.com/es/serializacion-datos/serializar-objetos-datacontractjsonserializer
             /* Documentación:
              * https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.json.datacontractjsonserializer?view=net-6.0
              */
             
             // PersonaDataContract person = new PersonaDataContract()
             // {
             //     Nombre = "Pepe",
             //     Edad = 25,
             //     Ciudad = new CiudadDataContract()
             //     {
             //         Nombre = "Loberia",
             //         Poblacion = 56766
             //     }
             // };
             //
             // SerializarDataContract(person);
             // person = DeserializarDataContract();
             //
             // Console.WriteLine(person.ToString());
             
             #endregion

             #region Ejer_133 - Newtonsoft.Json: Serializar objetos

             /*
              * Documentación:
              * https://www.newtonsoft.com/json/help/html/t_newtonsoft_json_jsonconvert.htm
              */
             
             // PersonaNewtonsoft persona = new PersonaNewtonsoft()
             // {
             //     Nombre = "Pepe",
             //     Edad = 25,
             //     Ciudad = new CiudadNewtonsoft()
             //     {
             //         Nombre = "Loberia",
             //         Poblacion = 56766
             //     }
             // };
             //
             // SerializarNewtonsoft(persona);
             // persona = DeserializarNewtonsoft();
             //
             // Console.WriteLine(persona.ToString());

             #endregion
             
             //========================== Colecciones genéricas ============================//

             #region Ejer_134 - ArrayList de objetos

             // ArrayList list = new ArrayList();
             //
             // int total = 3;
             // for (int i = 0; i < total; i++)
             // {
             //     Console.WriteLine("Ingrese Nombre");
             //     string name = Console.ReadLine();
             //     Console.WriteLine("Ingrese edad");
             //     int edad = Convert.ToInt32(Console.ReadLine());
             //     
             //     list.Add(new PersonToArray(){
             //         Name = name,
             //         Edad = edad
             //     });
             // }
             //
             // imprimirPersonas(list);

             #endregion

             #region Ejer_135 - Cola con arrays

             //https://www.exercisescsharp.com/es/colecciones-genericas/cola-con-arrays
             
             // int tamanio = 2;
             // Cola cola = new Cola(tamanio);
             //
             // int value1 = 7,
             //     value2 = 1;
             //
             // cola.Encolar(value1);
             // cola.Encolar(value2);
             //
             // value1 = cola.Desencolar();
             // value2 = cola.Desencolar();
             //
             // Console.WriteLine(value1);
             // Console.WriteLine(value2);
             
             #endregion

             #region Ejer_136 - Cola de objetos

             /*
              * Documentacion:
              * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-6.0
              */
             
             //https://www.exercisescsharp.com/es/colecciones-genericas/cola-de-objetos
             
             // Queue colaPersons = new Queue();
             // int total = 3;
             //
             // for (int i = 0; i < total; i++)
             // {
             //     Console.WriteLine("Ingrese Nombre");
             //     string nombre = Console.ReadLine();
             //     Console.WriteLine("Ingrese Edad");
             //     int edad = int.Parse(Console.ReadLine());
             //
             //     colaPersons.Enqueue(new Persona()
             //     {
             //         Nombre = nombre,
             //         Edad = edad
             //     });
             // }
             //
             // for (int i = 0; i < total; i++)
             // {
             //     Persona p = (Persona)colaPersons.Dequeue();
             //     Console.WriteLine(p.ToString());
             // }

             #endregion

             #region Ejer_137 - Pila con arrays

             //https://www.exercisescsharp.com/es/colecciones-genericas/pila-con-arrays
             
             // int tamanio = 2;
             // Pila pila = new Pila(tamanio);
             //
             // int val1 = 7,
             //     val2 = 1;
             //
             // pila.Apilar(val1);
             // pila.Apilar(val2);
             // val1 = pila.Desapilar();
             // val2 = pila.Desapilar();
             // Console.WriteLine(val1);
             // Console.WriteLine(val2);

             #endregion

             #region Ejer_138 - Pila de objetos

             Stack pila = new Stack();
             int total = 3;
 
             for (int i = 0; i < total; i++)
             {
                 Console.WriteLine("Ingrese Nombre");
                 string nombre = Console.ReadLine();
                 Console.WriteLine("Ingrese Edad");
                 int edad = int.Parse(Console.ReadLine());
 
                 pila.Push(new PersonaColecciones()
                 {
                     Nombre = nombre,
                     Edad = edad
                 });
             }
 
             for (int i = 0; i < total; i++)
             {
                 PersonaColecciones p = (PersonaColecciones)pila.Pop();
                 Console.WriteLine(p.ToString());
             }

             #endregion
        }
        
        #region Structs

        #region Ejer_60 - struct

        public struct Person
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Person(string nombre, int edad)
            {
                this.Nombre = nombre;
                this.Edad = edad;
            }

        }

        #endregion

        #region Ejer_71 - Matriz de struct

        public struct Cars
        {
            public string Modelo;
            public int AnioFabricacion;

            public Cars(string modelo, int anioFabricacion)
            {
                Modelo = modelo;
                AnioFabricacion = anioFabricacion;
            }

            public void Imprimir()
            {
                Console.WriteLine("Modelo: {0} Anio De Fabricacion: {1}", Modelo, AnioFabricacion);
            }
        }


        #endregion

        #endregion

        #region Functions

        //================================ Funciones A =====================================//

        #region Ejer_73 - Función saludo y despedida

        private static void Saludar()
        {
            Console.WriteLine("¡Hola!");
        }

        private static void Despedirse()
        {
            Console.WriteLine("¡Adios!");
        }

        #endregion

        #region Ejer_74 - Función con parámetros

        private static void Saludar(string name)
        {
            Console.WriteLine("¡Hola {0}!", name);
        }

        #endregion

        #region Ejer_75 - Función que retorna valor

        private static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        #endregion

        #region Ejer_76 - Función contar espacios de un texto

        private static int ContarEspacios(String palabra)
        {
            int count = 0;
            foreach (char letra in palabra)
            {
                if (letra == ' ')
                {
                    count++;
                }
            }

            return count;
        }

        #endregion

        #region Ejer_77 - Función escribir texto con formato

        private static void EscribirCentradoSubrayado(string s)
        {
            OchentaEspacios();
            Console.Write(s);
            Console.WriteLine();
            OchentaEspacios();
            Subrayado(s);

        }

        public static void OchentaEspacios()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write(" ");
            }
        }

        public static void Subrayado(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("-");
            }
        }

        #endregion

        #region Ejer_78 - Función sumar una matriz de enteros

        private static int Sumar(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                count += number;
            }

            return count;
        }

        #endregion

        #region Ejer_79 - Función calcular el doble de un número

        private static int Doble(int n)
        {
            return n * 2;
        }

        #endregion

        #region Ejer_80 - Función con parámetros por referencia

        private static void DobleReferencia(ref int n)
        {
            n += n;
        }

        #endregion

        #region Ejer_81 - Intercambiar parámetros por referencia

        private static void Swap(ref int n1, ref int n2)
        {
            int aux = n1;
            n1 = n2;
            n2 = aux;
        }


        #endregion

        //================================ Funciones B =====================================//

        #region Ejer_82 - Función para modificar un caracter de un texto

        private static void CambiarLetra(ref string palabra, int pos, char l)
        {
            palabra = palabra.Remove(pos);
            palabra = palabra.Insert(pos, l.ToString());
        }

        #endregion

        #region Ejer_83 - Función para sumar los dígitos de un número

        private static int SumarDigitos(string cadena)
        {
            int count = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                count += Convert.ToInt16(cadena.Substring(i, 1));
            }

            return count;
        }

        #endregion

        #region Ejer_84 - Función para mostrar una cadena invertida

        private static void InvertirCadena(string cadena)
        {
            string textInvert = string.Empty;

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                textInvert += cadena.Substring(i, 1);
            }

            Console.WriteLine(textInvert);
        }

        #endregion

        #region Ejer_85 - Buscar el mayor valor en una matriz

        private static int BuscarMayorValor(int[] numbers)
        {
            int max = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }

            return max;
        }

        #endregion

        #region Ejer_86 - Función para calcular la potencia de un número

        private static int Potencia(int n1, int n2)
        {
            int result = n1;
            for (int i = 1; i < n2; i++)
            {
                result *= n1;
            }

            return result;
        }

        #endregion

        #region Ejer_87 - Función para escribir texto con formato título

        private static void EscribirTitulo(string text)
        {
            Console.WriteLine("---------------------");
            foreach (char letra in text)
            {
                Console.Write("{0} ", char.ToUpper(letra));
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
        }

        #endregion

        //================================ Funciones C =====================================//

        #region Ejer_88 - Función para comprobar si un texto es alfabético

        private static bool EsAlfabetico(string text)
        {
            bool alfabetico = true;
            text = text.ToUpper();
            foreach (char c in text)
            {
                if (!(c > 'A' && c < 'Z'))
                    alfabetico = false;
            }

            return alfabetico;
        }

        #endregion

        #region Ejer_89 - Función para comprobar si un texto es número

        private static bool EsNumerico(string text)
        {
            bool numerico = true;

            foreach (char l in text)
            {
                if (!(l >= '0' && l <= '9'))
                {
                    numerico = false;
                }
            }

            return numerico;
        }

        #endregion

        #region Ejer_90 - Calculadora con parámetros de Main


        private static void Calculadora(float n1, float n2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    Console.WriteLine(Suma(n1, n2));
                    break;
                case "-":
                    Console.WriteLine(Resta(n1, n2));
                    break;
                case "*":
                    Console.WriteLine(Multiplicacion(n1, n2));
                    break;
                case "/":
                    Console.WriteLine(Divicion(n1, n2));
                    break;
                default:
                    Console.WriteLine("No hay opercion valida");
                    break;
            }
        }

        private static float Suma(float n1, float n2)
        {
            return n1 + n2;
        }

        private static float Resta(float n1, float n2)
        {
            return n1 - n2;
        }

        private static float Multiplicacion(float n1, float n2)
        {
            return n1 * n2;
        }

        private static float Divicion(float n1, float n2)
        {
            return n1 / n2;
        }

        #endregion

        #region Ejer_90 - Retornar valor desde Main

        private static int CalculadoraInfo(string[] args)
        {
            if (args.Length != 3)
            {
                return 1;
            }

            bool operador = true;
            if (args[2] == "+" || args[2] != "-" || args[2] != "/" || args[2] != "*" || args[2] != "x")
            {
                operador = false;
            }

            if (operador)
            {
                return 2;
            }

            int num1, num2;

            try
            {
                num1 = Convert.ToInt32(args[0]);
                num2 = Convert.ToInt32(args[2]);
            }
            catch
            {
                return 3;
            }

            return 0;
        }


        #endregion

        #region Ejer_91 - Buscar el mínimo y máximo en un array

        private static void BuscarMinMax(ref int max, ref int min, int[] arr)
        {
            foreach (int n in arr)
            {
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
            }

        }

        #endregion

        #region Ejer_92 - Función para comprobar palíndromo

        private static bool Palindromo(string cadena)
        {
            cadena = cadena.ToUpper();
            int j = cadena.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (cadena[j] != cadena[i])
                {
                    return false;
                }

                j--;
            }

            return true;
        }

        #endregion

        //================================ Funciones C =====================================//

        #region Ejer_93 - Calcular una potencia de manera recursiva

        public static int PotenciaRecursiva(int num, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            else
            {
                return num * PotenciaRecursiva(num, exponente - 1);
            }

        }

        #endregion

        #region Ejer_94 - Crear una función recursiva para multiplicar

        private static int MultiplicarRecursivo(int n1, int n2)
        {
            if (n2 == 1)
            {
                return n1;
            }
            else
            {
                return n1 + MultiplicarRecursivo(n1, n2 - 1);
            }
        }

        #endregion

        #region Ejer_95 - Calcular números de la serie de Fibonacci

        private static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        }

        #endregion

        #region Ejer_96 - Calcular el factorial de un número

        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }

        }

        #endregion

        #region Ejer_97 - Invertir una cadena de forma recursiva

        private static string InvertirRecursivo(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }

            char primeraLetra = text[0];
            string resto = text.Substring(1);

            return InvertirRecursivo(resto) + primeraLetra;
        }

        #endregion

        #region Ejer_98 - Comprobar palíndromo de forma recursiva

        private static bool PolindromoRecursivo(string texto)
        {
            if (texto.Length <= 1)
            {
                return true;
            }
            else
            {
                if (texto[0] != texto[texto.Length - 1])
                {
                    return false;
                }
                else
                {
                    return PolindromoRecursivo(texto.Substring(1, texto.Length - 2));
                }
            }
        }

        #endregion
        
        //========================== Archivos binarios ============================// 
        
        #region Ejer_123 - Visor hexadecimal
        public static  string ToHex(long n, int digits)
        {
            string hex = Convert.ToString(n, 16);
            while (hex.Length < digits)
            {
                hex = "0" + hex;
            }

            return hex;
        }

        #endregion
        
        //========================== Bases de datos SQLite ============================//

        #region Ejer_124 - Leer lista de bases de datos 

        public static List<PersonSQL> Persons = new List<PersonSQL>();
        public static void Read()
        {
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + DatabaseFileName + ";Version=3;"))
            {
                cnx.Open();
                using (SQLiteCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select name, age from person";
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Persons.Add(new PersonSQL()
                        {
                            Name = reader["name"].ToString(),
                            Age = int.Parse(reader["age"].ToString())
                        });
                    }
                }
            }
        }
        

        #endregion
        
        #region Ejer_125 - Crear base de datos y tablas

        public static void CrearBaseDatosSiNoExiste()
        {
            if (!File.Exists(nombreBaseDatos))
            {
                SQLiteConnection.CreateFile(nombreBaseDatos);
            }
        }

        public static void CrearTablasSiNoExisten()
        {
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + nombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();

                string sqlTablaPersona = "create table if not exists person (name varchar(20), age int)";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaPersona, cnx))
                {
                    cmd.ExecuteNonQuery();
                }

                string sqlTablaProfesor = "create table if not exists teacher (name varchar(20))";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaProfesor, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Ejer_126 - Crear base de datos en memoria

        public static string CadenaConexion = "Data Source=:memory:;Version=3;New=True;";
        public static void CrearTablas()
        {
            using (SQLiteConnection cnx = new SQLiteConnection(CadenaConexion))
            {
                cnx.Open();
 
                string sqlTablaPersona = "create table person (name varchar(20), age int)";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaPersona, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
 
                string sqlTablaProfesor = "create table teacher (name varchar(20))";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlTablaProfesor, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        

        #endregion
        
        #region Ejer_128 - Operaciones CRUD
        
        public static string NombreBaseDatos = "persons.sqlite";
        public static int OpcionMenu = -1;//por defecto -1
        public static void VerMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Agregar Persona");
            Console.WriteLine("2. Ver Personas");
            Console.WriteLine("3. Editar Persona");
            Console.WriteLine("4. Eliminar Persona");
            Console.WriteLine("5. Salir");
 
            Console.WriteLine();
            Console.Write("Introduzca una opción: ");
            OpcionMenu = int.Parse(Console.ReadLine());
 
            Console.Clear();
        }
        
        public static void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Agregar Persona");
            Console.WriteLine();
 
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
 
            Console.Write("Edad: ");
            int age = int.Parse(Console.ReadLine());
 
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();
                //linea sql 
                string sql = "insert into person (name, age) values ('" + name + "'," + age + ")";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public static void Ver()
        {
            Console.Clear();
            Console.WriteLine("Ver Personas");
            Console.WriteLine();
            //connection to sql 
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();
                using (SQLiteCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select * from person";
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataReader lector = cmd.ExecuteReader();
          
                    while (lector.Read())
                    {
                         Console.WriteLine("Id: " + lector["id"].ToString());
                         Console.WriteLine("Nombre: " + lector["name"].ToString());
                         Console.WriteLine("Edad: " + lector["age"].ToString());
                        Console.WriteLine();
                    }
                }
            }
        }
        
        private static bool existePersona(int idPersona)
        {
            bool existe = false;
 
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();
                using (SQLiteCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select 1 as cant from person where id =" + idPersona;
                    cmd.CommandType = CommandType.Text;
                    SQLiteDataReader lector = cmd.ExecuteReader();
                    if (lector.Read())
                    {
                        existe = lector["cant"].ToString() == "1" ? true : false;
                    }
                }
            }
 
            return existe;
        }
        
        public static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Editar");
            Console.WriteLine();
 
            Console.Write("Id: ");
            int idPersona = int.Parse(Console.ReadLine());
 
            if (existePersona(idPersona))
            {
                Console.Write("Nombre: ");
                string nuevoNombre = Console.ReadLine();
 
                Console.Write("Edad: ");
                int nuevaEdad = int.Parse(Console.ReadLine());
 
                using (SQLiteConnection cnx =
                    new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
                {
                    cnx.Open();
 
                    string sql = "update person set name='" + nuevoNombre + "'," +
                                 "age=" + nuevaEdad + " where cod=" + idPersona;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }
        
        public static void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Eliminar");
            Console.WriteLine();
 
            Console.Write("Cod: ");
            int idPersona = int.Parse(Console.ReadLine());
 
            if (existePersona(idPersona))
            {
                using (SQLiteConnection cnx =
                    new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
                {
                    cnx.Open();
 
                    string sql = "delete from person where id=" + idPersona;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }

        
        //Funcion que creara la tabla necesaria para agregar a los datos
        public static void CrearTablasSiNoExistenCRUD()
        {
            using (SQLiteConnection cnx =
                new SQLiteConnection("Data Source=" + NombreBaseDatos + ";Version=3;"))
            {
                cnx.Open();
 
                string sql = "create table if not exists person(" +
                             "id integer primary key autoincrement," +
                             "name varchar(20)," +
                             "age int)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnx))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
        
        //========================== Serialización de datos ============================//

        //EJERCICIO analizado su funcionamiento.
        #region Ejer_129 - BinaryFormatter: Serialización binaria

        static string nombreArchivo = "out.json";
        
        public static void Serializar(Persona p)
        {
            IFormatter f = new BinaryFormatter();
            using (Stream stream = new FileStream(nombreArchivo,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                f.Serialize(stream, p);
            }
        }
        
        public static Persona Deserializar()
        {
            Persona p;
            IFormatter f = new BinaryFormatter();
 
            using (Stream stream = new FileStream(nombreArchivo,
                FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                p = (Persona)f.Deserialize(stream);
            }
 
            return p;
        }

        #endregion

        #region Ejer_130 - XmlSerialization: Serializar objetos

        public static void SerializarXML(Persona p)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
 
            using (TextWriter escritor = new StreamWriter(nombreArchivo))
            {
                ser.Serialize(escritor, p);
            }
        }
 
        public static Persona DeserializarXML()
        {
            Persona p;
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
 
            using (TextReader lector = new StreamReader(nombreArchivo))
            {
                p = (Persona)ser.Deserialize(lector);
            }
 
            return p;
        }

        #endregion  
        
        #region Ejer_131 - JavaScriptSerializer: Serializar objetos

        //Biblioteca desactualizada 
        // public static void SerializarJavascript(Persona p)
        // {
        //     JavaScriptSerializer js = new JavaScriptSerializer();
        //     string json = js.Serialize(p);
        //
        //     File.WriteAllText(nombreArchivo, json);
        // }
        //
        // public static Persona DeserializarJavascript()
        // {
        //     JavaScriptSerializer js = new JavaScriptSerializer();
        //     string json = File.ReadAllText(nombreArchivo);
        //     Persona persona = js.Deserialize<Persona>(json);
        //
        //     return persona;
        // }

        #endregion

        #region Ejer_132 - DataContractJsonSerializer: Serializar objetos
        
        static string nombreArchivo2 = "out.json";
        public static void SerializarDataContract(PersonaDataContract p)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Persona));
            using (MemoryStream msObj = new MemoryStream())
            {
                js.WriteObject(msObj, p);
                msObj.Position = 0;
                using (StreamReader sr = new StreamReader(msObj))
                {
                    string json = sr.ReadToEnd();
                    File.WriteAllText(nombreArchivo2, json);
                }
            }
        }
        
        public static PersonaDataContract DeserializarDataContract()
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(PersonaDataContract));
            PersonaDataContract persona;
 
            string json = File.ReadAllText(nombreArchivo2);
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                persona = (PersonaDataContract)js.ReadObject(ms);
            }
 
            return persona;
        }

        #endregion

        #region Ejer_133 - Newtonsoft.Json: Serializar objetos

        public static void SerializarNewtonsoft(PersonaNewtonsoft p)
        {
            string json = JsonConvert.SerializeObject(p);
            File.WriteAllText(nombreArchivo, json);
        }
 
        public static PersonaNewtonsoft DeserializarNewtonsoft()
        {
            string json = File.ReadAllText(nombreArchivo);
            return JsonConvert.DeserializeObject<PersonaNewtonsoft>(json);
        }

        #endregion
        
        //========================== Colecciones genéricas ============================//

        #region Ejer_134 - Ejer_134 - ArrayList de objetos

        public static void imprimirPersonas(ArrayList persons)
        {
            foreach (PersonToArray person in persons)
            {
                Console.WriteLine("Nombre: {0}, Edad: {1}", person.Name, person.Edad);
            }
        }


        #endregion
        
        #endregion

        #region Class

        //================================ POO =====================================//

        #region Ejer_99 - Primera clase y método ToString()

        public class PersonaEjer_99
        {
            public string Nombre { get; set; }

            public override string ToString()
            {
                return "¡Hola Mi Nombre es " + Nombre + "!";
            }
        }

        #endregion

        #region Ejer_100 - Constructores y destructores

        public class Persona_Ejer_100
        {
            public string Nombre { get; set; }

            public Persona_Ejer_100(string nombre)
            {
                Nombre = nombre;
            }

            public override string ToString()
            {
                return "¡Hola Mi Nombre es " + Nombre + "!";
            }

            ~Persona_Ejer_100()
            {
                Nombre = string.Empty;
            }
        }

        #endregion

        #region Ejer_101 - Clase persona, estudiante y profesor

        public class EstudianteProfesorTest
        {
            public void Main(string[] args)
            {
                Console.WriteLine("Ingrese Nombre Persona");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese Edad");
                int edadPerson = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese Nombre Estudiante");
                string nameEstudent = Console.ReadLine();
                Console.WriteLine("Ingrese Edad Estudiante");
                int edadEstudent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese Nombre Profesor");
                string nameTeacher = Console.ReadLine();
                Console.WriteLine("Ingrese Edad Profesor");
                int edadTeacher = Convert.ToInt32(Console.ReadLine());

                //----------------------------------------------------//
                PersonaPadre p = new PersonaPadre(name, edadPerson);
                p.Saludar();
                //----------------------------------------------------//
                Estudiante e = new Estudiante(nameEstudent, edadEstudent);
                p.Saludar();
                e.Estudiar();
                //----------------------------------------------------//
                Profesor t = new Profesor(nameTeacher, edadTeacher);
                t.Saludar();
                t.Explicar();
            }
        }

        public class PersonaPadre
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public PersonaPadre(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public void Saludar()
            {
                Console.WriteLine("Hola");
            }

            public void SetEdad(int edad)
            {
                Edad = edad;
            }
        }

        public class Estudiante : PersonaPadre
        {
            public Estudiante(string nombre, int edad) : base(nombre, edad)
            {
            }

            public void Estudiar()
            {
                Console.WriteLine("Estoy Estudiando");
            }

            public void VerEdad()
            {
                Console.WriteLine("Mi Edad es " + Edad);
            }

        }

        public class Profesor : PersonaPadre
        {
            public Profesor(string nombre, int edad) : base(nombre, edad)
            {
            }

            public void Explicar()
            {
                Console.WriteLine("Estoy Explicando");
            }

        }

        #endregion

        #region Ejer_102 - Clase álbum de fotos

        //https://www.exercisescsharp.com/es/poo/clase-album-de-fotos

        public class AlbumTest
        {
            public void Main()
            {
                AlbumFotos a1 = new AlbumFotos();
                Console.WriteLine("Album constructor predeterminado");
                Console.WriteLine(a1.GetNumerosDePaginas());
                Console.WriteLine();
                Console.WriteLine("Album constructor Especifico");
                Console.WriteLine("ingrese tamaño");
                int cant = Convert.ToInt32(Console.ReadLine());
                AlbumFotos a2 = new AlbumFotos(cant);
                Console.WriteLine(a2.GetNumerosDePaginas());
                Console.WriteLine();
                Console.WriteLine("Super Album de fotos");
                SuperAlbumFotos a3 = new SuperAlbumFotos();
                Console.WriteLine(a3.GetNumerosDePaginas());

            }
        }

        public class AlbumFotos
        {
            private int numPaginas { get; set; }

            public AlbumFotos()
            {
                this.numPaginas = 16;
            }

            public AlbumFotos(int numPaginas)
            {
                this.numPaginas = numPaginas;
            }

            public int GetNumerosDePaginas()
            {
                return numPaginas;
            }
        }

        public class SuperAlbumFotos : AlbumFotos
        {
            public SuperAlbumFotos() : base(64)
            {
            }
        }

        #endregion

        #region Ejer_103 - Herencia de objetos

        public class PersonaEjer_103Test
        {
            public void Main()
            {
                int total = 3;
                PersonaEjer_103[] personas = new PersonaEjer_103[total];

                for (int i = 0; i < total; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Ingrese Nombre");
                        string name = Console.ReadLine();
                        Console.WriteLine("ingrese edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        personas[i] = new ProfesorEjer_103(name, edad);
                    }
                    else
                    {
                        Console.WriteLine("Ingrese Nombre");
                        string name = Console.ReadLine();
                        Console.WriteLine("ingrese edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        personas[i] = new EstudianteEjer_103(name, edad);
                    }
                }

                for (int i = 0; i < total; i++)
                {
                    if (i == 0)
                    {
                        ((ProfesorEjer_103) personas[i]).Explicar();

                    }
                    else
                    {
                        ((EstudianteEjer_103) personas[i]).Estudiar();
                    }
                }
            }

        }

        public class PersonaEjer_103
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public PersonaEjer_103(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public void Saludar()
            {
                Console.WriteLine("Hola");
            }

            public void SetEdad(int edad)
            {
                Edad = edad;
            }

            ~PersonaEjer_103()
            {
                Nombre = string.Empty;
            }
        }

        public class EstudianteEjer_103 : PersonaEjer_103
        {
            public EstudianteEjer_103(string nombre, int edad) : base(nombre, edad)
            {
            }

            public void Estudiar()
            {
                Console.WriteLine("Estoy Estudiando");
            }

            public void VerEdad()
            {
                Console.WriteLine("Mi Edad es " + Edad);
            }

        }

        public class ProfesorEjer_103 : PersonaEjer_103
        {
            public ProfesorEjer_103(string nombre, int edad) : base(nombre, edad)
            {
            }

            public void Explicar()
            {
                Console.WriteLine("Estoy Explicando");
            }

        }


        #endregion

        #region Ejer_104 - Formas - Diagrama de clases

        public class Forma
        {
            protected Ubicacion c ;

            public override string ToString()
            {
                return string.Empty;
            }

            public double Area()
            {
                return 0.000;
            }
 
            public double Perimetro()
            {
                return 0.000;
            }

        }

        public class Ubicacion
        {
            private double x { get; set; }
            private double y { get; set; }

            public double GetBase()
            {
                return x;
            }

            public double GetAltura()
            {
                return y;
            }
        }
        
        public class Circulo : Ubicacion
        {
            private double radio;

        }
        
        public class Rectangulo : Ubicacion
        {
            private double lado1;
            private double lado2;
        }

        #endregion

        #region Ejer_105 - Interfaces

        public void Main()
        {
            Coche coche = new Coche(0);
 
            int gasolina = int.Parse(Console.ReadLine());
            if (coche.Repostar(gasolina))
            {
                coche.Conducir();
            }
        }
 
        public interface IVehiculo
        {
            void Conducir();
            bool Repostar(int amount);
        }
 
        public class Coche : IVehiculo
        {
            public int Gasolina { get; set; }
 
            public Coche(int fuel)
            {
                Gasolina = fuel;
            }
 
            public void Conducir()
            {
                if (Gasolina > 0)
                {
                    Console.WriteLine("Conduciendo");
                }
                else
                {
                    Console.WriteLine("No hay gasolina");
                }
            }
 
            public bool Repostar(int cantidad)
            {
                Gasolina += cantidad;
                return true;
            }
        }

        #endregion

        #region Ejer_106 - Interfaces

        public class Perro : Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Comiendo");
            }
        }
 
        public abstract class Animal
        {
            private string Nombre;
 
            public void SetNombre(string nombre)
            {
                Nombre = nombre;
            }
 
            public string GetNombre()
            {
                return Nombre;
            }
 
            public abstract void Comer();
        }

        #endregion
        
        //========================== Archivos binarios ============================// 
        
        #region Ejer_117 - Leer etiquetas ID3 v1 de archivo MP3

        //https://www.exercisescsharp.com/es/archivos-binarios/leer-etiquetas-id3-v1-de-archivo-mp3

        public class ID3v1Etiquetas
        {
            private static byte idEtiquetaLongitud = 3;
            private static byte tituloEtiquetaLongitud = 30;
            private static byte artistaEtiquetaLongitud = 30;
            private static byte albumEtiquetaLongitud = 30;
            private static byte anyoEtiquetaLongitud = 4;
            private static byte comentarioEtiquetaLongitud = 30;
            private static byte generoEtiquetaLongitud = 1;

            public byte[] Id = new byte[idEtiquetaLongitud];
            public byte[] Titulo = new byte[tituloEtiquetaLongitud];
            public byte[] Artista = new byte[artistaEtiquetaLongitud];
            public byte[] Album = new byte[albumEtiquetaLongitud];
            public byte[] Anyo = new byte[anyoEtiquetaLongitud];
            public byte[] Comentario = new byte[comentarioEtiquetaLongitud];
            public byte[] Genero = new byte[generoEtiquetaLongitud];

            public bool EsID3v1Etiqueta()
            {
                if (Encoding.Default.GetString(Id).Equals("TAG"))
                {
                    return true;
                }

                return false;
            }

            public override string ToString()
            {
                StringBuilder tag = new StringBuilder();

                tag.AppendLine(Encoding.Default.GetString(Id));
                tag.AppendLine(Encoding.Default.GetString(Titulo));
                tag.AppendLine(Encoding.Default.GetString(Artista));
                tag.AppendLine(Encoding.Default.GetString(Album));
                tag.AppendLine(Encoding.Default.GetString(Anyo));
                tag.AppendLine(Encoding.Default.GetString(Comentario));
                tag.AppendLine(Encoding.Default.GetString(Genero));

                return tag.ToString();
            }
        }

        #endregion

        //========================== Bases de datos SQLite ============================//
        
        #region Ejer_124 - Leer lista de bases de datos 

        public class PersonSQL
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        #endregion 
        
        //========================== Serialización de datos ============================//
        
        #region Ejer_129 - BinaryFormatter: Serialización binaria
        
        [Serializable]
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Ciudad Ciudad { get; set; }
 
            public override string ToString()
            {
                StringBuilder str = new StringBuilder();
 
                str.AppendLine("Nombre: " + Nombre);
                str.AppendLine("Edad: " + Edad);
                str.AppendLine("Ciudad: " + Ciudad.Nombre);
 
                return str.ToString();
            }
        }
        
        [Serializable]
        public class Ciudad
        {
            public string Nombre { get; set; }
            public int Poblacion { get; set; }
        }
        
        #endregion

        #region Ejer_132 - DataContractJsonSerializer: Serializar objetos

        [DataContract]
        public class PersonaDataContract
        {
            [DataMember]
            public string Nombre { get; set; }
 
            [DataMember]
            public int Edad { get; set; }
 
            [DataMember]
            public CiudadDataContract Ciudad { get; set; }
 
            public override string ToString()
            {
                StringBuilder str = new StringBuilder();
 
                str.AppendLine("Nombre: " + Nombre);
                str.AppendLine("Edad: " + Edad);
                str.AppendLine("Ciudad: " + Ciudad.Nombre);
 
                return str.ToString();
            }
        }
        
        [DataContract]
        public class CiudadDataContract
        {
            [DataMember]
            public string Nombre { get; set; }
 
            [DataMember]
            public int Poblacion { get; set; }
        }
        
        #endregion
        
        #region Ejer_133 - Newtonsoft.Json: Serializar objetos

        public class PersonaNewtonsoft
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public CiudadNewtonsoft Ciudad { get; set; }
 
            public override string ToString()
            {
                StringBuilder str = new StringBuilder();
 
                str.AppendLine("Nombre: " + Nombre);
                str.AppendLine("Edad: " + Edad);
                str.AppendLine("Ciudad: " + Ciudad.Nombre);
 
                return str.ToString();
            }
        }
 
        public class CiudadNewtonsoft
        {
            public string Nombre { get; set; }
            public int Poblacion { get; set; }
        }

        #endregion
        
        //========================== Colecciones genéricas ============================//

        #region Ejer_134 - Ejer_134 - ArrayList de objetos
        
        public class PersonToArray
        {
            public string Name { get; set; }
            public int Edad { get; set; }
            
            
        }

        #endregion
        
        #region Ejer_135 - Cola con arrays

        public class Cola
        {
            public int pos;
            public int[] cola;

            public Cola(int tam)
            {
                this.pos = 0;
                this.cola = new int[tam];
            }

            public void Encolar(int value)
            {
                pos++;
                cola[pos] = value;
            }
            public int Desencolar()
            {
                int aux = cola[0];
 
                for (int i = 0; i < pos; i++)
                {
                    cola[i] = cola[i + 1];
                }
                pos--;//achico el tamaño de pos
                
                //cola[pos] = aux;
               //return cola[pos + 1];
               return aux;
            }
        }
        
        #endregion

        #region Ejer_137 - Pila con arrays

        public class Pila
        {
            private int[] pila;
            private int pos;
 
            public Pila(int tamanio)
            {
                pos = 0;
                pila = new int[tamanio];
            }
 
            public void Apilar(int value)
            {
                pila[pos] = value;
                pos++;
            }
 
            public int Desapilar()
            {
                if (pos > 0)
                {
                    pos = pos - 1;
                    return pila[pos];
                }
                return 0;
            }
        }

        #endregion

        #region Ejer_138 - Pila de objetos

        public class PersonaColecciones
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
 
            public override string ToString()
            {
                return Nombre + " - " + Edad;
            }
        }
        
        #endregion
        
        #endregion
    }
}