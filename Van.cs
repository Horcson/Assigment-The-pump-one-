class Van
{
    public static List<string> VanQueue = new List<string> { "u" };

    public Van()
    {
        Timer newVans = new Timer(van0, null, 1500, 1500);
        void van0(object o)
        {
            VanQueue.Add("GOW");
        }
    }

    public void VanNum()
    {
        Console.WriteLine("Vans: " + VanQueue.Count);
    }

}