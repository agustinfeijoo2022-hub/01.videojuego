Console.WriteLine("Hello, World!");
Console.Write("Hola Mundo");//soy un comentario
Console.Write("Hola Mundo 2");
/*
soy un bloque
de comentarios 
*/
Console.WriteLine();
Console.WriteLine("Ingrese nombre: ");
string? nombre=Console.ReadLine();
Console.WriteLine("Su nombre es: "+nombre);
int edad=21, peso=76;
float estatura=1.75f;
double promedio=1.75;
bool estaVivo=true;
char letra='c';
Console.WriteLine("Ingrese edad: ");
edad=int.Parse(Console.ReadLine()!);
Console.WriteLine("El próximo año tendrá: "+(edad+1));
int a=23;
double b=a;
double aa=2.3;
int bb=(int)aa;
string h=aa.ToString("f3");//convertir emn string
Console.WriteLine("h="+h);
bool estarVivo=int.TryParse("30",out int zz);
Console.WriteLine(estarVivo);
Console.WriteLine("zz=",+(zz+1));
//+, -, /, *, %
edad=edad+1;
edad+=1;
edad++;
//>, <, >=, !=, ==, &&, ||, !

if (edad>=18 && peso<100)
{
    Console.WriteLine("Puede jugar");
}
else if(estatura<2)
{
    Console.WriteLine("Pedir autorización");
}
else
{
    System.Console.WriteLine("No cumple");
}

int op=2;
switch (op)
{
    case 1:
        System.Console.WriteLine("Seleccion opción 1.");
        System.Console.WriteLine("Felicidades");
        break;

    case 2 : 
        System.Console.WriteLine("Selección opción 2.");
        System.Console.WriteLine("Felicidades");
        break;
    default:
        System.Console.WriteLine("No seleciona una opción válida");
        System.Console.WriteLine("Adios");
        break;      
}

op=2;
float velocidad = op switch{
    1=> 1.0f,
    2 => 2.5f,
};

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}
