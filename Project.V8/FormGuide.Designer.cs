namespace Project.V8
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBoxGuide_SNM = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxGuide_SNM
            // 
            textBoxGuide_SNM.Location = new Point(12, 12);
            textBoxGuide_SNM.Multiline = true;
            textBoxGuide_SNM.Name = "textBoxGuide_SNM";
            textBoxGuide_SNM.ReadOnly = true;
            textBoxGuide_SNM.Size = new Size(597, 230);
            textBoxGuide_SNM.TabIndex = 0;
            textBoxGuide_SNM.Text = resources.GetString("textBoxGuide_SNM.Text");
            // 
            // button1
            // 
            button1.Location = new Point(525, 248);
            button1.Name = "button1";
            button1.Size = new Size(84, 26);
            button1.TabIndex = 1;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClose_SNM_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 281);
            Controls.Add(button1);
            Controls.Add(textBoxGuide_SNM);
            MinimumSize = new Size(650, 320);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuide_SNM;
        private Button button1;
    }
}