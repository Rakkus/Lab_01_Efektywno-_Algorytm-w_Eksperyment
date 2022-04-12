﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_Efektywność_Algorytmów_Eksperyment
{
    class Generators
    {
        Random random = new Random();
        public int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            int[] i = new int[size];
            for (int j = 0; j < size; j++)
            {
                i[j] = random.Next(minVal, maxVal);
            }
            return i;
        }

        public int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] i = GenerateSorted(size, minVal, maxVal);
            Array.Reverse(i);
            return i;
        }

        public int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] i = GenerateRandom(size, minVal, maxVal);
            Array.Sort(i);
            return i;
        }

        public int[] GenerateFewUnique(int size)
        {
            int maxVal = size / 10;
            int[] i = GenerateRandom(size, 0, maxVal);
            return i;
        }

        public int[] GenerateAlmost(int size, int minVal, int maxVal, int reversePairs)
        {
            int[] i = GenerateSorted(size, minVal, maxVal);

            for (int j = 0; j < reversePairs; j++)
            {
                int k = random.Next(0, size);
                int l = random.Next(0, size);
                int kbefore = i[k];
                int lbefore = i[l];
                i[k] = kbefore;
                i[l] = lbefore;
            }

            return i;
        }


    }
}
