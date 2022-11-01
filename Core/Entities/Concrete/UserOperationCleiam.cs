namespace Core.Entities.Concrete
{
    public class UserOperationCleiam:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationCleamId { get; set; }
    }
}
