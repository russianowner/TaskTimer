using TaskTimer.Models;
using TaskTimer.Services;
using System.Timers;

namespace TaskTimer
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<TaskItem> tasks = new();
        private System.Timers.Timer checkTimer;

        public Form()
        {
            InitializeComponent();
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnComplete.Click += btnComplete_Click;
            NotificationService.Init();
            TelegramService.Init("токенбота", 234324234); 
            tasks = TaskStorage.Load(); 
            UpdateList();
            checkTimer = new System.Timers.Timer(1000);
            checkTimer.Elapsed += CheckTasks;
            checkTimer.Start();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введи название задачи :)");
                return;
            }
            var task = new TaskItem
            {
                Title = txtTitle.Text,
                TargetTime = timePicker.Value,
                IsCompleted = false
            };
            tasks.Add(task);
            TaskStorage.Save(tasks);
            UpdateList();
            txtTitle.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex < 0) return;
            tasks.RemoveAt(listTasks.SelectedIndex);
            TaskStorage.Save(tasks);
            UpdateList();
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex < 0) return;
            tasks[listTasks.SelectedIndex].IsCompleted = true;
            TaskStorage.Save(tasks);
            UpdateList();
        }
        private async void CheckTasks(object sender, ElapsedEventArgs e)
        {
            try
            {
                foreach (var task in tasks.Where(t => !t.IsCompleted))
                {
                    if (DateTime.Now >= task.TargetTime)
                    {
                        task.IsCompleted = true;
                        NotificationService.Show("Напоминание", $"Пора выполнить задачу: {task.Title}");
                        if (checkTelegram.Checked)
                        {
                            await TelegramService.SendMessage($"⏰ Пора выполнить задачу: {task.Title}");
                        }
                        TaskStorage.Save(tasks);
                        UpdateListSafe();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void UpdateList()
        {
            listTasks.Items.Clear();
            foreach (var t in tasks)
                listTasks.Items.Add(t.ToString());
        }
        private void UpdateListSafe()
        {
            if (InvokeRequired)
                Invoke(UpdateList);
            else
                UpdateList();
        }
        private CheckBox checkTelegram;
    }
}
