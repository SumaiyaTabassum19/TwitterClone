namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid TweetId { get; set; }

        public LikeNotification() : base()
        {
        }

        public override string GetNotificationMessage()
        {
            return "Someone liked your tweet.";
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, TweetId: {TweetId}";
        }
    }
}