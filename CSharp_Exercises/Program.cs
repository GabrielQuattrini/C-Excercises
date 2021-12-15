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

            #region Ejer_51 - Operador condicional anida

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
            
            Console.WriteLine("ingrese palabra");
            string p = Console.ReadLine();

            int a = p.Length/2;
            int b = p.Length/2;
            
            
            //TODO terminar codigo para su optimo funcionamiento 
             for (int i = 1; i < p.Length+1/2 ; i++)
             { 
                 Console.WriteLine(p.Substring(a, i));
                a--;
                b++;
            }
             
            #endregion
        }
    }
}