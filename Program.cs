namespace Staks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stacks = new Stack();
            try 
            {
                stacks.Push("camren");
                stacks.Push("mom");
                stacks.Push("dad");
                stacks.Push("sister");
                stacks.Push("Cats");
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e);
            }

            try 
            {
                Console.WriteLine("pop " + stacks.Pop());
                Console.WriteLine("pop " + stacks.Pop());
                Console.WriteLine("pop " + stacks.Pop());
                Console.WriteLine("pop " + stacks.Pop());
                Console.WriteLine("pop " + stacks.Pop());
                Console.WriteLine("pop " + stacks.Pop());
            }
            catch(UnderFlowException e)
            {
                Console.WriteLine(e.Message);
            }
            stacks.Print();
            stacks.Puts("hellos there");
        }
    }
}
