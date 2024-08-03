namespace project_training
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
            submitBtn = new Button();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(255, 157);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(201, 88);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "lolo";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.MouseLeave += submitBtn_MouseLeave;
            submitBtn.MouseHover += submitBtn_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button submitBtn;
    }
}
