namespace codewars.kyu5;

public static class IntToIPv4
{
    public static string UInt32ToIP(uint ip)
    {
        string binary = Convert.ToString(ip, 2);
        string[] octets = new string[4];
        int octetIndex = 0;
        for (int i = binary.Length; i > 0; i -= 8)
        {
            while (binary.Length - i < 8)
            {
                binary = "0" + binary;
            }
            octets[octetIndex] = binary.Substring(i, 8);
            octetIndex++;
        }
        int[] octetDecimals = new int[4];
        for (int i = 0; i < octets.Length; i++)
        {
            octetDecimals[i] = Convert.ToInt32(octets[i], 2);
        }

        return string.Join(".", octetDecimals.Reverse());
    }
}