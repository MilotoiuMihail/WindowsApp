namespace FacultyApp
{
    partial class ManageSubjectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubjectsForm));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.lCredits = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
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
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lDegree = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.lYearId = new System.Windows.Forms.Label();
            this.cbYearId = new System.Windows.Forms.ComboBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.lId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(554, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(115, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 30;
            this.lName.Text = "Name:";
            // 
            // lCredits
            // 
            this.lCredits.AutoSize = true;
            this.lCredits.Location = new System.Drawing.Point(264, 23);
            this.lCredits.Name = "lCredits";
            this.lCredits.Size = new System.Drawing.Size(42, 13);
            this.lCredits.TabIndex = 32;
            this.lCredits.Text = "Credits:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(382, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowDrop = true;
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(11, 19);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(618, 150);
            this.dgvSubjects.TabIndex = 35;
            this.dgvSubjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellDoubleClick);
            this.dgvSubjects.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubjects_ColumnHeaderMouseDoubleClick);
            this.dgvSubjects.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSubjects_DragDrop);
            this.dgvSubjects.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvSubjects_DragEnter);
            this.dgvSubjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSubjects_KeyDown);
            this.dgvSubjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSubjects_MouseDown);
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
            this.menuStrip.Size = new System.Drawing.Size(666, 24);
            this.menuStrip.TabIndex = 37;
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
            // gbYear
            // 
            this.gbYear.Controls.Add(this.label2);
            this.gbYear.Controls.Add(this.cbValue);
            this.gbYear.Controls.Add(this.label1);
            this.gbYear.Controls.Add(this.lYear);
            this.gbYear.Controls.Add(this.lDegree);
            this.gbYear.Controls.Add(this.cbDegree);
            this.gbYear.Controls.Add(this.lYearId);
            this.gbYear.Controls.Add(this.cbYearId);
            this.gbYear.Location = new System.Drawing.Point(12, 27);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(364, 55);
            this.gbYear.TabIndex = 60;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year";
            this.gbYear.Enter += new System.EventHandler(this.control_Enter);
            this.gbYear.Validating += new System.ComponentModel.CancelEventHandler(this.gbYear_Validating);
            this.gbYear.Validated += new System.EventHandler(this.control_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "&";
            this.label2.UseMnemonic = false;
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(309, 18);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(40, 21);
            this.cbValue.TabIndex = 41;
            this.cbValue.SelectedValueChanged += new System.EventHandler(this.cbDegreeValue_SelectedValueChanged);
            this.cbValue.Enter += new System.EventHandler(this.cbValue_Enter);
            this.cbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.cbValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbDegreeValue_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "OR";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(274, 22);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(32, 13);
            this.lYear.TabIndex = 33;
            this.lYear.Text = "Year:";
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(127, 22);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(45, 13);
            this.lDegree.TabIndex = 34;
            this.lDegree.Text = "Degree:";
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(178, 18);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(74, 21);
            this.cbDegree.TabIndex = 35;
            this.cbDegree.SelectedValueChanged += new System.EventHandler(this.cbDegreeValue_SelectedValueChanged);
            this.cbDegree.Enter += new System.EventHandler(this.cbDegree_Enter);
            this.cbDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letter_KeyPress);
            this.cbDegree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbDegreeValue_KeyUp);
            // 
            // lYearId
            // 
            this.lYearId.AutoSize = true;
            this.lYearId.Location = new System.Drawing.Point(6, 22);
            this.lYearId.Name = "lYearId";
            this.lYearId.Size = new System.Drawing.Size(44, 13);
            this.lYearId.TabIndex = 54;
            this.lYearId.Text = "Year Id:";
            // 
            // cbYearId
            // 
            this.cbYearId.FormattingEnabled = true;
            this.cbYearId.Location = new System.Drawing.Point(56, 18);
            this.cbYearId.Name = "cbYearId";
            this.cbYearId.Size = new System.Drawing.Size(40, 21);
            this.cbYearId.TabIndex = 55;
            this.cbYearId.SelectedValueChanged += new System.EventHandler(this.cbYearId_SelectedValueChanged);
            this.cbYearId.Enter += new System.EventHandler(this.cbYearId_Enter);
            this.cbYearId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.cbYearId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbYearId_KeyUp);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.btnBack);
            this.gbResults.Controls.Add(this.btnDelete);
            this.gbResults.Controls.Add(this.dgvSubjects);
            this.gbResults.Controls.Add(this.btnEdit);
            this.gbResults.Location = new System.Drawing.Point(12, 144);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(640, 205);
            this.gbResults.TabIndex = 61;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 175);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.lId);
            this.gbSubject.Controls.Add(this.lCredits);
            this.gbSubject.Controls.Add(this.tbId);
            this.gbSubject.Controls.Add(this.tbCredits);
            this.gbSubject.Controls.Add(this.lName);
            this.gbSubject.Controls.Add(this.tbName);
            this.gbSubject.Location = new System.Drawing.Point(12, 88);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(364, 56);
            this.gbSubject.TabIndex = 62;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(31, 23);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 37;
            this.lId.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(53, 19);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 20);
            this.tbId.TabIndex = 36;
            this.tbId.Enter += new System.EventHandler(this.control_Enter);
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.tbId.Validating += new System.ComponentModel.CancelEventHandler(this.tbId_Validating);
            this.tbId.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(306, 19);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(43, 20);
            this.tbCredits.TabIndex = 31;
            this.tbCredits.Enter += new System.EventHandler(this.control_Enter);
            this.tbCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.tbCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbCredits_Validating);
            this.tbCredits.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 20);
            this.tbName.TabIndex = 29;
            this.tbName.Enter += new System.EventHandler(this.control_Enter);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 354);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(666, 22);
            this.statusStrip.TabIndex = 75;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.TextChanged += new System.EventHandler(this.statusStrip_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ManageSubjectsForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(666, 376);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageSubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Subjects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageSubjectsForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageSubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCredits;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSubjects;
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
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label lYearId;
        private System.Windows.Forms.ComboBox cbYearId;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
    }
}