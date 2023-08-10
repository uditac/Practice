namespace Practice;

public class Selection_Sort
{
   public static void Main(string[] args)
    {
        Selection_Sort p = new Selection_Sort();
        int[] array = { 5, 7, 8, 4, 2, 1 };
        int[] n = p.FindMinMax(array);
        foreach (int i in array)
        {
            Console.WriteLine(i.ToString());

        }
        Console.WriteLine("The minimum number is : {0} ", +array[0]);
        Console.WriteLine("The minimum number is : {0} ", +array[array.Length - 1]);
        Console.ReadLine();
    }

    public int[] FindMinMax(int[] inputarray)
    {

        int min, temp;
        for (int i = 0; i < inputarray.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < inputarray.Length; j++)
            {
                if (inputarray[min] > inputarray[j])
                {
                    min = j;

                }

            }

            temp = inputarray[min];
            inputarray[min] = inputarray[i];
            inputarray[i] = temp;

        }
        return inputarray;
    }
}