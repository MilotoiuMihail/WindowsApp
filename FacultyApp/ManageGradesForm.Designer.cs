namespace FacultyApp
{
    partial class ManageGradesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGradesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lSubject = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lStudent = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnEditRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBulk = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.lDegree = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lStudentId = new System.Windows.Forms.Label();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lGrade = new System.Windows.Forms.Label();
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.gbStudent.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbGrade.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(453, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(156, 20);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(149, 21);
            this.cbSubject.TabIndex = 43;
            this.cbSubject.SelectedValueChanged += new System.EventHandler(this.cbSubject_SelectedValueChanged);
            this.cbSubject.Enter += new System.EventHandler(this.cbSubject_Enter);
            this.cbSubject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbSubject_KeyUp);
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(112, 24);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(38, 13);
            this.lSubject.TabIndex = 42;
            this.lSubject.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lStudent
            // 
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(32, 9);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(146, 13);
            this.lStudent.TabIndex = 49;
            this.lStudent.Text = "Last Name First Name grades";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxBtnEditRow,
            this.ctxBtnDeleteRow});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // ctxBtnEditRow
            // 
            this.ctxBtnEditRow.Name = "ctxBtnEditRow";
            this.ctxBtnEditRow.Size = new System.Drawing.Size(107, 22);
            this.ctxBtnEditRow.Text = "Edit";
            this.ctxBtnEditRow.Click += new System.EventHandler(this.ctxBtnEditRow_Click);
            // 
            // ctxBtnDeleteRow
            // 
            this.ctxBtnDeleteRow.Name = "ctxBtnDeleteRow";
            this.ctxBtnDeleteRow.Size = new System.Drawing.Size(107, 22);
            this.ctxBtnDeleteRow.Text = "Delete";
            this.ctxBtnDeleteRow.Click += new System.EventHandler(this.ctxBtnDeleteRow_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(560, 24);
            this.menuStrip.TabIndex = 54;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBulk,
            this.btnExport,
            this.btnPrint});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnAddBulk
            // 
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.Size = new System.Drawing.Size(122, 22);
            this.btnAddBulk.Text = "&Add Bulk";
            this.btnAddBulk.Click += new System.EventHandler(this.btnAddBulk_Click);
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 22);
            this.btnExport.Text = "&Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintDocument,
            this.btnPrintPreview,
            this.btnPrintSetup});
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 22);
            this.btnPrint.Text = "&Print";
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Size = new System.Drawing.Size(158, 22);
            this.btnPrintDocument.Text = "Print &Document";
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(158, 22);
            this.btnPrintPreview.Text = "Print &Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrintSetup
            // 
            this.btnPrintSetup.Name = "btnPrintSetup";
            this.btnPrintSetup.Size = new System.Drawing.Size(158, 22);
            this.btnPrintSetup.Text = "Print &Setup";
            this.btnPrintSetup.Click += new System.EventHandler(this.btnPrintSetup_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowDrop = true;
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(6, 19);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(522, 150);
            this.dgvGrades.TabIndex = 55;
            this.dgvGrades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellDoubleClick);
            this.dgvGrades.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrades_ColumnHeaderMouseDoubleClick);
            this.dgvGrades.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvGrades_DragDrop);
            this.dgvGrades.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvGrades_DragEnter);
            this.dgvGrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGrades_KeyDown);
            this.dgvGrades.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvGrades_MouseDown);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Controls.Add(this.lValue);
            this.gbStudent.Controls.Add(this.lDegree);
            this.gbStudent.Controls.Add(this.label5);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.lFirstName);
            this.gbStudent.Controls.Add(this.lLastName);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.lStudentId);
            this.gbStudent.Location = new System.Drawing.Point(12, 25);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(536, 56);
            this.gbStudent.TabIndex = 70;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Degree:";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(241, 37);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(0, 13);
            this.lValue.TabIndex = 41;
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(241, 16);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(0, 13);
            this.lDegree.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "LastName:";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(67, 37);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(0, 13);
            this.lFirstName.TabIndex = 33;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(67, 16);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(0, 13);
            this.lLastName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id:";
            // 
            // lStudentId
            // 
            this.lStudentId.AutoSize = true;
            this.lStudentId.Location = new System.Drawing.Point(356, 16);
            this.lStudentId.Name = "lStudentId";
            this.lStudentId.Size = new System.Drawing.Size(0, 13);
            this.lStudentId.TabIndex = 39;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.cbId);
            this.gbSubject.Controls.Add(this.label6);
            this.gbSubject.Controls.Add(this.lId);
            this.gbSubject.Controls.Add(this.lSubject);
            this.gbSubject.Controls.Add(this.cbSubject);
            this.gbSubject.Location = new System.Drawing.Point(12, 87);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(311, 53);
            this.gbSubject.TabIndex = 71;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject";
            this.gbSubject.Enter += new System.EventHandler(this.control_Enter);
            this.gbSubject.Validating += new System.ComponentModel.CancelEventHandler(this.gbSubject_Validating);
            this.gbSubject.Validated += new System.EventHandler(this.control_Validated);
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(32, 20);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(40, 21);
            this.cbId.TabIndex = 75;
            this.cbId.SelectedValueChanged += new System.EventHandler(this.cbId_SelectedValueChanged);
            this.cbId.Enter += new System.EventHandler(this.cbId_Enter);
            this.cbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            this.cbId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbId_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "OR";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(7, 24);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 49;
            this.lId.Text = "Id:";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.dgvGrades);
            this.gbResults.Controls.Add(this.btnEdit);
            this.gbResults.Controls.Add(this.btnDelete);
            this.gbResults.Location = new System.Drawing.Point(12, 146);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(536, 205);
            this.gbResults.TabIndex = 72;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(47, 19);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(41, 20);
            this.tbGrade.TabIndex = 46;
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            // 
            // lGrade
            // 
            this.lGrade.AutoSize = true;
            this.lGrade.Location = new System.Drawing.Point(7, 23);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(39, 13);
            this.lGrade.TabIndex = 44;
            this.lGrade.Text = "Grade:";
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.tbGrade);
            this.gbGrade.Controls.Add(this.lGrade);
            this.gbGrade.Location = new System.Drawing.Point(329, 87);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(97, 53);
            this.gbGrade.TabIndex = 73;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "Grade";
            this.gbGrade.Enter += new System.EventHandler(this.control_Enter);
            this.gbGrade.Validating += new System.ComponentModel.CancelEventHandler(this.gbGrade_Validating);
            this.gbGrade.Validated += new System.EventHandler(this.control_Validated);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 354);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(560, 22);
            this.statusStrip.TabIndex = 74;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.TextChanged += new System.EventHandler(this.statusStrip_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ManageGradesForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(560, 376);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbGrade);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageGradesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Grades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageGradesForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageGradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbGrade.ResumeLayout(false);
            this.gbGrade.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddBulk;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintDocument;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem btnPrintSetup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnEditRow;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDeleteRow;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lStudentId;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.GroupBox gbGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
    }
}