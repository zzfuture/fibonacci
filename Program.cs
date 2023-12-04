internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ejercicio Fibonacci: ");
        int n = int.Parse(Console.ReadLine());
        List<int> FibonacciList = new List<int>{0,1};
        switch(n) 
        {
        case 1:
            Console.WriteLine("1.1");
            Console.Write("N: ");
            FibonacciList = new List<int>{0,1};
            int n1 = int.Parse(Console.ReadLine());
            for(int i = 2; i<(n1 + 2); i++)
            {
                int k = FibonacciList[i-1] + FibonacciList[i-2]; 
                FibonacciList.Add(k);
            }
            Console.WriteLine(FibonacciList[n1]);
            break;
        case 2:
            Console.WriteLine("1.2");
            Console.Write("N: ");
            int n2 = int.Parse(Console.ReadLine());
            bool IsFibonacci = true;
            FibonacciList = new List<int>{0,1,2,3,5};
            if ((n2 < 0 || n2 < 8) && !FibonacciList.Contains(n2))
            {
                IsFibonacci = false;
            }
            if (!IsFibonacci)
            {
                {
                    for(int i = 5; i<(n2 + 5); i++)
                    {
                        int k = FibonacciList[i-1] + FibonacciList[i-2]; 
                        if (k>n2)
                        {
                            IsFibonacci = false;
                            break;
                        }
                        else
                        {
                            FibonacciList.Add(k);
                        }
                    }
                }
            }
            if (IsFibonacci == false){
            Console.WriteLine("No ese un numero Fibonacci");
            }
            else{
            Console.WriteLine("Es un numero Fibonacci");
            }
            break;
        case 3:
            Console.WriteLine("1.3");
            Console.Write("N: ");
            int n3 = int.Parse(Console.ReadLine());
            FibonacciList = new List<int>{0,1};
            string FibonacciString = "0 1";
            if (n3 <= 2)
            {
                Console.WriteLine(FibonacciString);
            }
            else
            {
                for(int i = 2; i<(n3 + 2); i++)
                {
                    int k = FibonacciList[i-1] + FibonacciList[i-2]; 
                    FibonacciList.Add(k);
                    FibonacciString = $"{FibonacciString} {k}";
                }
            }
            Console.WriteLine(FibonacciString);
            break;
        }
    }
}