//restaurantes
string Menu;
int opcionMenu;
int Hamburguer;
int Pollo;
int Postres;
int opH = 0;
int opP = 0;
int opPo = 0;

Console.WriteLine("Escoga una opcion del menu");
Console.WriteLine("1. Hamburguesa");
Console.WriteLine("2. Pollo");
Console.WriteLine("3. POstres");
Console.WriteLine("4. Salir");

Menu = Console.ReadLine();
opcionMenu = int.Parse(Menu);

if(opcionMenu == 1){
    Console.WriteLine("1. Simple");
    Console.WriteLine("2. Doble");
    Console.WriteLine("3. Doble con tocino");
    opH = int.Parse(Console.ReadLine());

}

