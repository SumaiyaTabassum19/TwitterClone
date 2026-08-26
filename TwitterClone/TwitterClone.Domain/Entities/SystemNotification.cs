namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public string Message { get; set; }

        public SystemNotification() : base()
        {
        }

        public override string GetNotificationMessage()
        {
            return Message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, Message: {Message}";
        }
    }
}