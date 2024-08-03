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
            submitBtn.Location = new Point(192, 144);
            submitBtn.Margin = new Padding(3, 4, 3, 4);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(230, 117);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "lolo";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.MouseLeave += submitBtn_MouseLeave;
            submitBtn.MouseHover += submitBtn_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 389);
            Controls.Add(submitBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button submitBtn;
    }
}
