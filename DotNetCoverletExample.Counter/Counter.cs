namespace DotNetCoverletExample.Counter
{
    public class Counter
    {
        public int Value { get; private set; } = 0;

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            Value--;
        }
    }
}
