namespace Simple_Group_Chat_App.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., Admin, Member

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
