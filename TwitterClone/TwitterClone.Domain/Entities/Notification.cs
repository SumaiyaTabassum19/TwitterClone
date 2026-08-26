namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }

        public Guid SenderId { get; set; }

        public bool IsRead { get; set; }

        public Notification() : base(Guid.NewGuid())
        {
        }

        public virtual string GetNotificationMessage()
        {
            return "You have a new notification.";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, " +
                   $"SenderId: {SenderId}, IsRead: {IsRead}";
        }
    }
}