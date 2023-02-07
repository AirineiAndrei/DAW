// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> someNumbers = new List<int>();

someNumbers.Add(1);
someNumbers.Add(2);
someNumbers.Add(3); 
someNumbers.Add(4); 
someNumbers.Add(5);

foreach (int number in someNumbers)
{
    Console.Write(number);
    Console.Write(' ');
}
Console.WriteLine();

List<String> words = new List<String>();

words.Add("Ana");
words.Add("are");
words.Add("mere");
words.Add("multe!");
for(int i = 0; i < words.Count; i++)
    Console.WriteLine(words[i]);

var wordDict = new Dictionary<int, string>();

for (int i = 0; i < words.Count; i++)
    wordDict[i] = words[i];

foreach (var it in wordDict)
{
    Console.WriteLine($"{it.Key} with val {it.Value}");
}
