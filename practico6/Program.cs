// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a= 10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//ejercicio 1

float num1=0;
bool exito = false;
string? numString = "";
while(!exito)
{
    Console.WriteLine("ingrese un numero valido:");
    numString = Console.ReadLine();
    exito = float.TryParse(numString,out num1);
    if (!exito)
    {
        Console.WriteLine(numString + "no es un numero valido");
    }
} 

