using System.Collections.Generic;

namespace WorkFlowEngine
{

    public class WorkFlowEngine
    {
        private readonly List<IWorkFlow> _WorkFlow = new List<IWorkFlow>();
        
        public WorkFlowEngine()
        {
        }

        public void Run()
        {
            foreach (var flow in _WorkFlow)
            {
                flow.Excute();

            }

        }

        public void AddWorkFlows (IWorkFlow workFlow)
        {
            _WorkFlow.Add(workFlow);
        }
    }
}
