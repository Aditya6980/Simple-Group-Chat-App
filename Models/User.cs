namespace Simple_Group_Chat_App.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string CollegeName { get; set; }
        public string PasswordHash { get; set; }

        //Generic function
        //For one to many RelationShip(User can be part of many groups)
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
