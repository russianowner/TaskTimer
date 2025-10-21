using TaskTimer.Models;
using Newtonsoft.Json;

namespace TaskTimer.Services
{
    public static class TaskStorage
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.json");

        public static List<TaskItem> Load()
        {
            if (!File.Exists(filePath))
                return new List<TaskItem>();
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
        public static void Save(List<TaskItem> tasks)
        {
            Directory.CreateDirectory("data");
            var json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
