namespace SimpleFactory
{
    public class AddOperation:AbstractOperation
    {
        public override double GetResult()
        {
            return Number1 + Number2;
        }
    }
}