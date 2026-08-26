namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Content { get; set; }

        public Tweet() : base(Guid.NewGuid())
        {
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }
    }
}