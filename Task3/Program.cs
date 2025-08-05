namespace Task3
{
    internal class Program
    {
        static char Menu()
        {
                Console.WriteLine("Menu Options :");
                Console.WriteLine("P - Print Numbers ");
                Console.WriteLine("A - Add a Number ");
                Console.WriteLine("M - Display mean of the numbers ");
                Console.WriteLine("S - Display the smallest number ");
                Console.WriteLine("L - Display the largest number ");
                Console.WriteLine("F - Find a number in the list ");
                Console.WriteLine("C - Clear the list ");
                Console.WriteLine("Q - Quit ");
                Console.Write("Enter your choice : ");
                char choice = Console.ReadLine().ToLower()[0];
                return choice;
            //Console.WriteLine(choice);
        }

        static List<int> printList(List<int> numbers)
        {
            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers);
            if (numbers.Count == 0)
            {
                Console.Write("list is empty - ");
                return numbers;
            }
            else 
                return numbers;
        }

        static List<int> addNumber(int number , List<int> numbers) {
            for (int i = 0; i < numbers.Count; i++) {
                if (numbers[i] == number)
                {
                    Console.WriteLine("This number already in the list");
                    return numbers;
                }
            }
            numbers.Add(number);
            Console.WriteLine($"{number} is added successfully");
            return numbers;
        }

        static double meanValue(List<int> numbers) {
            if (numbers.Count != 0)
            {
                int result = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    result += numbers[i];
                }
                return (double)result / numbers.Count;
            }
            else { return 0; }
        }

        static int smallestNumber(List<int> numbers) {
            if (numbers.Count != 0)
            {
                int smallest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (smallest > numbers[i])
                        smallest = numbers[i];
                }
                return smallest;
            }
            else return 0;
        }

        static int largestNumber(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int largest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (largest < numbers[i])
                        largest = numbers[i];
                }
                return largest;
            }
            else { return 0; }
        }

        static int findNumber (int number , List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                for (int i = 0; i<numbers.Count; i++)
                {
                    if (numbers[i]==(number))
                        return i;
                }
            }
            return -1;
        }

        static void clearList (List<int> numbers)
        {
            numbers.Clear();
        }


        static void Main(string[] args) {
            char choice = Menu();
            List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            while (choice != 'q')
            {
                switch (choice)
                {
                    case 'p':
                        printList(numbers);
                        Console.Write("[");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(" " + numbers[i] + " ");
                        }
                        Console.Write("]\n");
                        break;
                    case 'a':
                        Console.Write("enter a number to add : ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        addNumber(number, numbers);
                        break;
                    case 'm':
                        double value = meanValue(numbers);
                        if (value != 0)
                            Console.WriteLine($"The Mean is : {value}");
                        else
                            Console.WriteLine("check the list");
                        break;
                    case 's':
                        if (smallestNumber(numbers) != 0)
                            Console.WriteLine($"The Smallest number is : {smallestNumber(numbers)}");
                        else
                            Console.WriteLine("check the list");
                        break;
                    case 'l':
                        if (largestNumber(numbers) != 0)
                            Console.WriteLine($"The Largest number is : {largestNumber(numbers)}");
                        else
                            Console.WriteLine("check the list");
                        break;
                    case 'f':
                        Console.Write("enter a number to find :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (findNumber(num, numbers) != -1)
                            Console.WriteLine($"the number {num} is found at index {findNumber(num, numbers)}");
                        else
                            Console.WriteLine($"the number {num} not found");
                        break;
                    case 'c':
                        clearList(numbers);
                        Console.WriteLine("List is cleared");
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
                choice = Menu();
            }
            Console.WriteLine("Bye");
        }
        }
    }

