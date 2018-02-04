using System.Collections.Generic;

public class my {
    public string Subject { get; set; }
    public string Topic { get; set; }
    public string Chapter { get; set; }
    public bool isExercise { get; set; }

    public string Description { get; set; }

    public string Content { get; set; }

    List<string> Tags { get; set; }
    public int Votes { get; set; }

    public string Creator { get; set; }
}