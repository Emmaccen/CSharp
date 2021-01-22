namespace Hello
{
    class RequestController : IWorkFlow
    {
        public void Execute()
        {
            System.Console.WriteLine("Controlling all external request");
        }
    }
}
