using System;
using System.Collections.Generic;

namespace RefactoredControlFlow
{
    public enum WorkflowStatus
    {
        Ready,
        Active,
        Complete,
    }

    public class Workflow
    {
        private WorkflowStatus _status;

        private readonly Dictionary<WorkflowStatus, Action> _actions;

        public Workflow()
        {
            _actions = new Dictionary<WorkflowStatus, Action>
            {
                { WorkflowStatus.Ready, () => Console.WriteLine("Workflow status - Ready") },
                { WorkflowStatus.Active, () => Console.WriteLine("Workflow status - Active") },
                { WorkflowStatus.Complete, () => Console.WriteLine("Workflow status - Complete") }
            };
        }

        public Workflow(Dictionary<WorkflowStatus, Action> actions)
        {
            _actions = actions;
        }

        public Workflow Ready()
        {
            _status = WorkflowStatus.Ready;
            return this;
        }

        public Workflow Active()
        {
            _status = WorkflowStatus.Active;
            return this;
        }

        public Workflow Complete()
        {
            _status = WorkflowStatus.Complete;
            return this;
        }

        public Workflow Execute()
        {
            _actions[_status]();
            return this;
        }
    }
}
