namespace SimpleFactory
{
    public class SubtractOperation:AbstractOperation
    {
        public override double GetResult()
        {
            return Number1 - Number2;
        }
    }
}