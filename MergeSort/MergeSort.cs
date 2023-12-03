using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo
{
    internal class MergeSort
    {
        public void UseSortAlgo(int[] A, int left, int right)
        {
            if(left < right)
            {
               int mid = (left + right)/2;
               UseSortAlgo(A,left, mid);
               UseSortAlgo(A,mid+1, right);
               Merge(A, left,mid, right);

            }
        }

        public void Merge(int[] A, int left,int mid, int right)
        {
            int[] B = new int[right-left+1];

            //zeiger
            int i = left; 
            int j = mid+1;
            int k = 0;

            while(i<= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++; 
                }
                else
                {
                    B[k] = A[j];
                    j++;  
                }
                k++;
            }

            while (i<= mid)
            {
                B[k] = A[i];
                i++; 
                k++;
            }
            while (j<= right)
            {
                B[k] = A[j];
                j++; 
                k++;
            }

            for(int m =left;m <= right; m++)
            {
                A[m] = B[m-left];
            }
            
            
        } 


    }
}
