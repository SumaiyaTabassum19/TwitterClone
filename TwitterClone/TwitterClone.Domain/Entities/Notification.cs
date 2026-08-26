namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid UserId { get; set; }

        public Guid SenderId { get; set; }

        public string Type { get; set; }

        public string Message { get; set; }

        public bool IsRead { get; set; }

        public Notification() : base(Guid.NewGuid())
        {
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, " +
                   $"SenderId: {SenderId}, Type: {Type}, " +
                   $"Message: {Message}, IsRead: {IsRead}";
        }
    }
}