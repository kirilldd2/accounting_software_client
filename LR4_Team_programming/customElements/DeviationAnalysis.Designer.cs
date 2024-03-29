﻿
namespace LR4_Team_programming.customElements
{
    partial class DeviationAnalysis
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviationAnalysis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deviationPanel = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.table = new System.Windows.Forms.DataGridView();
            this.nameProductColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOKPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producedColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraSettingPanel = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDevTextBox = new System.Windows.Forms.TextBox();
            this.startDevTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.searchInAllDebCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.depLabel = new System.Windows.Forms.Label();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.timerForShiftingTable = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.deviationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.extraSettingPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deviationPanel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 690);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // deviationPanel
            // 
            this.deviationPanel.Controls.Add(this.printButton);
            this.deviationPanel.Controls.Add(this.progressBar);
            this.deviationPanel.Controls.Add(this.table);
            this.deviationPanel.Controls.Add(this.extraSettingPanel);
            this.deviationPanel.Controls.Add(this.groupBox3);
            this.deviationPanel.Controls.Add(this.headerLabel);
            this.deviationPanel.Location = new System.Drawing.Point(0, 0);
            this.deviationPanel.Name = "deviationPanel";
            this.deviationPanel.Size = new System.Drawing.Size(835, 690);
            this.deviationPanel.TabIndex = 2;
            this.deviationPanel.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.Location = new System.Drawing.Point(772, 15);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(50, 49);
            this.printButton.TabIndex = 23;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 204);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(805, 29);
            this.progressBar.Step = 300;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProductColoumn,
            this.codeOKPColumn,
            this.expectedColumn,
            this.producedColoumn,
            this.deviationColumn});
            this.table.Location = new System.Drawing.Point(17, 239);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(805, 451);
            this.table.TabIndex = 4;
            this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowsAdded);
            // 
            // nameProductColoumn
            // 
            this.nameProductColoumn.HeaderText = "Наименование продукта";
            this.nameProductColoumn.MinimumWidth = 6;
            this.nameProductColoumn.Name = "nameProductColoumn";
            this.nameProductColoumn.ReadOnly = true;
            // 
            // codeOKPColumn
            // 
            this.codeOKPColumn.HeaderText = "Код по ОКП";
            this.codeOKPColumn.MinimumWidth = 6;
            this.codeOKPColumn.Name = "codeOKPColumn";
            this.codeOKPColumn.ReadOnly = true;
            // 
            // expectedColumn
            // 
            this.expectedColumn.HeaderText = "По плану, шт";
            this.expectedColumn.MinimumWidth = 6;
            this.expectedColumn.Name = "expectedColumn";
            this.expectedColumn.ReadOnly = true;
            // 
            // producedColoumn
            // 
            this.producedColoumn.HeaderText = "Произведено, шт";
            this.producedColoumn.MinimumWidth = 6;
            this.producedColoumn.Name = "producedColoumn";
            this.producedColoumn.ReadOnly = true;
            // 
            // deviationColumn
            // 
            this.deviationColumn.HeaderText = "Отклонение, шт";
            this.deviationColumn.MinimumWidth = 6;
            this.deviationColumn.Name = "deviationColumn";
            this.deviationColumn.ReadOnly = true;
            // 
            // extraSettingPanel
            // 
            this.extraSettingPanel.Controls.Add(this.label4);
            this.extraSettingPanel.Controls.Add(this.label6);
            this.extraSettingPanel.Controls.Add(this.label3);
            this.extraSettingPanel.Controls.Add(this.label5);
            this.extraSettingPanel.Controls.Add(this.endDevTextBox);
            this.extraSettingPanel.Controls.Add(this.startDevTextBox);
            this.extraSettingPanel.Location = new System.Drawing.Point(17, 239);
            this.extraSettingPanel.Name = "extraSettingPanel";
            this.extraSettingPanel.Size = new System.Drawing.Size(805, 103);
            this.extraSettingPanel.TabIndex = 5;
            this.extraSettingPanel.TabStop = false;
            this.extraSettingPanel.Text = "Отклонения от плана:  ";
            this.extraSettingPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Верхняя граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Нижняя граница";
            // 
            // endDevTextBox
            // 
            this.endDevTextBox.Location = new System.Drawing.Point(555, 42);
            this.endDevTextBox.Name = "endDevTextBox";
            this.endDevTextBox.Size = new System.Drawing.Size(107, 27);
            this.endDevTextBox.TabIndex = 1;
            // 
            // startDevTextBox
            // 
            this.startDevTextBox.Location = new System.Drawing.Point(276, 42);
            this.startDevTextBox.Name = "startDevTextBox";
            this.startDevTextBox.Size = new System.Drawing.Size(107, 27);
            this.startDevTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.settingButton);
            this.groupBox3.Controls.Add(this.searchInAllDebCheckBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.startDate);
            this.groupBox3.Controls.Add(this.endDate);
            this.groupBox3.Controls.Add(this.depLabel);
            this.groupBox3.Controls.Add(this.depComboBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "поиск";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(764, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 17;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.Location = new System.Drawing.Point(764, 13);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(35, 35);
            this.settingButton.TabIndex = 16;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // searchInAllDebCheckBox
            // 
            this.searchInAllDebCheckBox.AutoSize = true;
            this.searchInAllDebCheckBox.Location = new System.Drawing.Point(493, 38);
            this.searchInAllDebCheckBox.Name = "searchInAllDebCheckBox";
            this.searchInAllDebCheckBox.Size = new System.Drawing.Size(151, 24);
            this.searchInAllDebCheckBox.TabIndex = 15;
            this.searchInAllDebCheckBox.Text = "По предприятию";
            this.searchInAllDebCheckBox.UseVisualStyleBackColor = true;
            this.searchInAllDebCheckBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Окончание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Начало";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd MMMM yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(127, 81);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(180, 27);
            this.startDate.TabIndex = 12;
            this.startDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "dd MMMM yyyy";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(493, 81);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(180, 27);
            this.endDate.TabIndex = 11;
            this.endDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Location = new System.Drawing.Point(24, 38);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(35, 20);
            this.depLabel.TabIndex = 3;
            this.depLabel.Text = "Цех";
            // 
            // depComboBox
            // 
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(127, 35);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(180, 28);
            this.depComboBox.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(105, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(600, 64);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "    СВОДНЫЙ УЧЕТ И АНАЛИЗ ВЫПОЛНЕНИЯ       \r\nПРОИЗВОДСТВЕННОЙ ПРОГРАММЫ ЗА ПЕРИОД" +
    "";
            // 
            // timerForShiftingTable
            // 
            this.timerForShiftingTable.Interval = 10;
            this.timerForShiftingTable.Tick += new System.EventHandler(this.timerForShiftingTable_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(194, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "⩾";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(473, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "⩽";
            // 
            // DeviationAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviationAnalysis";
            this.Size = new System.Drawing.Size(835, 690);
            this.groupBox1.ResumeLayout(false);
            this.deviationPanel.ResumeLayout(false);
            this.deviationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.extraSettingPanel.ResumeLayout(false);
            this.extraSettingPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerForShiftingTable;
        private System.Windows.Forms.GroupBox deviationPanel;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox extraSettingPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endDevTextBox;
        private System.Windows.Forms.TextBox smallDevTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.CheckBox searchInAllDebCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOKPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producedColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviationColumn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox startDevTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
