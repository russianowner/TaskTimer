namespace TaskTimer.Models
{
    public class TaskItem
    {
        public string Title { get; set; } = "";
        public DateTime TargetTime { get; set; }
        public bool IsCompleted { get; set; }
        public override string ToString()
        {
            string status = IsCompleted ? "✅" : "⏳";
            return $"{status} {Title} — {TargetTime:HH:mm}";
        }
    }
}
