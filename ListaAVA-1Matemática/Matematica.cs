
class Matematica
{
    public Matematica()
    {    
    }
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Maior(double a, double b)
    {
        if (a > b)
        {
            Console.WriteLine($"{a} e o maior número");
            return a;
        }

        else if (a < b)
        {
            Console.WriteLine($"{b} e o maior número");
            return b;
        }
        else
            return a;
    }

    public double RaizQuadrada(double a)
    {
        if(a > 0)
        {
            return Math.Sqrt(a);
        }
        else
            Console.WriteLine("Impossivel calcular!");
        
        return 0;
    }
}
