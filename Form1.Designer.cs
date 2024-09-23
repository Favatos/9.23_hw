namespace _9._23_hw
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
            CloseApp = new Button();
            MoveButton = new Button();
            MoveForm = new Button();
            ChangeColor = new Button();
            SuspendLayout();
            // 
            // CloseApp
            // 
            CloseApp.Location = new Point(50, 160);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new Size(121, 66);
            CloseApp.TabIndex = 0;
            CloseApp.Text = "Close App";
            CloseApp.UseVisualStyleBackColor = true;
            CloseApp.Click += CloseApp_Click;
            // 
            // MoveButton
            // 
            MoveButton.Location = new Point(242, 158);
            MoveButton.Name = "MoveButton";
            MoveButton.Size = new Size(128, 70);
            MoveButton.TabIndex = 1;
            MoveButton.Text = "Move button";
            MoveButton.UseVisualStyleBackColor = true;
            MoveButton.Click += MoveButton_Click;
            // 
            // MoveForm
            // 
            MoveForm.Location = new Point(433, 158);
            MoveForm.Name = "MoveForm";
            MoveForm.Size = new Size(121, 70);
            MoveForm.TabIndex = 2;
            MoveForm.Text = "Move form";
            MoveForm.UseVisualStyleBackColor = true;
            MoveForm.Click += MoveForm_Click;
            // 
            // ChangeColor
            // 
            ChangeColor.BackColor = Color.Red;
            ChangeColor.Location = new Point(612, 158);
            ChangeColor.Name = "ChangeColor";
            ChangeColor.Size = new Size(126, 70);
            ChangeColor.TabIndex = 3;
            ChangeColor.Text = "traffic light";
            ChangeColor.UseVisualStyleBackColor = false;
            ChangeColor.Click += ChangeColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeColor);
            Controls.Add(MoveForm);
            Controls.Add(MoveButton);
            Controls.Add(CloseApp);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseApp;
        private Button MoveButton;
        private Button MoveForm;
        private Button ChangeColor;
    }
}
