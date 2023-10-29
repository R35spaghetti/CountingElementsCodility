using System.Runtime.InteropServices.JavaScript;
using System.Threading.Channels;

CountingElements test = new CountingElements();

int[] arr = { 1, 3, 1, 4, 2, 3, 5, 4 };
var result = test.FrogRiverOne(5, arr);
Console.WriteLine(result);

int[] arr2 = { 6, 4, 1, 3, 2, 5 };
var result2 = test.PermCheck(arr2);
Console.WriteLine(result2);

class CountingElements
{
    public int FrogRiverOne(int X, int[] A)
    {
        HashSet<int> position = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            position.Add(A[i]);
            if (position.Count == X)
            {
                return i;
            }
        }

        return -1;
    }

    public int PermCheck(int[] A)
    {
        bool[] checkPermNumbers = new bool[A.Length + 1];


        for (int i = 0; i < A.Length; i++)
        {
            int num = A[i];

            if (num < 1 || num > A.Length || checkPermNumbers[num])

            {
                return 0;
            }

            checkPermNumbers[num] = true;
        }

        for (int i = 1; i < A.Length; i++)
        {
            if (!checkPermNumbers[i])
            {
                return 0;
            }
        }

        return 1;
    }
}