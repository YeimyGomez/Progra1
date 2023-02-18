//Ejercicio 1

int edad;
int año; 

try

{
    Console.WriteLine("cuantos años tienes");
    año = Convert.ToInt32(Console.ReadLine());
    edad = año - 0;
    Console.WriteLine($" waw no aparentas {edad} años");
}    

catch 
{
    Console.WriteLine("ups, no entender su edad");
   
}


//Ejercicio 2



ushort num1, num2;
int multiplicacion;

Console.WriteLine("Ingrese el primer numero de dos cifras");
num1 = ushort.Parse(Console.ReadLine());
Console.WriteLine("Escrina el segundo numero de dos cifras");
num2 = ushort.Parse(Console.ReadLine());
multiplicacion = num1 * num2;
Console.WriteLine("La mulriplicacion es:" + multiplicacion);



//Ejercicio 3



long numero1;
long numero2;
long resultado;

Console.WriteLine("Ingresa los numeros");
numero1 = long.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los numeros");
numero2 = long.Parse(Console.ReadLine());
resultado = numero1 + numero2;
Console.WriteLine("La suma es:" + resultado);
resultado = numero1 - numero2;
Console.WriteLine("La resta es:" + resultado);