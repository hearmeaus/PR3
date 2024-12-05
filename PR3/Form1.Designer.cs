namespace PR3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shapka = new Label();
            Output = new Label();
            SuspendLayout();
            // 
            // shapka
            // 
            shapka.BackColor = Color.White;
            shapka.Dock = DockStyle.Top;
            shapka.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            shapka.ImageAlign = ContentAlignment.TopCenter;
            shapka.Location = new Point(0, 0);
            shapka.Name = "shapka";
            shapka.Size = new Size(800, 72);
            shapka.TabIndex = 0;
            shapka.TextAlign = ContentAlignment.MiddleCenter;
            shapka.Click += shapka_Click;
            // 
            // Output
            // 
            Output.BackColor = Color.White;
            Output.Dock = DockStyle.Fill;
            Output.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Output.Location = new Point(0, 72);
            Output.Name = "Output";
            Output.Size = new Size(800, 378);
            Output.TabIndex = 1;
            Output.TextAlign = ContentAlignment.MiddleCenter;
            Output.Click += Output_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(shapka);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label shapka;
        private Label Output;
    }
}
