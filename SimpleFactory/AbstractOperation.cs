namespace SimpleFactory
{
    public abstract class AbstractOperation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public abstract double GetResult();
    }
}