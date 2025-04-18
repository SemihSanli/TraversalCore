namespace Traversal_Core.CQRS.Command
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
