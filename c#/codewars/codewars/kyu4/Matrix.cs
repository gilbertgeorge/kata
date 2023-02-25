namespace codewars.kyu4;

public static class Matrix
{
    public static int Determinant(int[][] matrix)
    {
        if (matrix.Length == 1)
        {
            return matrix[0][0];
        }
        var sum = 0;
        for (var i = 0; i < matrix.Length; i++)
        {
            var subMatrix = new int[matrix.Length - 1][];
            for (var j = 0; j < matrix.Length - 1; j++)
            {
                subMatrix[j] = new int[matrix.Length - 1];
                for (var k = 0; k < matrix.Length; k++)
                {
                    if (k < i)
                    {
                        subMatrix[j][k] = matrix[j + 1][k];
                    }
                    else if (k > i)
                    {
                        subMatrix[j][k - 1] = matrix[j + 1][k];
                    }
                }
            }
            sum += matrix[0][i] * Determinant(subMatrix) * (i % 2 == 0 ? 1 : -1);
        }
        return sum;
    }
}