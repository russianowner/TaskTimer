#nullable disable
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TaskTimer
{
    public partial class Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTitle;
        private DateTimePicker timePicker;
        private Button btnAdd;
        private ListBox listTasks;
        private Button btnComplete;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            timePicker = new DateTimePicker();
            btnAdd = new Button();
            listTasks = new ListBox();
            btnComplete = new Button();
            btnDelete = new Button();
            checkTelegram = new CheckBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(24, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 23);
            txtTitle.TabIndex = 0;
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(292, 20);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(80, 23);
            timePicker.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(360, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить задачу";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // listTasks
            // 
            listTasks.FormattingEnabled = true;
            listTasks.ItemHeight = 15;
            listTasks.Location = new Point(24, 95);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(331, 139);
            listTasks.TabIndex = 3;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(12, 245);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(161, 38);
            btnComplete.TabIndex = 4;
            btnComplete.Text = "Отметить выполненной";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(217, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 38);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // checkTelegram
            // 
            checkTelegram.AutoSize = true;
            checkTelegram.Location = new Point(102, 289);
            checkTelegram.Name = "checkTelegram";
            checkTelegram.Size = new Size(218, 19);
            checkTelegram.TabIndex = 6;
            checkTelegram.Text = "Разослать уведомление в Telegram";
            checkTelegram.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(checkTelegram);
            Controls.Add(btnDelete);
            Controls.Add(btnComplete);
            Controls.Add(listTasks);
            Controls.Add(btnAdd);
            Controls.Add(timePicker);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Timer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
