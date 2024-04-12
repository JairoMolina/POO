using POO.CLASES;

Carro Car1 = new Carro ("TOYOTA", "TACOMA", 2002, "Automatico");

Car1.Color = "ROJO";
Car1.Owner = "JUAN";

//Agrgar case o una forma mas ordenada de ejecutar el programa

Console.WriteLine ("¿Desea ver la información del carro? \n(Si = S | No = N): ");
string Info_Car = Console.ReadLine().ToUpper();

if (Info_Car == "S")
{
    Console.WriteLine("Marca: " + Car1.Marca);
    Console.WriteLine("Marca: " + Car1.Modelo);
    Console.WriteLine("Año: " + Car1.Año);
    Console.WriteLine("Transmisión: " + Car1.Transmision);
    Console.WriteLine("Velocidad Máxima: " + Car1.Velocidad_Max + "/KPH");
    Console.WriteLine("Velocidad Máxima (Reversa): " + Car1.Velocidad_Max_Reversa + "/KPH");
    Console.WriteLine("Transmisión: " + Car1.Transmision);


    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
    Console.ReadKey();
}
else if (Info_Car == "N")
{

}
else
{
    Console.WriteLine("\nOpción Invalida");
}

Console.WriteLine("¿Desea encender el carro? \n(Si = S | No = N): ");
string Estado_Car = Console.ReadLine().ToUpper();

if (Estado_Car == "S")
{
    Car1.Encender();
    Console.WriteLine("\nCarro Encendido");

}
else if (Estado_Car == "N")
{
    Car1.Apagar();
    Console.WriteLine("\nCarro Apagado");

}
else
{
    Console.WriteLine("\nOpción Invalida");
}

Console.WriteLine("¿Desea Hacer Un Cambio? \n(Si = S | No = N): ");
string Cambio_Car = Console.ReadLine().ToUpper();
if (Cambio_Car == "S")
{
    Console.WriteLine("(Parking = P | Reverse = R | Neutro = N | Drive = D): "); //Arreglar la presentación
    Car1.Caja_Cambios();

}
else if (Cambio_Car == "N")
{

}
else
{
    Console.WriteLine("\nOpción Invalida");
}

Console.WriteLine(Car1.Acelerar() + "/KPH");
//Console.WriteLine(Car1.Frenar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
//Console.WriteLine(Car1.Frenar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");
Console.WriteLine(Car1.Acelerar() + "/KPH");