// See https://aka.ms/new-console-template for more information
List<string> wordlist = new List<string>{"pedro", "juan", "perro", "gato", "celular", "12345"};


var upperword = wordlist.Where(x => x.Length>=5).Select(x => x.ToUpper());
foreach (string word in upperword) {

Console.WriteLine($"{word}, ");
}