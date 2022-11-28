class Van
{
    public static List<string> VanQueue = new List<string> { "u" };

    public Van()
    {
        Random rnd = new Random();
        int time = rnd.Next(1500, 2200);

        Timer newVans = new Timer(van0, null, 1500, time);
        void van0(object o)
        {
            VanQueue.Add("GOW");
        }
    }

    public void VanNum()
    {
        Console.WriteLine("\nVans: " + VanQueue.Count);
    }

}