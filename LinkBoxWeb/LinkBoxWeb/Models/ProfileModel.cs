<<<<<<< Updated upstream
﻿namespace LinkBoxWeb.Models
{
    internal class ProfileModel
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
=======
﻿

public class ProfileModel{
    public string Subject { get; set; }
    public string Topic { get; set; }
    public string Chapter { get; set; }
    public bool isExercise { get; set; }

    public string ResourceType { get; set; }

    public string Description { get; set; }

    public string Content { get; set; }

    public int Votes { get; set; }

    public string Creator { get; set; }
>>>>>>> Stashed changes
}