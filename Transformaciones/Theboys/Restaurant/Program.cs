//restaurantes
string Menu;
int opcionMenu;
int Hamburguer = 0;
int Pollo = 0;
int Postre = 0;
string opH;
string opP;
string opPo;
double Respuesta = 0;
string OpcionesSeleccionadas = "";


do{
    Console.WriteLine("Escoga una opcion del menu");
    Console.WriteLine("1. Hamburguesa");
    Console.WriteLine("2. Pollo");
    Console.WriteLine("3. Postres");
    Console.WriteLine("4. Salir");

    Menu = Console.ReadLine();
    opcionMenu = int.Parse(Menu);

    switch(Menu){

        case "1":
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Doble");
            Console.WriteLine("3. Doble con tocino");
            opH = Console.ReadLine();

            switch(opH){

                case "1":
                    Console.WriteLine("¿Cuántas desea?");
                    Hamburguer = int.Parse(Console.ReadLine());

                    Respuesta += Hamburguer * 4;
                    OpcionesSeleccionadas += $" {Hamburguer} Hamburguesas simples";
                    break;
                
                case "2":
                    Console.WriteLine("¿Cuántas desea?");
                    Hamburguer = int.Parse(Console.ReadLine());

                    Respuesta += Hamburguer * 6;
                    OpcionesSeleccionadas += $" {Hamburguer} Hamburguesas dobles";
                    break;

                case "3":
                    Console.WriteLine("¿Cuántas desea?");
                    Hamburguer = int.Parse(Console.ReadLine());

                    Respuesta += Hamburguer * 7;
                    OpcionesSeleccionadas += $" {Hamburguer} Hamburguesas dobles con tocino";
                    break;
            }
            break;


        case "2":
            Console.WriteLine("1. 1/4 de pollo");
            Console.WriteLine("2. 1/8 de pollo");
            Console.WriteLine("3. 1/2 de pollo");
            Console.WriteLine("4. Familiar (Con papas y gaseosa de 1.5Lt)");
            opP = Console.ReadLine();

            switch(opP){
                
                case "1":
                    Console.WriteLine("¿Cuántos desea?");
                    Pollo = int.Parse(Console.ReadLine());

                    Respuesta += Pollo * 7;
                    OpcionesSeleccionadas += $" {Pollo} 1/4 de pollo";
                    
                    break;
                
                case "2":
                    Console.WriteLine("¿Cuántos desea?");
                    Pollo = int.Parse(Console.ReadLine());

                    Respuesta += Pollo * 5;
                    OpcionesSeleccionadas += $" {Pollo} 1/8 de pollo";
                    break;

                case "3":
                    Console.WriteLine("¿Cuántos desea?");
                    Pollo = int.Parse(Console.ReadLine());

                    Respuesta += Pollo * 11;
                    OpcionesSeleccionadas += $" {Pollo} 1/2 de pollo";
                    break;
                
                case "4":
                    Console.WriteLine("¿Cuántos desea?");
                    Pollo = int.Parse(Console.ReadLine());

                    Respuesta += Pollo * 16;
                    OpcionesSeleccionadas += $" {Pollo} combos Familiar";
                    break;
            }
            break;
    

        case "3":
            Console.WriteLine("1. 3 Leches");
            Console.WriteLine("2. Brownnie");
            opPo = Console.ReadLine();

            switch(opPo){
                
                case"1":
                    Console.WriteLine("¿Cuántos desea?");
                    Postre = int.Parse(Console.ReadLine());

                    Respuesta += Postre * 2.50;
                    OpcionesSeleccionadas += $" {Postre} del postre de 3 leches";
                    break;
                
                case"2":
                    Console.WriteLine("¿Cuántos desea?");
                    Postre = int.Parse(Console.ReadLine());

                    Respuesta += Postre * 3.50;
                    OpcionesSeleccionadas += $" {Postre} Brownie ";
                    break;

            }
            break; 
    }

    if(opcionMenu == 4){
        Console.WriteLine("Saliendo...");    
    }
    else{
        Console.WriteLine($"Usted ha selecionado{OpcionesSeleccionadas}. Su total es de: {Respuesta}$"); 
    }

}while(opcionMenu != 4);

