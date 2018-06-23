using System;

namespace WorkFlowEngine
{
    public class NotifyOwner : IWorkFlow
    {
        public void Excute()
        {
            Console.WriteLine("Notifiying Owner Video is ready");
        }
    }
}
