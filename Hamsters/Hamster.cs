namespace Hamsters
{
    class Hamster
    {
        public int Hunger { get; set; }
        public int Greed { get; set; }
        public int SumOfEat(int n)
        {
            return Hunger + n * Greed;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            
            if (!(obj is Hamster))
                return false;

            return (this.Hunger == ((Hamster)obj).Hunger) && (this.Greed == ((Hamster)obj).Greed);
        }
    }
}