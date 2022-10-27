//Pump String Array innit
string[] pump = new string[9] { "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN" };

//UI thingy (Not finsished probably)
Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);

//pump selection stuff BROTHA
int i = 0;
do
{

    int pumpSelect;
    Console.WriteLine("Select a pump from 1-9:");
    pumpSelect = Convert.ToInt32(Console.ReadLine());
    //void userInput(string[] pump)
    //{
    if (pumpSelect == 1)
    {
        pump[0] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[0] = "OPEN";
        }
    }

    if (pumpSelect == 2)
    {
        pump[1] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[1] = "OPEN";
        }
    }

    if (pumpSelect == 3)
    {
        pump[2] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[2] = "OPEN";
        }
    }

    if (pumpSelect == 4)
    {
        pump[3] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[3] = "OPEN";
        }
    }

    if (pumpSelect == 5)
    {
        pump[4] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[4] = "OPEN";
        }
    }

    if (pumpSelect == 6)
    {
        pump[5] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[5] = "OPEN";
        }
    }

    if (pumpSelect == 7)
    {
        pump[6] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[6] = "OPEN";
        }
    }

    if (pumpSelect == 8)
    {
        pump[7] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[7] = "OPEN";
        }
    }

    if (pumpSelect == 9)
    {
        pump[8] = "BUSY";
        Console.WriteLine("pump 1: " + pump[0] + " |pump 2: " + pump[1] + " |pump 3: " + pump[2]);
        Console.WriteLine("pump 4: " + pump[3] + " |pump 5: " + pump[4] + " |pump 6: " + pump[5]);
        Console.WriteLine("pump 7: " + pump[6] + " |pump 8: " + pump[7] + " |pump 9: " + pump[8]);
        Timer pumpOpen = new Timer(pumpO, null, 0, 8000);
        void pumpO(object o)
        {
            pump[8] = "OPEN";
        }
    }
}
while (i < 5);
//}

Console.ReadKey();