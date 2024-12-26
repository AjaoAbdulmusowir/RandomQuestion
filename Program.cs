Console.WriteLine("Hello, World!");
string sentence = "Haffa Nah Long Time";
string[] words = sentence.Split(' ');
int count = 0;
// Console.WriteLine(words.Length);
foreach (string word in words)
{
    count++;
}
Console.WriteLine(count);
