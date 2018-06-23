using System;
namespace WorkFlowEngine
{
    public class VideoUploader : IWorkFlow
    {
        public void Excute()
        {
            Console.WriteLine("Video Is being uploaded");
        }
    }
}
