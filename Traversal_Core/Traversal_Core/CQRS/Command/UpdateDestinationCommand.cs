namespace Traversal_Core.CQRS.Command
{
    public class UpdateDestinationCommand
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public double Price { get; set; }
    }
}
