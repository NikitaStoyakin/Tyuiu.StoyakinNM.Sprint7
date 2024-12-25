namespace Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxReference_SNM = new PictureBox();
            textBoxRefernce_SNM = new TextBox();
            buttonReferenceDone_SNM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReference_SNM).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxReference_SNM
            // 
            pictureBoxReference_SNM.Image = Properties.Resources.p_DSC0978_kopia__2_1;
            pictureBoxReference_SNM.Location = new Point(43, 54);
            pictureBoxReference_SNM.Name = "pictureBoxReference_SNM";
            pictureBoxReference_SNM.Size = new Size(104, 131);
            pictureBoxReference_SNM.TabIndex = 0;
            pictureBoxReference_SNM.TabStop = false;
            // 
            // textBoxRefernce_SNM
            // 
            textBoxRefernce_SNM.Location = new Point(196, 12);
            textBoxRefernce_SNM.MinimumSize = new Size(350, 220);
            textBoxRefernce_SNM.Multiline = true;
            textBoxRefernce_SNM.Name = "textBoxRefernce_SNM";
            textBoxRefernce_SNM.ReadOnly = true;
            textBoxRefernce_SNM.Size = new Size(350, 220);
            textBoxRefernce_SNM.TabIndex = 1;
            textBoxRefernce_SNM.Text = resources.GetString("textBoxRefernce_SNM.Text");
            // 
            // buttonReferenceDone_SNM
            // 
            buttonReferenceDone_SNM.Location = new Point(472, 262);
            buttonReferenceDone_SNM.Name = "buttonReferenceDone_SNM";
            buttonReferenceDone_SNM.Size = new Size(75, 23);
            buttonReferenceDone_SNM.TabIndex = 2;
            buttonReferenceDone_SNM.Text = "ОК";
            buttonReferenceDone_SNM.UseVisualStyleBackColor = true;
            buttonReferenceDone_SNM.Click += buttonReferenceDone_SNM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 297);
            Controls.Add(buttonReferenceDone_SNM);
            Controls.Add(textBoxRefernce_SNM);
            Controls.Add(pictureBoxReference_SNM);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxReference_SNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxReference_SNM;
        private TextBox textBoxRefernce_SNM;
        private Button buttonReferenceDone_SNM;
    }
}