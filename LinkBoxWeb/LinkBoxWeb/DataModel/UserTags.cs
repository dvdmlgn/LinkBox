namespace LinkBoxWeb.DataModel
{
    public class UserTags
    {
        public int Id { get; set; }
        public Tag Tag { get; set; }
        public User User { get; set; }
    }
}