class Hotel:
    def __init__(self):
        self.habitaciones = {1: ("Simple", 50), 2: ("Doble", 100), 3: ("Familiar", 150)}
        self.adicionales = {1: ("Vista al Mar", 20), 2: ("Vista al Restaurante", 10), 3: ("Sin Adicional", 0)}
        self.alimentacion = {1: ("Todo Incluido", 30), 2: ("Todo Incluido Niños", 20), 3: ("Solo Desayuno", 10), 4: ("Sin Alimentacion", 0)}
        self.reservas = []

    def menu(self):
        while True:
            print("1. Reservar habitación\n2. Pagar\n3. Salir")
            opcion = int(input("Seleccione una opción: "))
            if opcion == 1:
                self.reservar()
            elif opcion == 2:
                self.pagar()
            elif opcion == 3:
                break
            else:
                print("Opción inválida. Intente de nuevo.")

    def reservar(self):
        print("Tipo de habitación:\n1. Simple\n2. Doble\n3. Familiar")
        tipo_habitacion = int(input("Seleccione una opción: "))
        print("Adicionales:\n1. Vista al Mar\n2. Vista al Restaurante\n3. Sin Adicional")
        adicional = int(input("Seleccione una opción: "))
        num_huespedes = int(input("Número de huéspedes: "))
        print("Tipo de alimentación:\n1. Todo Incluido\n2. Todo Incluido Niños\n3. Solo Desayuno\n4. Sin Alimentacion")
        tipo_alimentacion = int(input("Seleccione una opción: "))
        self.reservas.append((tipo_habitacion, adicional, num_huespedes, tipo_alimentacion))

    def pagar(self):
        total = 0
        for reserva in self.reservas:
            costo = self.calcular_costo(*reserva)
            total += costo
            print(f"Reserva: {self.habitaciones[reserva[0]][0]}, {self.adicionales[reserva[1]][0]}, {reserva[2]} huéspedes, {self.alimentacion[reserva[3]][0]} - Costo: {costo}")
        print(f"El costo total es: {total}")
        self.reservas = []

    def calcular_costo(self, tipo_habitacion, adicional, num_huespedes, tipo_alimentacion):
        try:
            precio_habitacion = self.habitaciones[tipo_habitacion][1]
            precio_adicional = self.adicionales[adicional][1]
            precio_alimentacion = self.alimentacion[tipo_alimentacion][1]
            total = (precio_habitacion + precio_adicional + precio_alimentacion) * num_huespedes
            return total
        except KeyError:
            return "Por favor, ingrese una opción válida."

hotel = Hotel()
hotel.menu()
