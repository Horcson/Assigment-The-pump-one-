class LPG
{
    public static List<string> LPGQueue = new List<string> { "w" };

    public LPG()
    {
        Timer newLPGS = new Timer(LPG0, null, 1500, 1500);
        void LPG0(object o)
        {
            LPGQueue.Add("GOW");
        }
    }

    public void VanNum()
    {
        Console.WriteLine("Vans: " + LPGQueue.Count);
    }

}