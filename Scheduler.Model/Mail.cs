namespace Scheduler.Model
{
    public class Mail
    {
        public string Id;
        public string FirstName;
        public string LastName;
        public string DestinationMail;

        public Mail(string id, string firstName, string lastName, string destinationMail)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DestinationMail = destinationMail;
        }
    }
}
