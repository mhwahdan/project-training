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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            submitBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(312, 230);
            submitBtn.Margin = new Padding(5, 6, 5, 6);
            submitBtn.Location = new Point(168, 108);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(201, 88);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "lolo";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.MouseClick += submitBtn_MouseClick;
            submitBtn.MouseLeave += submitBtn_MouseLeave;
            submitBtn.MouseHover += submitBtn_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 292);
            Controls.Add(submitBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitBtn;
        private TextBox textBox1;
    }
}
