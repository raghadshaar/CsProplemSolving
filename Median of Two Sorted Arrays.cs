public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double median = 0;
        int p1 = 0;
        int p2 = 0;
        int endflag1 = 0;
        int endflag2 = 0;
        int[] merged = new int[nums1.Length + nums2.Length];
        if (nums1.Length == 0)
        {
            if (nums2.Length == 0)
            {
                return 0;
            }
            else
            {
                endflag1 = 1;
            }

        }
        if (nums2.Length == 0)
        {
            endflag2 = 1;
        }

        for (int i = 0; i < (nums2.Length + nums1.Length); i++)


        {
            if (endflag1 == 0)
            {
                if (endflag2 == 0)
                {
                    if (nums1[p1] < nums2[p2])
                    {
                        merged[i] = nums1[p1];
                        p1++;
                        if (p1 == nums1.Length)
                        {
                            endflag1 = 1;
                        }
                    }
                    else
                    {

                        merged[i] = nums2[p2];
                        p2++;
                        if (p2 == nums2.Length)
                        {
                            endflag2 = 1;
                        }
                    }
                }
                else
                {
                    merged[i] = nums1[p1];
                    p1++;
                    if (p1 == nums1.Length)
                    {
                        endflag1 = 1;
                    }
                }
            }
            else if (endflag2 == 0)
            {

                merged[i] = nums2[p2];
                p2++;
                if (p2 == nums2.Length)
                {
                    endflag2 = 1;

                }
            }
        }

        median = merged.Length % 2 == 1
            ? merged[merged.Length / 2]
            : (merged[merged.Length / 2 - 1] + merged[merged.Length / 2]) / 2.0;

        return median;



    }
}