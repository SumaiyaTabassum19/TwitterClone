namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification() : base()
        {
        }

        public override string GetNotificationMessage()
        {
            return "You received a new friend request.";
        }

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }
    }
}