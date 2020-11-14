using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLab
{
    class Sorter
    {
        public static void InsertionSort(List<Conference> inputList)
        {
            for (int i = 1; i < inputList.Count; i++)
            {
                Conference key = inputList[i];
                int j = i;
                while (j > 0 && key.CountOfMembers > inputList[j - 1].CountOfMembers)
                {
                    inputList[j] = inputList[j - 1];
                    --j;
                    Launcher.InsertionSortComparisonCounter++;
                    Launcher.InsertionSortSwapCounter++;
                }
                inputList[j] = key;
                Launcher.InsertionSortSwapCounter++;
            }
        }

        public static void HeapSort(List<Conference> inputList)
        {
            int length = inputList.Count;
            for (int root = length / 2 - 1; root >= 0; root--)
            {
                Heapify(inputList, length, root);
            }
            for (int lastElementIndex = length - 1; lastElementIndex > 0; lastElementIndex--)
            {
                Swap(inputList, 0, lastElementIndex);

                Heapify(inputList, lastElementIndex, 0);
            }
        }

        public static void Heapify(List<Conference> inputList, int length, int root)
        {
            int maxElementIndex = root;
            int leftElementIndex = 2 * root + 1;
            int rightElementIndex = 2 * root + 2;

            if (leftElementIndex < length && inputList[leftElementIndex].TicketPriceInHryvnia > inputList[maxElementIndex].TicketPriceInHryvnia)
            {
                maxElementIndex = leftElementIndex;

                Launcher.HeapSortComparisonCounter++;
            }

            if (rightElementIndex < length && inputList[rightElementIndex].TicketPriceInHryvnia > inputList[maxElementIndex].TicketPriceInHryvnia)
            {
                maxElementIndex = rightElementIndex;

                Launcher.HeapSortComparisonCounter++;
            }

            if (maxElementIndex != root)
            {
                Swap(inputList, root, maxElementIndex); 

                Heapify(inputList, length, maxElementIndex);
            }
        }

        public static void Swap(List<Conference> inputList, int i, int j)
        {
            Conference temp = inputList[i];
            inputList[i] = inputList[j];
            inputList[j] = temp;

            Launcher.HeapSortSwapCounter++;
        }
    }
}
