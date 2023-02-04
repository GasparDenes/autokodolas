// See https://aka.ms/new-console-template for more information

class Program
{

    static int binary_weight(int n)
    {
        int weight = 0;
        while (n >= 1)
        {
            if (n % 2 == 1)
            {
                weight++;
            }
            n = n / 2;
        }

        return weight;

    }

    static void Main(String[] args)
    {
        int id;
        int previous = -1;
        int next = -1;
        int id_weight;
        Console.WriteLine("What is the id of the vehicle?");
        id = Convert.ToInt32(Console.ReadLine());

        id_weight = Program.binary_weight(id);

        for (int i = (id - 1); i > 0 && previous == -1; i--)
        {
            if (Program.binary_weight(i) == id_weight)
            {
                previous = i;
            }
        }

        for (int i = (id + 1); i <= Int32.MaxValue && next == -1; i++)
        {
            if (Program.binary_weight(i) == id_weight)
            {
                next = i;
            }
        }

        Console.WriteLine(previous);
        Console.WriteLine(next);
    }



}







