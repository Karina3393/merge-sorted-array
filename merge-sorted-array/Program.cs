namespace merge_sorted_array
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[3] { 2, 5, 6 };

            solution.Merge(nums1, 3, nums2, 3);

            Console.WriteLine("Результат слияния: " + string.Join(", ", nums1));
           
        }
    }
}
