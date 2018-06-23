using System;

namespace WorkFlowEngine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.AddWorkFlows(new NotifyOwner());
            workFlowEngine.AddWorkFlows(new NotifyVideoReadyForEncoding());
            workFlowEngine.AddWorkFlows(new VideoUploader());
            workFlowEngine.Run();
        }
    }
}
