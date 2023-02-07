namespace codewars.kyu5;

public class Rot13
{
    public static string Encode(string message)
    {
        var encoded = string.Empty;
        
        foreach (var letter in message)
        {
            if (char.IsLetter(letter))
            {
                var offset = char.IsUpper(letter) ? 'A' : 'a';
                encoded += (char) (((letter + 13 - offset) % 26) + offset);
            }
            else
            {
                encoded += letter;
            }
        }
        
        return encoded;
    }
}