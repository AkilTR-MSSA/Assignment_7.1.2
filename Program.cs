using System.Text;
string word1 = "ab";
string word2 = "pqrs";
Console.WriteLine(MergeStrings(word1, word2));


string MergeStrings(string word1, string word2)
{
    StringBuilder sb = new StringBuilder();
    int pointer = 0;
    int minLength = Math.Min(word1.Length, word2.Length);
    int maxLength = Math.Max(word1.Length, word2.Length);
    string longestString = word1.Length > word2.Length ? word1 : word2;
    for (int i = 0; i < minLength; i++)
    {
        sb.Append(word1[i]);
        sb.Append(word2[i]);
        pointer++;
    }
    for(int i = pointer; i < maxLength; i++)
    {
        sb.Append(longestString[i]);
    }
    return sb.ToString();
}