namespace CatchButton
{
    partial class stage1
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
            t_button = new Button();
            SuspendLayout();
            // 
            // t_button
            // 
            t_button.BackColor = Color.Black;
            t_button.ForeColor = Color.White;
            t_button.Location = new Point(1530, 255);
            t_button.Name = "t_button";
            t_button.Size = new Size(348, 145);
            t_button.TabIndex = 0;
            t_button.Text = "나를 잡아봐";
            t_button.UseVisualStyleBackColor = false;
            t_button.Click += t_button_Click;
            t_button.MouseEnter += t_button_MouseEnter;
            // 
            // stage1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1890, 924);
            Controls.Add(t_button);
            Name = "stage1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button t_button;
    }
}
