class LPG
{
    public static List<string> LPGQueue = new List<string> { "w" };

    public LPG()
    {
        Random rnd = new Random();
        int time = rnd.Next(1500, 2200);

        Timer newLPGS = new Timer(LPG0, null, 1500, time);
        void LPG0(object o)
        {
            LPGQueue.Add("GOW");
        }
    }

    public void LPGNum()
    {
        Console.WriteLine("LPGs: " + LPGQueue.Count);
    }

}