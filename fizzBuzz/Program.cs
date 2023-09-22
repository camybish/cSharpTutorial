for(int i = 1; i <= 100; i++)
{
    switch(i % 15)
    {
        case 3:
        case 6:
        case 9:
        case 12:
            Console.WriteLine($"{i} - Fizz");
            break;
        case 5:
        case 10:
            Console.WriteLine($"{i} - Buzz");
            break;
        case 0:
            Console.WriteLine($"{i} - FizzBuzz");
            break;
        default:        
            Console.WriteLine(i);
            break;
    }
    
}