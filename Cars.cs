class Cars
{
    public static List<string> Carqueue = new List<string> { "o" };
    public Cars()
    {
        Random rnd = new Random();
        int time = rnd.Next(1500, 2200);

        Timer newCars = new Timer(car0, null, 1500, time);
        void car0(object o)
        {
            Carqueue.Add("JJ");
        }

    }

    public void CarNum()
    {
        Console.WriteLine("Cars: " + Carqueue.Count + "\n");
    }

}