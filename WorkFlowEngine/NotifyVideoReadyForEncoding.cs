using System;

namespace WorkFlowEngine
{
    public class NotifyVideoReadyForEncoding : IWorkFlow
    {
        public void Excute()
        {
            Console.WriteLine("The Video Is ready for upload");
        }
    }
}
