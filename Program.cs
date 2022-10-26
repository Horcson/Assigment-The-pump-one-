//Pump String Array innit
string[] pump = new string[9] { "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN", "OPEN" };

//UI thingy (Not finsished probably)
Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);

int pumpSelect;
Console.WriteLine("Select a pump");
pumpSelect = Convert.ToInt32(Console.ReadLine());

if (pumpSelect == 1)
{
    pump[0] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 2)
{
    pump[1] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 3)
{
    pump[2] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 4)
{
    pump[3] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 5)
{
    pump[4] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 6)
{
    pump[5] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 7)
{
    pump[6] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 8)
{
    pump[7] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

if (pumpSelect == 9)
{
    pump[8] = "OCCUPIED";
    Console.WriteLine("pump 1 " + pump[0] + " pump 2 " + pump[1] + " pump 3 " + pump[2] + " pump 4 " + pump[3] + " pump 5 " + pump[4] + " pump 6 " + pump[5] + " pump 7 " + pump[6] + " pump 8 " + pump[7] + " pump 9 " + pump[8]);
}

Console.ReadKey();