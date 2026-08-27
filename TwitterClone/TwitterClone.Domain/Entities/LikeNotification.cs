namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikeByUserId { get; set; }

        public LikeNotification(Guid likeByUserId)
            : base("Like")
        {
            LikeByUserId = likeByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {LikeByUserId} liked your post.";
        }
    }
}