namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User() : base(Guid.NewGuid())
        {
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, Username: {Username}, Email: {Email}";
        }
    }
}