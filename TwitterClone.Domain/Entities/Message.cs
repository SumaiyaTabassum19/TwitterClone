namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }

        public bool IsRead
        {
            get { return _isRead; }
        }

        public Message(
            Guid senderId,
            Guid receiverId,
            string content)
        {
            _id = Guid.NewGuid();
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
            _sentAt = DateTime.UtcNow;
            _isRead = false;
        }
    }
}