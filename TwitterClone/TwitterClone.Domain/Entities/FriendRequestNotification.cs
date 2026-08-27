namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid RequestedByUserId { get; set; }

        public FriendRequestNotification(Guid requestedByUserId)
            : base("Friend Request")
        {
            RequestedByUserId = requestedByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {RequestedByUserId} sent you a friend request.";
        }
    }
}