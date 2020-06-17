namespace SkillsOntario.ContestentManager
{
    partial class EditorDialog
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
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.secondLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.contestLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.txtContestName = new System.Windows.Forms.TextBox();
            this.cmbSchoolBoard = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.nudScorePercentage = new System.Windows.Forms.NumericUpDown();
            this.flpActions.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScorePercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // flpActions
            // 
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnSave);
            this.flpActions.Controls.Add(this.btnCancel);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActions.Location = new System.Drawing.Point(0, 179);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(450, 29);
            this.flpActions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.AutoSize = true;
            this.grpStudentInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpStudentInfo.Controls.Add(this.tableLayoutPanel1);
            this.grpStudentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(450, 171);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Student Information:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtContestName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.scoreLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.birthDateLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.contestLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.boardLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.secondLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSchoolBoard, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateOfBirth, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudScorePercentage, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 152);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // secondLabel
            // 
            this.secondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondLabel.Location = new System.Drawing.Point(3, 26);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(216, 26);
            this.secondLabel.TabIndex = 3;
            this.secondLabel.Text = "Last name:";
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstLabel
            // 
            this.firstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstLabel.Location = new System.Drawing.Point(3, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(216, 26);
            this.firstLabel.TabIndex = 4;
            this.firstLabel.Text = "First name:";
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(225, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(216, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(225, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Location = new System.Drawing.Point(3, 52);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(216, 20);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email Address:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailAddress.Location = new System.Drawing.Point(225, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(216, 20);
            this.txtEmailAddress.TabIndex = 2;
            // 
            // boardLabel
            // 
            this.boardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLabel.Location = new System.Drawing.Point(3, 72);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(216, 20);
            this.boardLabel.TabIndex = 9;
            this.boardLabel.Text = "School Board:";
            this.boardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contestLabel
            // 
            this.contestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contestLabel.Location = new System.Drawing.Point(3, 92);
            this.contestLabel.Name = "contestLabel";
            this.contestLabel.Size = new System.Drawing.Size(216, 20);
            this.contestLabel.TabIndex = 10;
            this.contestLabel.Text = "Contest name:";
            this.contestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateLabel.Location = new System.Drawing.Point(3, 112);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(216, 20);
            this.birthDateLabel.TabIndex = 11;
            this.birthDateLabel.Text = "Date Of Birth:";
            this.birthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLabel.Location = new System.Drawing.Point(3, 132);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(216, 20);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.Text = "Score percentage:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContestName
            // 
            this.txtContestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContestName.Location = new System.Drawing.Point(225, 95);
            this.txtContestName.Name = "txtContestName";
            this.txtContestName.Size = new System.Drawing.Size(216, 20);
            this.txtContestName.TabIndex = 4;
            // 
            // cmbSchoolBoard
            // 
            this.cmbSchoolBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSchoolBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolBoard.FormattingEnabled = true;
            this.cmbSchoolBoard.Location = new System.Drawing.Point(225, 75);
            this.cmbSchoolBoard.Name = "cmbSchoolBoard";
            this.cmbSchoolBoard.Size = new System.Drawing.Size(216, 21);
            this.cmbSchoolBoard.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(225, 115);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(216, 20);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // nudScorePercentage
            // 
            this.nudScorePercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudScorePercentage.Location = new System.Drawing.Point(225, 135);
            this.nudScorePercentage.Name = "nudScorePercentage";
            this.nudScorePercentage.Size = new System.Drawing.Size(216, 20);
            this.nudScorePercentage.TabIndex = 6;
            // 
            // EditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 208);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.flpActions);
            this.Name = "EditorDialog";
            this.Text = "EditorDialog";
            this.Load += new System.EventHandler(this.EditorDialog_Load);
            this.flpActions.ResumeLayout(false);
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScorePercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox txtContestName;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label contestLabel;
        private System.Windows.Forms.Label boardLabel;
        private System.Windows.Forms.ComboBox cmbSchoolBoard;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.NumericUpDown nudScorePercentage;
    }
}