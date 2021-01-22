using System;

namespace Hello
{
    class ApiBuilder : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Building api..");
            Console.WriteLine("Api build complete at: {0} ... ", DateTime.Now);
        }
    }
}
