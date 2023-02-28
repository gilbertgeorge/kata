namespace codewars.kyu5;

// How can you tell an extrovert from an introvert at NSA?
// Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
//
// I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it?
// According to Wikipedia, ROT13 is frequently used to obfuscate jokes on USENET.
//
// For this task you're only supposed to substitute characters. Not spaces, punctuation, numbers, etc.
public static class Rot13
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
    
    public static string Decode(string message)
    {
        return Encode(message);
    }
}