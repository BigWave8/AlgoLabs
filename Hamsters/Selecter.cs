using System.Collections.Generic;

namespace Hamsters
{
    class Selecter
    {
        public static void QuickSelect(List<Hamster> list, int quantity)
        {
            QuickSelect(list, 0, list.Count - 1, quantity);
        }
        private static void QuickSelect(List<Hamster> list, int minIndex, int maxIndex, int quantity)
        {
            int partition = Partition(list, minIndex, maxIndex, quantity);
            if (partition < quantity)
            {
                QuickSelect(list, partition + 1, maxIndex, quantity);
            }
            if (partition > quantity)
            {
                QuickSelect(list, minIndex, partition - 1, quantity);
            }
        }
        private static int Partition(List<Hamster> list, int minIndex, int maxIndex, int quantity)
        {
            int pivot = minIndex;
            for (int curIndex = minIndex; curIndex < maxIndex; curIndex++)
            {
                if (list[curIndex].SumOfEat(quantity) < list[maxIndex].SumOfEat(quantity))
                {
                    Swap(list, ref pivot, ref curIndex);
                    pivot++;
                }
            }
            Swap(list, ref pivot, ref maxIndex);
            return pivot;
        }
        private static void Swap(List<Hamster> list, ref int i, ref int j)
        {
            int temp = list[i].Hunger;
            list[i].Hunger = list[j].Hunger;
            list[j].Hunger = temp;

            temp = list[i].Greed;
            list[i].Greed = list[j].Greed;
            list[j].Greed = temp;
        }
    }
}