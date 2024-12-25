using Tyuiu.StoyakinNM.Sprint7.Project.V8.Lib;
namespace Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogProject_SNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogInfo_SNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }
        DataService ds = new DataService();
        public string? openFilePath;
        public bool fileOpened = false;
        AutoCompleteStringCollection driverNumComplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autoNumComplete = new AutoCompleteStringCollection();
        public int cellInt = 0;
        public string? cellString = String.Empty;
        private void infoToolStripMenuItem_SNM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_SNM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statsToolStripMenuItem_SNM_Click(object sender, EventArgs e)
        {
            FormStat formStatistics = new FormStat(dataGridViewChanged_SNM);
            formStatistics.ShowDialog();
        }

        private void guideToolStripMenuItem_SNM_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
        private void buttonLoad_SNM_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialogProject_SNM.ShowDialog();
                openFilePath = openFileDialogProject_SNM.FileName;
                List<string[]> gridInfo = ds.LoadDataFromFile(openFilePath);
                this.dataGridViewAuto_SNM.Rows.Clear();
                this.dataGridViewAuto_SNM.RowCount = gridInfo.Count;
                this.dataGridViewChanged_SNM.Rows.Clear();
                this.dataGridViewChanged_SNM.RowCount = gridInfo.Count;
                this.dataGridViewAuto_SNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewChanged_SNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < gridInfo.Count; i++)
                {
                    for (int j = 0; j < gridInfo[0].Length; j++)
                    {
                        if (j == 0 || j > 4)
                        {
                            this.dataGridViewAuto_SNM.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            this.dataGridViewChanged_SNM.Rows[i].Cells[j].Value = Convert.ToInt32(gridInfo[i][j]);
                            this.dataGridViewAuto_SNM.Columns[j].ValueType = typeof(int);
                            this.dataGridViewChanged_SNM.Columns[j].ValueType = typeof(int);

                        }
                        else
                        {
                            this.dataGridViewAuto_SNM.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewChanged_SNM.Rows[i].Cells[j].Value = gridInfo[i][j].ToString().ToUpper();
                            this.dataGridViewAuto_SNM.Columns[j].ValueType = typeof(string);
                            this.dataGridViewChanged_SNM.Columns[j].ValueType = typeof(string);
                        }
                    }
                }

                for (int i = 0; i < dataGridViewAuto_SNM.RowCount; i++)
                {
                    driverNumComplete.Add(this.dataGridViewAuto_SNM.Rows[i].Cells[0].Value.ToString());
                    autoNumComplete.Add(this.dataGridViewAuto_SNM.Rows[i].Cells[1].Value.ToString());
                }
                this.textBoxSearchNum_SNM.AutoCompleteCustomSource = driverNumComplete;
                this.textBoxSearchNum_SNM.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearchNum_SNM.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBoxSearchCarNum_SNM.AutoCompleteCustomSource = autoNumComplete;
                this.textBoxSearchCarNum_SNM.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.textBoxSearchCarNum_SNM.AutoCompleteSource = AutoCompleteSource.CustomSource;
                fileOpened = true;
                this.buttonSave_SNM.Enabled = true;
                this.StatisticToolStripMenuItem_SNM.Enabled = true;
                this.tabControlSearch_SNM.Enabled = true;
                this.buttonSearchNum_SNM.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchNum_SNM_Click(object sender, EventArgs e)
        {
            this.textBoxSearchCarNum_SNM.AutoCompleteMode = AutoCompleteMode.Suggest;
            string searchValue = this.textBoxSearchNum_SNM.Text;
            switch (this.tabControlData_SNM.SelectedIndex)
            {
                case 0:
                    Search(this.dataGridViewAuto_SNM, searchValue, 0);
                    break;
                case 1:
                    Search(this.dataGridViewChanged_SNM, searchValue, 0);
                    break;
            }
        }
        private void buttonSearchCarNum_SNM_Click(object sender, EventArgs e)
        {
            string searchValue = this.textBoxSearchCarNum_SNM.Text;
            switch (this.tabControlData_SNM
                .SelectedIndex)
            {
                case 0:
                    Search(this.dataGridViewAuto_SNM, searchValue, 1);
                    break;
                case 1:
                    Search(this.dataGridViewChanged_SNM, searchValue, 1);
                    break;
            }
        }

        private void buttonSave_SNM_Click(object sender, EventArgs e)
        {
            this.saveFileDialogInfo_SNM.FileName = "OutPutAutoFactory.csv";
            this.saveFileDialogInfo_SNM.InitialDirectory = Directory.GetCurrentDirectory();

            string path = "C:\\DataSprint7\\OutPutAuto.csv";
            if (File.Exists(path)) { File.Delete(path); }

            int row = this.dataGridViewChanged_SNM.RowCount;
            int column = this.dataGridViewChanged_SNM.ColumnCount;
            string str = "";
            if (this.saveFileDialogInfo_SNM.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (this.dataGridViewChanged_SNM.Rows[i].Cells[j].Style.BackColor == Color.OrangeRed) break;

                        if (j == column - 1)
                        {
                            str += this.dataGridViewChanged_SNM.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            str += this.dataGridViewChanged_SNM.Rows[i].Cells[j].Value.ToString() + ";";
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[1]).MaxInputLength = 6;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[2]).MaxInputLength = 20;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[3]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[4]).MaxInputLength = 30;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[5]).MaxInputLength = 3;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[6]).MaxInputLength = 4;
            ((DataGridViewTextBoxColumn)dataGridViewChanged_SNM.Columns[7]).MaxInputLength = 5;



            this.BeginInvoke(new Action(() =>
            {
                buttonLoad_SNM.Focus();
            }));
        }

        private void dataGridViewChanged_SNM_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isInt = cellInt != 0;
            bool isString = !isInt;
            try
            {
                if (!String.IsNullOrEmpty(this.dataGridViewChanged_SNM.CurrentCell.Value.ToString()) && !Convert.IsDBNull(this.dataGridViewChanged_SNM.CurrentCell.Value) && this.dataGridViewChanged_SNM.CurrentCell.Style.BackColor != Color.Aqua)
                {
                    if ((isInt && Convert.ToInt32(this.dataGridViewChanged_SNM.CurrentCell.Value) != cellInt) || (isString && this.dataGridViewChanged_SNM.CurrentCell.Value.ToString() != cellString))
                    {
                        this.dataGridViewChanged_SNM.CurrentCell.Style.BackColor = Color.Green;
                        if (e.ColumnIndex == 0)
                        {
                            driverNumComplete.Remove(cellInt.ToString());
                            driverNumComplete.Add(this.dataGridViewChanged_SNM.CurrentCell.Value.ToString());
                        }
                        if (e.ColumnIndex == 1)
                        {
                            autoNumComplete.Remove(cellString);
                            autoNumComplete.Add(this.dataGridViewChanged_SNM.CurrentCell.Value.ToString());
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                this.dataGridViewChanged_SNM.CurrentCell.Value = cellString;
                cellString = string.Empty;
            }
            finally
            {
                if (Convert.IsDBNull(this.dataGridViewChanged_SNM.CurrentCell.Value))
                {
                    if (cellInt != 0)
                    {
                        this.dataGridViewChanged_SNM.CurrentCell.Value = cellInt;
                        cellInt = 0;
                    }
                }
            }

        }

        private void NumInput(object? sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void StringInput(object? sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '-' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewChanged_SNM_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            bool isCellString = (this.dataGridViewChanged_SNM.CurrentCell.ValueType == typeof(string));
            bool isAutoNum = (this.dataGridViewChanged_SNM.CurrentCell.ColumnIndex == 1);
            if (e.Control is DataGridViewTextBoxEditingControl textBoxEditingControl)
            {
                textBoxEditingControl.KeyPress -= NumInput;
                textBoxEditingControl.KeyPress -= StringInput;
                if (isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += StringInput;
                }
                else if (!isCellString && !isAutoNum)
                {
                    textBoxEditingControl.KeyPress += NumInput;
                }

            }
        }

        private void tabControlData_SNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlData_SNM.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAdd_SNM.Enabled = true;
                this.buttonRemove_SNM.Enabled = true;
                this.buttonMarkDelete_SNM.Enabled = true;

            }
            else
            {
                this.buttonAdd_SNM.Enabled = false;
                this.buttonRemove_SNM.Enabled = false;
                this.dataGridViewChanged_SNM.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }

        private void buttonAdd_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Добавить";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSave_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Сохранить";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonLoad_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Загрузить";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;

        }
        private void buttonRemove_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Удалить";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchDriverNum_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Поиск";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonSearchAutoNum_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Поиск";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }
        private void buttonMarkDelete_SNM_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_SNM.ToolTipTitle = "Отметить ряд для удаления";
            toolTipInfo_SNM.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonMarkDelete_SNM_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewChanged_SNM.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                this.dataGridViewChanged_SNM.SelectionMode = DataGridViewSelectionMode.CellSelect;
                this.buttonRemove_SNM.Enabled = false;
                this.buttonRemove_SNM.Visible = false;
            }
            else
            {
                this.dataGridViewChanged_SNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.buttonRemove_SNM.Enabled = false;
                this.buttonRemove_SNM.Visible = false;
            }
        }

        private void dataGridViewChanged_SNM_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellInt = this.dataGridViewChanged_SNM.CurrentCell.ValueType == typeof(int) ? Convert.ToInt32(this.dataGridViewChanged_SNM.CurrentCell.Value) : 0;
            cellString = this.dataGridViewChanged_SNM.CurrentCell.ValueType == typeof(string) ? this.dataGridViewChanged_SNM.CurrentCell.Value.ToString() : String.Empty;
        }
        private void buttonAdd_SNM_Click(object sender, EventArgs e)
        {
            this.dataGridViewChanged_SNM.Rows.Add(0, "######", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", "НЕИЗВЕСТНО", 0, 0, 0);
            foreach (DataGridViewCell cell in this.dataGridViewChanged_SNM.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Blue;
            }
        }

        private void buttonRemove_SNM_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить данный ряд?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewChanged_SNM.SelectedRows)
                {
                    this.dataGridViewChanged_SNM.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
