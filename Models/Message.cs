namespace Simple_Group_Chat_App.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public Guid SenderId { get; set; }
        public User Sender { get; set; }

        public string Content { get; set; } // Can be text or URL
        public string? ImageUrl { get; set; } // Optional

        public DateTime Timestamp { get; set; }
    }
}
