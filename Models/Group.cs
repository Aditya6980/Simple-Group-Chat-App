namespace Simple_Group_Chat_App.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
