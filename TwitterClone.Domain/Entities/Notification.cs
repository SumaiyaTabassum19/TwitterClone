namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private Guid _senderId;
        private string _type;
        private string _message;
        private DateTime _createdAt;
        private bool _isRead;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public string Type
        {
            get { return _type; }
        }

        public string Message
        {
            get { return _message; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public bool IsRead
        {
            get { return _isRead; }
        }

        public Notification(
            Guid userId,
            Guid senderId,
            string type,
            string message)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _senderId = senderId;
            _type = type;
            _message = message;
            _createdAt = DateTime.UtcNow;
            _isRead = false;
        }
    }
}