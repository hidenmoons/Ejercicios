// See https://aka.ms/new-console-template for more information
List<string> words = new List<string>{"dog", "cat", "abdeslam", "tucan","arpem", "aguila", "aslam", "amsterdam", "absurdum"};


    var wordAM= words.Where(x => x.StartsWith("a") && x.EndsWith("m"));

    foreach (string word in wordAM)
       {
        Console.WriteLine($"{word}");
       }


