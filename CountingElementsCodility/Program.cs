CountingElements test = new CountingElements();

int[] arr = {1,3,1,4,2,3,5,4 };
var result = test.FrogRiverOne(5, arr);
Console.WriteLine(result);

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
}