namespace Practice;

public class MergeSortedArray
{

    public static void Main(string[] args)
    {
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new int[] { 2, 5, 6 };
        int m = 3, n = 3;
        MergeSortedArray c = new MergeSortedArray();
        c.Merge(nums1, m, nums2, n);
        foreach (int i in nums1) { Console.WriteLine(i); }
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0,nums1,m, n);
        Array.Sort(nums1);
        


    }
}
