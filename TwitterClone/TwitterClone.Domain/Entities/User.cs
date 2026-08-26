namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        //private string _userName;
        private string _email;
        //private DateTime _createdAt;
        //private DateTime _modifiedAt;
        public Guid Id
        {
            get { return _id; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        //public string UserName
        //{
        //    get{ return _userName; }
        //    set { _userName = value; }
        //}
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}


