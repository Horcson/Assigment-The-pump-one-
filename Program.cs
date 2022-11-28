LoginSys Attendent = new LoginSys();

Attendent.setLoginID("Owen");
Attendent.setPassword("Rango");

Console.WriteLine("ENTER LOGIN ID");






//Pump String Array 
string[] pump = new string[9] { "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN" };

Timer pumpOpen = null;

Random rnd = new Random();
int fuelTime = rnd.Next(3000, 5000);
//Menu for the attendant to send cars from


static void UI(string[] pump)
{
    Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
    Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
    Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
    Console.WriteLine("10: View fuel dispensed");
}

//Class for counting amount of cars queueing and Fuel dispensed
VehicleServiced Served = new VehicleServiced();
LPG LPG = new LPG();
Van Vans = new Van();
Fuel Fuel = new Fuel();
Cars cars = new Cars();

Vans.VanNum();
LPG.LPGNum();
cars.CarNum();

void pumpO(object o)
{
    //Adds the amount of fuel that has been used up during the 8 second fuel process
    int pumpNo = Convert.ToInt32(o);
    Fuel.addFuel();
    pump[pumpNo] = "OPEN";
    pumpOpen.Dispose();
}
//UI A
UI(pump);

//pump selection stuff 
int i = 0;
do
{
    int pumpSelect;
    Console.WriteLine("Select a pump from 1-9:");
    pumpSelect = Convert.ToInt32(Console.ReadLine());

    if (pumpSelect == 1)
    {
        pump[0] = "BUSY";

        //Displays the amount of cars in a queue
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        //Pump selection menu
        UI(pump);

        //Timer that sets the pump to open after fueling process is
        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);
        //Ups the amount of vehicles serviced
        Served.addVehicle();
    }

    if (pumpSelect == 2)
    {
        pump[1] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 3)
    {
        pump[2] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 4)
    {
        pump[3] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 5)
    {
        pump[4] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 6)
    {
        pump[5] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 7)
    {
        pump[6] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 8)
    {
        pump[7] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }

    if (pumpSelect == 9)
    {
        pump[8] = "BUSY";
        Vans.VanNum();
        LPG.LPGNum();
        cars.CarNum();
        UI(pump);

        pumpOpen = new Timer(pumpO, pumpSelect, 8000, fuelTime);

        Served.addVehicle();

    }
    //Displays how much fuel has been dispensed
    if (pumpSelect == 10)
    {
        Console.WriteLine("\nVehicles Serviced: " + Served.getService());

        Console.WriteLine("\nLitres Sold: ");
        Console.WriteLine("The total unleaded fuel dispensed is: " + Fuel.getFuel() + "\n");
    }

}
while (i < 5);

Console.ReadKey();