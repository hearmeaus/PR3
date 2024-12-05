namespace PR3
{
    partial class Form2
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
            shapka1 = new Label();
            Output1 = new Label();
            SuspendLayout();
            // 
            // shapka1
            // 
            shapka1.BackColor = Color.White;
            shapka1.Dock = DockStyle.Top;
            shapka1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            shapka1.ImageAlign = ContentAlignment.MiddleRight;
            shapka1.Location = new Point(0, 0);
            shapka1.Name = "shapka1";
            shapka1.Size = new Size(800, 97);
            shapka1.TabIndex = 0;
            shapka1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Output1
            // 
            Output1.BackColor = Color.White;
            Output1.Dock = DockStyle.Fill;
            Output1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Output1.Location = new Point(0, 97);
            Output1.Name = "Output1";
            Output1.Size = new Size(800, 353);
            Output1.TabIndex = 1;
            Output1.TextAlign = ContentAlignment.MiddleCenter;
            Output1.Click += Output1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output1);
            Controls.Add(shapka1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label shapka1;
        private Label Output1;
    }
}