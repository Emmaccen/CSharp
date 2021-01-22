using System.Collections.Generic;
using System.Text;

namespace Hello
{

    class WorkflowEngine
    {
        private readonly IList<IWorkFlow> workFlows;

        public WorkflowEngine()
        {
            this.workFlows = new List<IWorkFlow>();
        }

        public void Run()
        {
            foreach (var flow in workFlows)
            {
                flow.Execute();
            }
        }
        public void AddWorkflow(IWorkFlow workFlow)
        {
            workFlows.Add(workFlow);
        }
    }
}
