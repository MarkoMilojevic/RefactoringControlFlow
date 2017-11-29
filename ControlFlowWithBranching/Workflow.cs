using System;

namespace ControlFlowWithBranching
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
            switch (_status)
            {
                case WorkflowStatus.Ready:
                    Console.WriteLine("Workflow status - Ready");
                    break;
                case WorkflowStatus.Active:
                    Console.WriteLine("Workflow status - Active");
                    break;
                case WorkflowStatus.Complete:
                    Console.WriteLine("Workflow status - Complete");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_status), _status, null);
            }

            return this;
        }
    }
}
