using System;
using System.Collections.Generic;

public interface ITask
{
    public void Execute();
}

public interface IWorkflow
{
    void Add(ITask task);
    void Remove(ITask task);
    IEnumerable<ITask> GetTasks();

}


public class CloudStorage : ITask
{
    public void Execute()
    {
        Console.WriteLine("Video is uploaded to cloud...");
    }
}

public class WebServices : ITask
{
    public void Execute()
    {
        Console.WriteLine("Video is ready for encoding...");
    }
}

public class SendEmail : ITask
{
    public void Execute()
    {
        Console.WriteLine("Mail is sending...");
    }
}

public class ChangeStatus : ITask
{
    public void Execute()
    {
        Console.WriteLine("Status is changed...");
    }
}


