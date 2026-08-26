namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public Guid TweetId { get; set; }

        public CommentNotification() : base()
        {
        }

        public override string GetNotificationMessage()
        {
            return "Someone commented on your tweet.";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, TweetId: {TweetId}";
        }
    }
}