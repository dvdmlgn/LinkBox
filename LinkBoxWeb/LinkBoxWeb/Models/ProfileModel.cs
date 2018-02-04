
namespace LinkBoxWeb.Models
{
    public class ProfileModel
    {
        internal bool isExercise;

        public string Subject { get; set; }
        public string Topic { get; set; }
        public string Chapter { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
        public string ResourceType { get; set; }
        public string Content { get; set; }
    }
}