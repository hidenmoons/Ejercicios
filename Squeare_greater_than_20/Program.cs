// See https://aka.ms/new-console-template for more information

List<int> numbers= new List<int>() {7, 2, 30};

var numbers_square = numbers.Where(x => x*x >20);
    
        foreach(var number in numbers_square) { 
        Console.WriteLine($"{number}-{number*number},");
        }
    

