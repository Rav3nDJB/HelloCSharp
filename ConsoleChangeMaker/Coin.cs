namespace ConsoleChangeMaker
{
    public class Coin
    {
        public int Value { get; set; }

        public int Count { get; set; }
        public int Total { get; set; }

        public Coin(int val, int cnt)
        {
            Value = val;
            Count = cnt;
            Total = Value * Count;
        }

    }
}
