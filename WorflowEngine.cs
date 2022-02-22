using System;

public class WorkflowEngine
{
    public void Run(IWorkflow workflow)
    {
        foreach (ITask item in workflow.GetTasks())
        {
            item.Execute();
        }
    }
}

