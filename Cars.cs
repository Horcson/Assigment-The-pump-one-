class Cars
{
    public static List<string>Carqueue = new List<string>{"o"};
    public Cars()
    {
        Timer newCars = new Timer(car0, null, 1500, 1500);
        void car0(object o)
        {
        Carqueue.Add("JJ");
        }

    }
    

   
    
    public void CarNum()
    {
        Console.WriteLine("Cars: " + Carqueue.Count);
    }

}