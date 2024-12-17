namespace PR3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            head = new Label();
            add = new Button();
            change = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // head
            // 
            head.Dock = DockStyle.Top;
            head.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            head.Location = new Point(0, 0);
            head.Name = "head";
            head.Size = new Size(1052, 45);
            head.TabIndex = 0;
            head.Text = "Партнеры (Просмотр):";
            head.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // add
            // 
            add.BackColor = Color.LightCoral;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            add.Location = new Point(235, 9);
            add.Name = "add";
            add.Size = new Size(120, 29);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // change
            // 
            change.BackColor = Color.LightCoral;
            change.FlatStyle = FlatStyle.Flat;
            change.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            change.Location = new Point(382, 9);
            change.Name = "change";
            change.Size = new Size(141, 29);
            change.TabIndex = 2;
            change.Text = "Редактировать";
            change.UseVisualStyleBackColor = false;
            change.Click += change_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.LightCoral;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delete.Location = new Point(553, 9);
            delete.Name = "delete";
            delete.Size = new Size(96, 29);
            delete.TabIndex = 3;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1052, 629);
            Controls.Add(delete);
            Controls.Add(change);
            Controls.Add(add);
            Controls.Add(head);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form2";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label head;
        private Button add;
        private Button change;
        private Button delete;
    }
}