namespace SkillsOntario.ContestentManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.grpStudentContainer = new System.Windows.Forms.GroupBox();
            this.flpActionsColumn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSortType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbFilterType = new System.Windows.Forms.ToolStripComboBox();
            this.txtFilterValue = new System.Windows.Forms.ToolStripTextBox();
            this.btnApplyFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTopThreeContestList = new System.Windows.Forms.ToolStripComboBox();
            this.btnShowTopThree = new System.Windows.Forms.ToolStripButton();
            this.grpStudentContainer.SuspendLayout();
            this.flpActionsColumn.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudentContainer
            // 
            this.grpStudentContainer.Controls.Add(this.flpActionsColumn);
            this.grpStudentContainer.Controls.Add(this.lstStudents);
            this.grpStudentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudentContainer.Location = new System.Drawing.Point(0, 0);
            this.grpStudentContainer.Name = "grpStudentContainer";
            this.grpStudentContainer.Size = new System.Drawing.Size(800, 400);
            this.grpStudentContainer.TabIndex = 1;
            this.grpStudentContainer.TabStop = false;
            this.grpStudentContainer.Text = "Contestants";
            // 
            // flpActionsColumn
            // 
            this.flpActionsColumn.AutoSize = true;
            this.flpActionsColumn.Controls.Add(this.btnCreate);
            this.flpActionsColumn.Controls.Add(this.btnDelete);
            this.flpActionsColumn.Controls.Add(this.btnEdit);
            this.flpActionsColumn.Controls.Add(this.btnClearAll);
            this.flpActionsColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpActionsColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActionsColumn.Location = new System.Drawing.Point(716, 16);
            this.flpActionsColumn.Margin = new System.Windows.Forms.Padding(10);
            this.flpActionsColumn.Name = "flpActionsColumn";
            this.flpActionsColumn.Size = new System.Drawing.Size(81, 381);
            this.flpActionsColumn.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(3, 61);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(3, 90);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudents.FullRowSelect = true;
            this.lstStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstStudents.HideSelection = false;
            this.lstStudents.Location = new System.Drawing.Point(3, 16);
            this.lstStudents.MultiSelect = false;
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.ShowGroups = false;
            this.lstStudents.Size = new System.Drawing.Size(794, 381);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 272;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contest name";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Score";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.grpStudentContainer);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 400);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbSortType,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.cmbFilterType,
            this.txtFilterValue,
            this.btnApplyFilter});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(507, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Sort by:";
            // 
            // cmbSortType
            // 
            this.cmbSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortType.Name = "cmbSortType";
            this.cmbSortType.Size = new System.Drawing.Size(121, 25);
            this.cmbSortType.SelectedIndexChanged += new System.EventHandler(this.cmbSortType_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel2.Text = "Filter by:";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(121, 25);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(100, 25);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyFilter.Image")));
            this.btnApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(42, 22);
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.cmbTopThreeContestList,
            this.btnShowTopThree});
            this.toolStrip2.Location = new System.Drawing.Point(3, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(249, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel3.Text = "Show Top 3 for:";
            // 
            // cmbTopThreeContestList
            // 
            this.cmbTopThreeContestList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopThreeContestList.Name = "cmbTopThreeContestList";
            this.cmbTopThreeContestList.Size = new System.Drawing.Size(121, 25);
            // 
            // btnShowTopThree
            // 
            this.btnShowTopThree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowTopThree.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTopThree.Image")));
            this.btnShowTopThree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowTopThree.Name = "btnShowTopThree";
            this.btnShowTopThree.Size = new System.Drawing.Size(26, 22);
            this.btnShowTopThree.Text = "Go";
            this.btnShowTopThree.Click += new System.EventHandler(this.btnShowTopThree_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.grpStudentContainer.ResumeLayout(false);
            this.grpStudentContainer.PerformLayout();
            this.flpActionsColumn.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentContainer;
        private System.Windows.Forms.FlowLayoutPanel flpActionsColumn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbSortType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbFilterType;
        private System.Windows.Forms.ToolStripTextBox txtFilterValue;
        private System.Windows.Forms.ToolStripButton btnApplyFilter;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbTopThreeContestList;
        private System.Windows.Forms.ToolStripButton btnShowTopThree;
    }
}

