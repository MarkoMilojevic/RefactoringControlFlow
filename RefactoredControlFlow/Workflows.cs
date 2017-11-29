using System;
using System.Collections.Generic;

namespace RefactoredControlFlow
{
    public static class Workflows
    {
        public static Dictionary<WorkflowStatus, Action> Accounting = new Dictionary<WorkflowStatus, Action>
        {
            { WorkflowStatus.Ready, () => Console.WriteLine("Workflow status - Accounting Ready") },
            { WorkflowStatus.Active, () => Console.WriteLine("Workflow status - Accounting Active") },
            { WorkflowStatus.Complete, () => Console.WriteLine("Workflow status - Accounting Complete") }
        };

        public static Dictionary<WorkflowStatus, Action> HR = new Dictionary<WorkflowStatus, Action>
        {
            { WorkflowStatus.Ready, () => Console.WriteLine("Workflow status - HR Ready") },
            { WorkflowStatus.Active, () => Console.WriteLine("Workflow status - HR Active") },
            { WorkflowStatus.Complete, () => Console.WriteLine("Workflow status - HR Complete") }
        };
    }
}
