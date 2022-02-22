using System;
namespace WorkFlowDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var wfEngine = new WorkflowEngine();
            var workflow = new Workflow();

            workflow.Add(new CloudStorage());
            workflow.Add(new SendEmail());
            workflow.Add(new WebServices());
            workflow.Add(new ChangeStatus());
            wfEngine.Run(workflow);
            
            
        }
    }
}

