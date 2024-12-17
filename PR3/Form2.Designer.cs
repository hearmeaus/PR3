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
            headAdd = new Label();
            labelTypeOfPartnerId = new Label();
            labelName = new Label();
            labelAdress = new Label();
            labelTINN = new Label();
            labelNameOfDirector = new Label();
            labelPhone = new Label();
            labelMail = new Label();
            labelRating = new Label();
            inputTypeOfPartnerId = new TextBox();
            inputName = new TextBox();
            inputAdress = new TextBox();
            inputTINN = new TextBox();
            inputNameOfDirector = new TextBox();
            inputPhone = new TextBox();
            inpuMail = new TextBox();
            inputRating = new TextBox();
            buttonClose = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // headAdd
            // 
            headAdd.BackColor = Color.White;
            headAdd.Dock = DockStyle.Top;
            headAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            headAdd.Location = new Point(0, 0);
            headAdd.Name = "headAdd";
            headAdd.Size = new Size(800, 61);
            headAdd.TabIndex = 0;
            headAdd.Text = "Добавление:";
            headAdd.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelTypeOfPartnerId
            // 
            labelTypeOfPartnerId.AutoSize = true;
            labelTypeOfPartnerId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTypeOfPartnerId.Location = new Point(12, 114);
            labelTypeOfPartnerId.Name = "labelTypeOfPartnerId";
            labelTypeOfPartnerId.Size = new Size(181, 21);
            labelTypeOfPartnerId.TabIndex = 1;
            labelTypeOfPartnerId.Text = "Укажите тип партнера:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(12, 146);
            labelName.Name = "labelName";
            labelName.Size = new Size(186, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Укажите имя партнера:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAdress.Location = new Point(12, 179);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(199, 21);
            labelAdress.TabIndex = 3;
            labelAdress.Text = "Укажите адрес партнера:";
            // 
            // labelTINN
            // 
            labelTINN.AutoSize = true;
            labelTINN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTINN.Location = new Point(12, 210);
            labelTINN.Name = "labelTINN";
            labelTINN.Size = new Size(191, 21);
            labelTINN.TabIndex = 4;
            labelTINN.Text = "Укажите ИНН партнера:";
            // 
            // labelNameOfDirector
            // 
            labelNameOfDirector.AutoSize = true;
            labelNameOfDirector.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNameOfDirector.Location = new Point(12, 240);
            labelNameOfDirector.Name = "labelNameOfDirector";
            labelNameOfDirector.Size = new Size(197, 21);
            labelNameOfDirector.TabIndex = 5;
            labelNameOfDirector.Text = "Укажите имя директора:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPhone.Location = new Point(12, 272);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(235, 21);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Укажите телефон  директора:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMail.Location = new Point(12, 302);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(164, 21);
            labelMail.TabIndex = 7;
            labelMail.Text = "Укажите почту(mail):";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRating.Location = new Point(12, 332);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(142, 21);
            labelRating.TabIndex = 8;
            labelRating.Text = "Укажите рейтинг:";
            // 
            // inputTypeOfPartnerId
            // 
            inputTypeOfPartnerId.Location = new Point(199, 114);
            inputTypeOfPartnerId.Name = "inputTypeOfPartnerId";
            inputTypeOfPartnerId.Size = new Size(138, 23);
            inputTypeOfPartnerId.TabIndex = 9;
            // 
            // inputName
            // 
            inputName.Location = new Point(204, 143);
            inputName.Name = "inputName";
            inputName.Size = new Size(148, 23);
            inputName.TabIndex = 10;
            // 
            // inputAdress
            // 
            inputAdress.Location = new Point(213, 177);
            inputAdress.Name = "inputAdress";
            inputAdress.Size = new Size(207, 23);
            inputAdress.TabIndex = 11;
            // 
            // inputTINN
            // 
            inputTINN.Location = new Point(213, 210);
            inputTINN.Name = "inputTINN";
            inputTINN.Size = new Size(192, 23);
            inputTINN.TabIndex = 12;
            // 
            // inputNameOfDirector
            // 
            inputNameOfDirector.Location = new Point(211, 239);
            inputNameOfDirector.Name = "inputNameOfDirector";
            inputNameOfDirector.Size = new Size(209, 23);
            inputNameOfDirector.TabIndex = 13;
            // 
            // inputPhone
            // 
            inputPhone.Location = new Point(249, 272);
            inputPhone.Name = "inputPhone";
            inputPhone.Size = new Size(144, 23);
            inputPhone.TabIndex = 14;
            // 
            // inpuMail
            // 
            inpuMail.Location = new Point(178, 302);
            inpuMail.Name = "inpuMail";
            inpuMail.Size = new Size(159, 23);
            inpuMail.TabIndex = 15;
            // 
            // inputRating
            // 
            inputRating.Location = new Point(156, 330);
            inputRating.Name = "inputRating";
            inputRating.Size = new Size(100, 23);
            inputRating.TabIndex = 16;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.PeachPuff;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose.Location = new Point(118, 386);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 35);
            buttonClose.TabIndex = 17;
            buttonClose.Text = "CLOSE";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.PeachPuff;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK.Location = new Point(12, 386);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 35);
            buttonOK.TabIndex = 18;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK);
            Controls.Add(buttonClose);
            Controls.Add(inputRating);
            Controls.Add(inpuMail);
            Controls.Add(inputPhone);
            Controls.Add(inputNameOfDirector);
            Controls.Add(inputTINN);
            Controls.Add(inputAdress);
            Controls.Add(inputName);
            Controls.Add(inputTypeOfPartnerId);
            Controls.Add(labelRating);
            Controls.Add(labelMail);
            Controls.Add(labelPhone);
            Controls.Add(labelNameOfDirector);
            Controls.Add(labelTINN);
            Controls.Add(labelAdress);
            Controls.Add(labelName);
            Controls.Add(labelTypeOfPartnerId);
            Controls.Add(headAdd);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headAdd;
        private Label labelTypeOfPartnerId;
        private Label labelName;
        private Label labelAdress;
        private Label labelTINN;
        private Label labelNameOfDirector;
        private Label labelPhone;
        private Label labelMail;
        private Label labelRating;
        private TextBox inputTypeOfPartnerId;
        private TextBox inputName;
        private TextBox inputAdress;
        private TextBox inputTINN;
        private TextBox inputNameOfDirector;
        private TextBox inputPhone;
        private TextBox inpuMail;
        private TextBox inputRating;
        private Button buttonClose;
        private Button buttonOK;
    }
}