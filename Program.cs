// See https://aka.ms/new-console-template for more information



using tpmodul5_103022300116;


public class HaloGeneric
{
    public void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Aisyah");

        DataGeneric<string> data = new DataGeneric<string>("103022300116");
        data.PrintData();

    }
}

