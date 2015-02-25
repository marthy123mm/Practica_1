
using System;

namespace Practica_1
{
	class Program
	{
		public static int suma(int a , int b){
			return a+b;
		}
		
		public static int resta(int a, int b){
			return a-b;
		}
		
		public static int multiplicacion(int a, int b){
			return a*b;
		}
		
		public static int division(int a, int b){
			return a/b;
		}
		
		public static double areaCirculo(int a ){
			a=a*a;
			return a*3.1416;	
		}
		
		public static double areaCuadrado(int a){
			return a*a;
		}
		
		public static double areaTriangulo(int a, int b){
			return ((b*a)/2);
		}
		
		public static void Main(string[] args)
		{
			int numero1=0;
			int numero2=0;
			int opcion=0;
			
			do{
				Console.WriteLine("\n\tPRACTICA I EN C#\n\n");
				Console.WriteLine("1)Suma\n2)Resta\n3)Multiplicacion\n4)Division\n5)Area Del Circulo\n6)Area Del Cuadrado\n7)Area Del triangulo\n8)Salir\n");
				Console.WriteLine("Elige una opcion: ");
				opcion=int.Parse(Console.ReadLine());
				
				switch(opcion) {
						
						case 1: Console.Write("Escribe un numero : ");
								numero1=int.Parse(Console.ReadLine());
								Console.Write("Escribe un numero : ");
								numero2=int.Parse(Console.ReadLine());
								Console.WriteLine("La Suma es " + suma(numero1,numero2) +"\n");
								break;
								
						case 2: Console.Write("Escribe un numero : ");
								numero1=int.Parse(Console.ReadLine());
								Console.Write("Escribe un numero : ");
								numero2=int.Parse(Console.ReadLine());
								Console.WriteLine("La resta es " + resta(numero1,numero2) +"\n");
								break;
								
						case 3: Console.Write("Escribe un numero : ");
								numero1=int.Parse(Console.ReadLine());
								Console.Write("Escribe un numero : ");
								numero2=int.Parse(Console.ReadLine());
								Console.WriteLine("La Multiplicacion es " + multiplicacion(numero1,numero2) +"\n");
								break;
						
						case 4: Console.Write("Escribe un numero : ");
								numero1=int.Parse(Console.ReadLine());
								Console.Write("Escribe un numero : ");
								numero2=int.Parse(Console.ReadLine());
								Console.WriteLine("La division es " + division(numero1,numero2) +"\n");
								break;
								
						case 5: Console.Write("Escribe el radio del circulo : ");
								numero1=int.Parse(Console.ReadLine());
								Console.WriteLine("El area del circulo es " + areaCirculo(numero1) +"\n");
								break;
								
						case 6: Console.Write("Escribe el lado del cuadrado : ");
								numero1=int.Parse(Console.ReadLine());
								Console.WriteLine("El area del cuadrado es " + areaCuadrado(numero1) +"\n");
								break;
								
						case 7: Console.Write("Escribe la altura del triangulo : ");
								numero1=int.Parse(Console.ReadLine());
								Console.Write("Escribe la base del triangulo : ");
								numero2=int.Parse(Console.ReadLine());
								Console.WriteLine("El area del triangulo es " + areaTriangulo(numero1,numero2) +"\n");
								break;
																
				}
				
			}while(opcion<8);
			
				
		}
	}
}