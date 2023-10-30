CountingElements test = new CountingElements();

int[] arr = { 1, 3, 1, 4, 2, 3, 5, 4 };
var result = test.FrogRiverOne(5, arr);
Console.WriteLine(result);

int[] arr2 = { 6, 4, 1, 3, 2, 5 };
var result2 = test.PermCheck(arr2);
Console.WriteLine(result2);

int number = 5;
int[] arr3 = { 3, 4, 4, 6, 1, 4, 4 };
var result3 = test.MaxCounters(number, arr3);
foreach (var item in result3)
{
    Console.Write(item);
}

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
    public int[] MaxCounters(int N, int[] A)
    {
        int[] counters = new int[N];
        int maxCounter = 0;
        int lastMaxCounter = 0;

        foreach (int value in A)
        {
            if (1 <= value && value <= N)
            {
                if (counters[value - 1] < lastMaxCounter)
                {
                    counters[value - 1] = lastMaxCounter;
                }

                counters[value - 1]++;

                if (counters[value - 1] > maxCounter)
                {
                    maxCounter = counters[value - 1];
                }
            }
            else if (value == N + 1)
            {
                lastMaxCounter = maxCounter;
            }
        }

        for (int i = 0; i < N; i++)
        {
            if (counters[i] < lastMaxCounter)
            {
                counters[i] = lastMaxCounter;
            }
        }

        return counters;
    }
}