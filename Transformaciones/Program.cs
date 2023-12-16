float cantidad = 0;
float centimetros = 0;
float metros = 0;
float hectometros = 0;
float kilometros = 0;
float milimetros = 0;

string menu;
Console.WriteLine("Ingrese la cantidad");
cantidad = float.Parse(Console.ReadLine());
Console.WriteLine("Elige la unidad de medida de la cantidad");
Console.WriteLine("1. Milímetros");
Console.WriteLine("2. Centímetros");
Console.WriteLine("3. Metros");
Console.WriteLine("4. Hectometros");
Console.WriteLine("5. Kilometros");
menu = Console.ReadLine();
switch (menu){
    case "1":
    Console.WriteLine("La medida actual es Milimetros");
    milimetros = cantidad * 1;
    centimetros = cantidad / 10; //transformacion a centimetros
    metros = cantidad / 1000; //Transformacion a metros
    hectometros = cantidad / 100000;// tranformacion hectometros
    kilometros = cantidad / 1000000;// transformacion a kilometros
    break;
    case "2":
    Console.WriteLine("La medida actual es centimetros");
    milimetros = cantidad * 10;
    centimetros = cantidad * 1;
    metros = cantidad / 100;
    hectometros = cantidad / 10000;
    kilometros = cantidad / 100000; 
    break;
    case "3":
    Console.WriteLine("La medida actual es metros");
    milimetros = cantidad * 1000;
    centimetros = cantidad * 100;
    metros = cantidad * 1;
    hectometros = cantidad / 100;
    kilometros = cantidad / 1000; 
    break;
    case "4":
    Console.WriteLine("La medida actual es hectometros");
    milimetros = cantidad * 100000;
    centimetros = cantidad * 10000;
    metros = cantidad * 100;
    hectometros = cantidad * 1;
    kilometros = cantidad / 10; 
    break;
    case "5":
    Console.WriteLine("La medida actual es kilometros");
    milimetros = cantidad * 1000000;
    centimetros = cantidad * 100000;
    metros = cantidad * 1000;
    hectometros = cantidad * 10;
    kilometros = cantidad * 1; 
    break;
    


}

Console.WriteLine($" El resultado en milimetros es: {milimetros}\n \n El resultado en centimetros es:{centimetros}\n \n El resultado en metros es:{metros}\n \n El resultado en hectometros es:{hectometros}\n \n El resultado en kilometros es:{kilometros}");







