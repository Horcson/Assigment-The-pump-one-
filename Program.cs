﻿

//Pump String Array 
string[] pump = new string[9] { "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN" };
Timer pumpOpen = null;
//Menu for the attendant to send cars from


static void UI(string[] pump)
{
Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
Console.WriteLine("10: View fuel dispensed");
} 

//Class for counting amount of cars queueing and Fuel dispensed
Fuel Fuel = new Fuel();
Cars cars = new Cars();
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
        cars.CarNum();
        //Pump selection menu
        UI(pump);

        //Timer that sets the pump to open after fueling process is
        pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
     

        
    }

    if (pumpSelect == 2)
    {
        pump[1] = "BUSY";
        cars.CarNum();
        UI(pump);
        
        pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 3)
    {
        pump[2] = "BUSY";
        cars.CarNum();
        UI(pump);
        
        pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 4)
    {
        pump[3] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 5)
    {
        pump[4] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
       
    }

    if (pumpSelect == 6)
    {
        pump[5] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 7)
    {
        pump[6] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 8)
    {
        pump[7] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
        
    }

    if (pumpSelect == 9)
    {
        pump[8] = "BUSY";
        cars.CarNum();
        UI(pump);

         pumpOpen = new Timer(pumpO, pumpSelect, 8000, 8000);
       
    }
    //Displays how much fuel has been dispensed
    if (pumpSelect == 10)
    {
        Console.WriteLine("\nLitres Sold: ");
        Console.WriteLine("The total unleaded fuel dispensed is: " +Fuel.getFuel() + "\n");
    }

    /*
     if (pumpSelect == 11)
     {
        Fuel.addFuel();
     }
      */

}
while (i < 5);

Console.ReadKey();