namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Type { get; set; }

        public string Message { get; set; }

        public bool IsRead { get; set; }

        protected Notification(string type)
            : base(Guid.NewGuid())
        {
            Type = type;
            IsRead = false;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, " +
                   $"Type: {Type}, Message: {Message}, IsRead: {IsRead}";
        }

        public abstract string GetMessage();
    }
}