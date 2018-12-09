using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    public class Binario1
    {
        public void Ejemplo1()
        {
            int[] vector = { -12, 4, 8, 16, 32, 64, 128, 256, 512, 1024,2048,4096 };
            int numero, inicial = 0, final = vector.Length, mitad = 0;
            bool encontrado = false;//VARIABLE BOLEANA INICIALIZADA COMO FALSA
            Console.WriteLine("Ejemplo 1 \nVector:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "-");
            }
            Console.Write("\nQue numero desea buscar: ");
            numero = Convert.ToInt32(Console.ReadLine());//TAMAÑO DEL ARREGLO
            while (!encontrado && inicial <= final)//MIENTRAS ENCONTRADO DIFERENTE DE FALSO E INICIAL SEA MENOR O IGUAL A FINAL
            {
                mitad = (inicial + final) / 2;//SUMA DE INICIAL+FINAL
                if (numero == vector[mitad])//SI NUMERO ES IGUAL VECTOR EN POSICION MITAD, AL SER INT SE REDODEA AL NUMERO MAS CERCANO
                {
                    encontrado = true;//ENCONTRADO SERA VERDADERO
                }
                else if (numero < vector[mitad])// SI NO
                {
                    final = mitad - 1;//FINAL SE IGUALA A MITAD - 1 Y SE REPITE EL PROCESO 
                }
                else
                {
                    inicial = mitad + 1;//INICIAL SE IGUALA A MITAD + 1 Y SE REPITE EL PROCESO 
                }
            }           
            if (encontrado == true)//SI ENCONTRADO ES VERDADERO
            {
                Console.WriteLine("El numero se encuentra en la posicion {0} del vector", mitad);
            }
            else//SINO
            {
                Console.WriteLine("No se ha encontrado el numero");
            }
        }
        public void Ejemplo2()
        {
            int tamaño;
            Console.WriteLine("\nEjemplo 2 \nIngrese la cantidad de numeros que desea que tenga el arreglo");
            tamaño = Convert.ToInt32(Console.ReadLine());//TAMAÑO DEL ARREGLO
            int[] vector = new int[tamaño];//ARREGLO
            for (int i = 0; i < vector.Length; i++)//SE LLENA EL ARREGLO
            {
                Marca:
                Console.Write("Ingrese un numero: ");//SE LLENA POSICION POR POSICION
                vector[i] = int.Parse(Console.ReadLine());
                if (i > 0)//SI I=0
                {//EL METODO BINARIO NO FUNCIONA SI LOS NUMEROS NO ESTAN ORDENADOS Y NO SE REPITEN 
                    if (vector[i] < vector[i - 1] || vector[i] == vector[i - 1])//SI LA POSICION ACTUAL ES MENOR A LA ANTERIOR
                    {
                        Console.WriteLine("Ingrese unicamente numeros mayores al anterior");
                        goto Marca;//SE ENVIA AL IDENTIFICADOR PARA QUE SE VUELVA A PEDIR EL NUMERO
                    }
                }
            }
            int numero, inicial = 0, final = vector.Length, mitad = 0;
            bool encontrado = false;//VARIABLE BOLEANA INICIALIZADA COMO FALSA
            Console.Write("Que numero desea buscar: ");
            numero = Convert.ToInt32(Console.ReadLine());//TAMAÑO DEL ARREGLO
            while (!encontrado && inicial <= final)//MIENTRAS ENCONTRADO DIFERENTE DE FALSO E INICIAL SEA MENOR O IGUAL A FINAL
            {
                mitad = (inicial + final) / 2;//SUMA DE INICIAL+FINAL
                if (numero == vector[mitad])//SI NUMERO ES IGUAL VECTOR EN POSICION MITAD, AL SER INT SE REDODEA AL NUMERO MAS CERCANO
                {
                    encontrado = true;//ENCONTRADO SERA VERDADERO
                }
                else if (numero < vector[mitad])// SI NO
                {
                    final = mitad - 1;//FINAL SE IGUALA A MITAD - 1 Y SE REPITE EL PROCESO 
                }
                else
                {
                    inicial = mitad + 1;//INICIAL SE IGUALA A MITAD + 1 Y SE REPITE EL PROCESO 
                }
            }
            if (encontrado == true)//SI ENCONTRADO ES VERDADERO
            {
                Console.WriteLine("El numero se encuentra en la posicion {0} del vector", mitad);
            }
            else//SINO
            {
                Console.WriteLine("No se ha encontrado el numero");
            }          
        }
        public void UnaLinea()
        {
            Ejemplo1();
            Ejemplo2();
        }
    }
}
