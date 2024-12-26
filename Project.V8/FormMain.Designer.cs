namespace Project.V8
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            panelTwo_SNM = new Panel();
            groupBoxData_SNM = new GroupBox();
            tabControlData_SNM = new TabControl();
            autoTab_SNM = new TabPage();
            dataGridViewAuto_SNM = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnDigits = new DataGridViewTextBoxColumn();
            ColumnMark = new DataGridViewTextBoxColumn();
            ColumnCondition = new DataGridViewTextBoxColumn();
            ColumnPlace = new DataGridViewTextBoxColumn();
            ColumnSpeed = new DataGridViewTextBoxColumn();
            ColumnLoad = new DataGridViewTextBoxColumn();
            ColumnFuel = new DataGridViewTextBoxColumn();
            changeAutoTab_SNM = new TabPage();
            dataGridViewChanged_SNM = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewChange_SNM = new DataGridView();
            menuStripTools_SNM = new MenuStrip();
            programtoolStripMenuItem_SNM = new ToolStripMenuItem();
            StatisticToolStripMenuItem_SNM = new ToolStripMenuItem();
            exitToolStripMenuItem_SNM = new ToolStripMenuItem();
            helpToolStripMenuItem_SNM = new ToolStripMenuItem();
            referenceToolStripMenuItem_SNM = new ToolStripMenuItem();
            guideToolStripMenuItem_SNM = new ToolStripMenuItem();
            panelOne_SNM = new Panel();
            groupBoxDataGridActions_SNM = new GroupBox();
            buttonRemove_SNM = new Button();
            buttonAdd_SNM = new Button();
            groupBoxFileActions_SNM = new GroupBox();
            buttonSave_SNM = new Button();
            buttonLoad_SNM = new Button();
            groupBoxSearch_SNM = new GroupBox();
            tabControlSearch_SNM = new TabControl();
            tabPage1 = new TabPage();
            buttonSearchNum_SNM = new Button();
            textBoxSearchNum_SNM = new TextBox();
            tabPage2 = new TabPage();
            buttonSearchCarNum_SNM = new Button();
            textBoxSearchCarNum_SNM = new TextBox();
            toolTipInfo_SNM = new ToolTip(components);
            saveFileDialogInfo_SNM = new SaveFileDialog();
            openFileDialogProject_SNM = new OpenFileDialog();
            panelTwo_SNM.SuspendLayout();
            groupBoxData_SNM.SuspendLayout();
            tabControlData_SNM.SuspendLayout();
            autoTab_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuto_SNM).BeginInit();
            changeAutoTab_SNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChanged_SNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChange_SNM).BeginInit();
            menuStripTools_SNM.SuspendLayout();
            panelOne_SNM.SuspendLayout();
            groupBoxDataGridActions_SNM.SuspendLayout();
            groupBoxFileActions_SNM.SuspendLayout();
            groupBoxSearch_SNM.SuspendLayout();
            tabControlSearch_SNM.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTwo_SNM
            // 
            panelTwo_SNM.Controls.Add(groupBoxData_SNM);
            panelTwo_SNM.Dock = DockStyle.Top;
            panelTwo_SNM.Location = new Point(0, 24);
            panelTwo_SNM.Name = "panelTwo_SNM";
            panelTwo_SNM.Size = new Size(738, 319);
            panelTwo_SNM.TabIndex = 5;
            // 
            // groupBoxData_SNM
            // 
            groupBoxData_SNM.Controls.Add(tabControlData_SNM);
            groupBoxData_SNM.Dock = DockStyle.Fill;
            groupBoxData_SNM.Location = new Point(0, 0);
            groupBoxData_SNM.Name = "groupBoxData_SNM";
            groupBoxData_SNM.Size = new Size(738, 319);
            groupBoxData_SNM.TabIndex = 0;
            groupBoxData_SNM.TabStop = false;
            groupBoxData_SNM.Text = "Данные";
            // 
            // tabControlData_SNM
            // 
            tabControlData_SNM.Controls.Add(autoTab_SNM);
            tabControlData_SNM.Controls.Add(changeAutoTab_SNM);
            tabControlData_SNM.Dock = DockStyle.Fill;
            tabControlData_SNM.Location = new Point(3, 19);
            tabControlData_SNM.Name = "tabControlData_SNM";
            tabControlData_SNM.SelectedIndex = 0;
            tabControlData_SNM.Size = new Size(732, 297);
            tabControlData_SNM.TabIndex = 0;
            tabControlData_SNM.Tag = "";
            tabControlData_SNM.SelectedIndexChanged += tabControlData_SNM_SelectedIndexChanged;
            // 
            // autoTab_SNM
            // 
            autoTab_SNM.Controls.Add(dataGridViewAuto_SNM);
            autoTab_SNM.Location = new Point(4, 24);
            autoTab_SNM.Name = "autoTab_SNM";
            autoTab_SNM.Padding = new Padding(3);
            autoTab_SNM.Size = new Size(724, 269);
            autoTab_SNM.TabIndex = 0;
            autoTab_SNM.Text = "Автопарк";
            autoTab_SNM.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAuto_SNM
            // 
            dataGridViewAuto_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuto_SNM.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnDigits, ColumnMark, ColumnCondition, ColumnPlace, ColumnSpeed, ColumnLoad, ColumnFuel });
            dataGridViewAuto_SNM.Dock = DockStyle.Fill;
            dataGridViewAuto_SNM.Location = new Point(3, 3);
            dataGridViewAuto_SNM.Name = "dataGridViewAuto_SNM";
            dataGridViewAuto_SNM.ReadOnly = true;
            dataGridViewAuto_SNM.RowHeadersVisible = false;
            dataGridViewAuto_SNM.Size = new Size(718, 263);
            dataGridViewAuto_SNM.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "№";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.Width = 30;
            // 
            // ColumnDigits
            // 
            ColumnDigits.HeaderText = "Знаки";
            ColumnDigits.Name = "ColumnDigits";
            ColumnDigits.ReadOnly = true;
            ColumnDigits.Width = 60;
            // 
            // ColumnMark
            // 
            ColumnMark.HeaderText = "Марка";
            ColumnMark.Name = "ColumnMark";
            ColumnMark.ReadOnly = true;
            ColumnMark.Width = 60;
            // 
            // ColumnCondition
            // 
            ColumnCondition.HeaderText = "Тех. Состояние";
            ColumnCondition.Name = "ColumnCondition";
            ColumnCondition.ReadOnly = true;
            // 
            // ColumnPlace
            // 
            ColumnPlace.HeaderText = "Место";
            ColumnPlace.Name = "ColumnPlace";
            ColumnPlace.ReadOnly = true;
            ColumnPlace.Width = 50;
            // 
            // ColumnSpeed
            // 
            ColumnSpeed.HeaderText = "Скорость(Км/ч)";
            ColumnSpeed.Name = "ColumnSpeed";
            ColumnSpeed.ReadOnly = true;
            // 
            // ColumnLoad
            // 
            ColumnLoad.HeaderText = "Грузоподъемность(Т)";
            ColumnLoad.Name = "ColumnLoad";
            ColumnLoad.ReadOnly = true;
            ColumnLoad.Width = 130;
            // 
            // ColumnFuel
            // 
            ColumnFuel.HeaderText = "Расход топлива(л/100км)";
            ColumnFuel.Name = "ColumnFuel";
            ColumnFuel.ReadOnly = true;
            ColumnFuel.Width = 120;
            // 
            // changeAutoTab_SNM
            // 
            changeAutoTab_SNM.Controls.Add(dataGridViewChanged_SNM);
            changeAutoTab_SNM.Controls.Add(dataGridViewChange_SNM);
            changeAutoTab_SNM.Location = new Point(4, 24);
            changeAutoTab_SNM.Name = "changeAutoTab_SNM";
            changeAutoTab_SNM.Padding = new Padding(3);
            changeAutoTab_SNM.Size = new Size(815, 269);
            changeAutoTab_SNM.TabIndex = 1;
            changeAutoTab_SNM.Text = "Изменения в таблице";
            changeAutoTab_SNM.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChanged_SNM
            // 
            dataGridViewChanged_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChanged_SNM.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridViewChanged_SNM.Dock = DockStyle.Fill;
            dataGridViewChanged_SNM.Location = new Point(3, 3);
            dataGridViewChanged_SNM.Name = "dataGridViewChanged_SNM";
            dataGridViewChanged_SNM.RowHeadersVisible = false;
            dataGridViewChanged_SNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewChanged_SNM.Size = new Size(809, 263);
            dataGridViewChanged_SNM.TabIndex = 1;
            dataGridViewChanged_SNM.CellBeginEdit += dataGridViewChanged_SNM_CellBeginEdit;
            dataGridViewChanged_SNM.CellEndEdit += dataGridViewChanged_SNM_CellEndEdit;
            dataGridViewChanged_SNM.EditingControlShowing += dataGridViewChanged_SNM_EditingControlShowing;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "№";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Знаки";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Марка";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Тех. Состояние";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Место";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Скорость(Км/ч)";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Грузоподъемность(Т)";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Расход топлива(л/100км)";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewChange_SNM
            // 
            dataGridViewChange_SNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChange_SNM.Dock = DockStyle.Fill;
            dataGridViewChange_SNM.Location = new Point(3, 3);
            dataGridViewChange_SNM.Name = "dataGridViewChange_SNM";
            dataGridViewChange_SNM.Size = new Size(809, 263);
            dataGridViewChange_SNM.TabIndex = 0;
            // 
            // menuStripTools_SNM
            // 
            menuStripTools_SNM.Items.AddRange(new ToolStripItem[] { programtoolStripMenuItem_SNM, helpToolStripMenuItem_SNM });
            menuStripTools_SNM.Location = new Point(0, 0);
            menuStripTools_SNM.Name = "menuStripTools_SNM";
            menuStripTools_SNM.Size = new Size(738, 24);
            menuStripTools_SNM.TabIndex = 7;
            menuStripTools_SNM.Text = "menuStrip1";
            // 
            // programtoolStripMenuItem_SNM
            // 
            programtoolStripMenuItem_SNM.DropDownItems.AddRange(new ToolStripItem[] { StatisticToolStripMenuItem_SNM, exitToolStripMenuItem_SNM });
            programtoolStripMenuItem_SNM.Name = "programtoolStripMenuItem_SNM";
            programtoolStripMenuItem_SNM.Size = new Size(84, 20);
            programtoolStripMenuItem_SNM.Text = "Программа";
            // 
            // StatisticToolStripMenuItem_SNM
            // 
            StatisticToolStripMenuItem_SNM.Name = "StatisticToolStripMenuItem_SNM";
            StatisticToolStripMenuItem_SNM.Size = new Size(135, 22);
            StatisticToolStripMenuItem_SNM.Text = "Статистика";
            StatisticToolStripMenuItem_SNM.Click += statsToolStripMenuItem_SNM_Click;
            // 
            // exitToolStripMenuItem_SNM
            // 
            exitToolStripMenuItem_SNM.Name = "exitToolStripMenuItem_SNM";
            exitToolStripMenuItem_SNM.Size = new Size(135, 22);
            exitToolStripMenuItem_SNM.Text = "Выход";
            exitToolStripMenuItem_SNM.Click += exitToolStripMenuItem_SNM_Click;
            // 
            // helpToolStripMenuItem_SNM
            // 
            helpToolStripMenuItem_SNM.DropDownItems.AddRange(new ToolStripItem[] { referenceToolStripMenuItem_SNM, guideToolStripMenuItem_SNM });
            helpToolStripMenuItem_SNM.Name = "helpToolStripMenuItem_SNM";
            helpToolStripMenuItem_SNM.Size = new Size(68, 20);
            helpToolStripMenuItem_SNM.Text = "Помощь";
            // 
            // referenceToolStripMenuItem_SNM
            // 
            referenceToolStripMenuItem_SNM.Name = "referenceToolStripMenuItem_SNM";
            referenceToolStripMenuItem_SNM.Size = new Size(162, 22);
            referenceToolStripMenuItem_SNM.Text = "О разработчике";
            referenceToolStripMenuItem_SNM.Click += infoToolStripMenuItem_SNM_Click;
            // 
            // guideToolStripMenuItem_SNM
            // 
            guideToolStripMenuItem_SNM.Name = "guideToolStripMenuItem_SNM";
            guideToolStripMenuItem_SNM.Size = new Size(162, 22);
            guideToolStripMenuItem_SNM.Text = "Руководство";
            guideToolStripMenuItem_SNM.Click += guideToolStripMenuItem_SNM_Click;
            // 
            // panelOne_SNM
            // 
            panelOne_SNM.Controls.Add(groupBoxDataGridActions_SNM);
            panelOne_SNM.Controls.Add(groupBoxFileActions_SNM);
            panelOne_SNM.Controls.Add(groupBoxSearch_SNM);
            panelOne_SNM.Dock = DockStyle.Bottom;
            panelOne_SNM.Location = new Point(0, 341);
            panelOne_SNM.Name = "panelOne_SNM";
            panelOne_SNM.Size = new Size(738, 109);
            panelOne_SNM.TabIndex = 8;
            // 
            // groupBoxDataGridActions_SNM
            // 
            groupBoxDataGridActions_SNM.Controls.Add(buttonRemove_SNM);
            groupBoxDataGridActions_SNM.Controls.Add(buttonAdd_SNM);
            groupBoxDataGridActions_SNM.Dock = DockStyle.Fill;
            groupBoxDataGridActions_SNM.Location = new Point(537, 0);
            groupBoxDataGridActions_SNM.Name = "groupBoxDataGridActions_SNM";
            groupBoxDataGridActions_SNM.Size = new Size(201, 109);
            groupBoxDataGridActions_SNM.TabIndex = 2;
            groupBoxDataGridActions_SNM.TabStop = false;
            groupBoxDataGridActions_SNM.Text = "Таблица";
            // 
            // buttonRemove_SNM
            // 
            buttonRemove_SNM.Enabled = false;
            buttonRemove_SNM.Image = Properties.Resources.icons5;
            buttonRemove_SNM.Location = new Point(106, 36);
            buttonRemove_SNM.Name = "buttonRemove_SNM";
            buttonRemove_SNM.Size = new Size(80, 54);
            buttonRemove_SNM.TabIndex = 3;
            buttonRemove_SNM.UseVisualStyleBackColor = true;
            buttonRemove_SNM.Click += buttonRemove_SNM_Click;
            buttonRemove_SNM.MouseEnter += buttonRemove_SNM_MouseEnter;
            // 
            // buttonAdd_SNM
            // 
            buttonAdd_SNM.Enabled = false;
            buttonAdd_SNM.Image = Properties.Resources.icons4;
            buttonAdd_SNM.Location = new Point(20, 36);
            buttonAdd_SNM.Name = "buttonAdd_SNM";
            buttonAdd_SNM.Size = new Size(80, 54);
            buttonAdd_SNM.TabIndex = 2;
            buttonAdd_SNM.UseVisualStyleBackColor = true;
            buttonAdd_SNM.Click += buttonAdd_SNM_Click;
            buttonAdd_SNM.MouseEnter += buttonAdd_SNM_MouseEnter;
            // 
            // groupBoxFileActions_SNM
            // 
            groupBoxFileActions_SNM.Controls.Add(buttonSave_SNM);
            groupBoxFileActions_SNM.Controls.Add(buttonLoad_SNM);
            groupBoxFileActions_SNM.Dock = DockStyle.Left;
            groupBoxFileActions_SNM.Location = new Point(299, 0);
            groupBoxFileActions_SNM.Name = "groupBoxFileActions_SNM";
            groupBoxFileActions_SNM.Size = new Size(238, 109);
            groupBoxFileActions_SNM.TabIndex = 1;
            groupBoxFileActions_SNM.TabStop = false;
            groupBoxFileActions_SNM.Text = "Файл";
            // 
            // buttonSave_SNM
            // 
            buttonSave_SNM.Enabled = false;
            buttonSave_SNM.Image = Properties.Resources.icons3;
            buttonSave_SNM.Location = new Point(146, 29);
            buttonSave_SNM.Name = "buttonSave_SNM";
            buttonSave_SNM.Size = new Size(80, 61);
            buttonSave_SNM.TabIndex = 3;
            buttonSave_SNM.UseVisualStyleBackColor = true;
            buttonSave_SNM.Click += buttonSave_SNM_Click;
            buttonSave_SNM.MouseEnter += buttonSave_SNM_MouseEnter;
            // 
            // buttonLoad_SNM
            // 
            buttonLoad_SNM.Image = Properties.Resources.icons1;
            buttonLoad_SNM.Location = new Point(36, 22);
            buttonLoad_SNM.Name = "buttonLoad_SNM";
            buttonLoad_SNM.Size = new Size(80, 74);
            buttonLoad_SNM.TabIndex = 2;
            buttonLoad_SNM.UseVisualStyleBackColor = true;
            buttonLoad_SNM.Click += buttonLoad_SNM_Click;
            buttonLoad_SNM.MouseEnter += buttonLoad_SNM_MouseEnter;
            // 
            // groupBoxSearch_SNM
            // 
            groupBoxSearch_SNM.Controls.Add(tabControlSearch_SNM);
            groupBoxSearch_SNM.Dock = DockStyle.Left;
            groupBoxSearch_SNM.Location = new Point(0, 0);
            groupBoxSearch_SNM.Name = "groupBoxSearch_SNM";
            groupBoxSearch_SNM.Size = new Size(299, 109);
            groupBoxSearch_SNM.TabIndex = 0;
            groupBoxSearch_SNM.TabStop = false;
            groupBoxSearch_SNM.Text = "Поиск по:";
            // 
            // tabControlSearch_SNM
            // 
            tabControlSearch_SNM.Controls.Add(tabPage1);
            tabControlSearch_SNM.Controls.Add(tabPage2);
            tabControlSearch_SNM.Dock = DockStyle.Fill;
            tabControlSearch_SNM.Location = new Point(3, 19);
            tabControlSearch_SNM.Name = "tabControlSearch_SNM";
            tabControlSearch_SNM.SelectedIndex = 0;
            tabControlSearch_SNM.Size = new Size(293, 87);
            tabControlSearch_SNM.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonSearchNum_SNM);
            tabPage1.Controls.Add(textBoxSearchNum_SNM);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(285, 59);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Номеру в списке";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSearchNum_SNM
            // 
            buttonSearchNum_SNM.Enabled = false;
            buttonSearchNum_SNM.Image = Properties.Resources.img_icons8;
            buttonSearchNum_SNM.Location = new Point(185, 3);
            buttonSearchNum_SNM.Name = "buttonSearchNum_SNM";
            buttonSearchNum_SNM.Size = new Size(80, 53);
            buttonSearchNum_SNM.TabIndex = 1;
            buttonSearchNum_SNM.UseVisualStyleBackColor = true;
            buttonSearchNum_SNM.Click += buttonSearchNum_SNM_Click;
            buttonSearchNum_SNM.MouseEnter += buttonSearchNum_SNM_MouseEnter;
            // 
            // textBoxSearchNum_SNM
            // 
            textBoxSearchNum_SNM.Location = new Point(6, 6);
            textBoxSearchNum_SNM.Name = "textBoxSearchNum_SNM";
            textBoxSearchNum_SNM.Size = new Size(147, 23);
            textBoxSearchNum_SNM.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonSearchCarNum_SNM);
            tabPage2.Controls.Add(textBoxSearchCarNum_SNM);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(285, 59);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Номеру машины";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSearchCarNum_SNM
            // 
            buttonSearchCarNum_SNM.Image = Properties.Resources.img_icons8;
            buttonSearchCarNum_SNM.Location = new Point(185, 3);
            buttonSearchCarNum_SNM.Name = "buttonSearchCarNum_SNM";
            buttonSearchCarNum_SNM.Size = new Size(80, 53);
            buttonSearchCarNum_SNM.TabIndex = 2;
            buttonSearchCarNum_SNM.UseVisualStyleBackColor = true;
            buttonSearchCarNum_SNM.Click += buttonSearchCarNum_SNM_Click;
            buttonSearchCarNum_SNM.MouseEnter += buttonSearchCarNum_SNM_Click;
            // 
            // textBoxSearchCarNum_SNM
            // 
            textBoxSearchCarNum_SNM.Location = new Point(6, 6);
            textBoxSearchCarNum_SNM.Name = "textBoxSearchCarNum_SNM";
            textBoxSearchCarNum_SNM.Size = new Size(147, 23);
            textBoxSearchCarNum_SNM.TabIndex = 1;
            // 
            // toolTipInfo_SNM
            // 
            toolTipInfo_SNM.IsBalloon = true;
            toolTipInfo_SNM.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogProject_SNM
            // 
            openFileDialogProject_SNM.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(panelOne_SNM);
            Controls.Add(panelTwo_SNM);
            Controls.Add(menuStripTools_SNM);
            MainMenuStrip = menuStripTools_SNM;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автотранспортное предприятие";
            Load += FormMain_Load;
            panelTwo_SNM.ResumeLayout(false);
            groupBoxData_SNM.ResumeLayout(false);
            tabControlData_SNM.ResumeLayout(false);
            autoTab_SNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuto_SNM).EndInit();
            changeAutoTab_SNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChanged_SNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChange_SNM).EndInit();
            menuStripTools_SNM.ResumeLayout(false);
            menuStripTools_SNM.PerformLayout();
            panelOne_SNM.ResumeLayout(false);
            groupBoxDataGridActions_SNM.ResumeLayout(false);
            groupBoxFileActions_SNM.ResumeLayout(false);
            groupBoxSearch_SNM.ResumeLayout(false);
            tabControlSearch_SNM.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTwo_SNM;
        private GroupBox groupBoxData_SNM;
        private MenuStrip menuStripTools_SNM;
        private TabControl tabControlData_SNM;
        private TabPage autoTab_SNM;
        private TabPage changeAutoTab_SNM;
        private Panel panelOne_SNM;
        private DataGridView dataGridViewAuto_SNM;
        private DataGridView dataGridViewChange_SNM;
        private GroupBox groupBoxSearch_SNM;
        private TabControl tabControlSearch_SNM;
        private TabPage tabPage1;
        private TextBox textBoxSearchNum_SNM;
        private TabPage tabPage2;
        private GroupBox groupBoxFileActions_SNM;
        private TextBox textBoxSearchCarNum_SNM;
        private GroupBox groupBoxHelp_SNM;
        private GroupBox groupBoxDataGridActions_SNM;
        private Button buttonRemove_SNM;
        private Button buttonAdd_SNM;
        private Button buttonSave_SNM;
        private Button buttonLoad_SNM;
        private Button buttonSearchNum_SNM;
        private Button buttonSearchCarNum_SNM;
        private ToolStripMenuItem programtoolStripMenuItem_SNM;
        private ToolStripMenuItem StatisticToolStripMenuItem_SNM;
        private ToolStripMenuItem exitToolStripMenuItem_SNM;
        private ToolStripMenuItem helpToolStripMenuItem_SNM;
        private ToolStripMenuItem referenceToolStripMenuItem_SNM;
        private ToolStripMenuItem guideToolStripMenuItem_SNM;
        private ToolTip toolTipInfo_SNM;
        private SaveFileDialog saveFileDialogInfo_SNM;
        private OpenFileDialog openFileDialogProject_SNM;
        private DataGridView dataGridViewChanged_SNM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnDigits;
        private DataGridViewTextBoxColumn ColumnMark;
        private DataGridViewTextBoxColumn ColumnCondition;
        private DataGridViewTextBoxColumn ColumnPlace;
        private DataGridViewTextBoxColumn ColumnSpeed;
        private DataGridViewTextBoxColumn ColumnLoad;
        private DataGridViewTextBoxColumn ColumnFuel;
    }
}
