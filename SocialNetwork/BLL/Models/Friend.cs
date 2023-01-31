using System.Collections.Generic;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Friend(
            int id,
            string firstName,
            string lastName
            )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
