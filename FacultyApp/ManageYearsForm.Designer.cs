namespace FacultyApp
{
    partial class ManageYearsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageYearsForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.lDegree = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvYears = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxBtnEditRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBtnDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBulk = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.lRequiredCredits = new System.Windows.Forms.Label();
            this.tbRequiredCredits = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lId = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbYear.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(62, 17);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(87, 21);
            this.cbDegree.TabIndex = 10;
            this.cbDegree.Enter += new System.EventHandler(this.control_Enter);
            this.cbDegree.Validating += new System.ComponentModel.CancelEventHandler(this.cbDegree_Validating);
            this.cbDegree.Validated += new System.EventHandler(this.control_Validated);
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(4, 21);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(45, 13);
            this.lDegree.TabIndex = 11;
            this.lDegree.Text = "Degree:";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(160, 21);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(32, 13);
            this.lYear.TabIndex = 12;
            this.lYear.Text = "Year:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(201, 17);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(46, 20);
            this.tbValue.TabIndex = 13;
            this.tbValue.Enter += new System.EventHandler(this.control_Enter);
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.tbValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbValue_Validating);
            this.tbValue.Validated += new System.EventHandler(this.control_Validated);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(482, 175);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvYears
            // 
            this.dgvYears.AllowDrop = true;
            this.dgvYears.AllowUserToAddRows = false;
            this.dgvYears.AllowUserToDeleteRows = false;
            this.dgvYears.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYears.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYears.Location = new System.Drawing.Point(11, 19);
            this.dgvYears.MultiSelect = false;
            this.dgvYears.Name = "dgvYears";
            this.dgvYears.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYears.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvYears.RowHeadersVisible = false;
            this.dgvYears.RowTemplate.ContextMenuStrip = this.contextMenuStrip;
            this.dgvYears.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYears.Size = new System.Drawing.Size(547, 150);
            this.dgvYears.TabIndex = 19;
            this.dgvYears.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYears_CellDoubleClick);
            this.dgvYears.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYears_ColumnHeaderMouseDoubleClick);
            this.dgvYears.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvYears_DragDrop);
            this.dgvYears.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvYears_DragEnter);
            this.dgvYears.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvYears_KeyDown);
            this.dgvYears.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvYears_MouseDown);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(590, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBulk,
            this.btnExport,
            this.btnPrint,
            this.xMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btnAddBulk
            // 
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.Size = new System.Drawing.Size(180, 22);
            this.btnAddBulk.Text = "&Add Bulk";
            this.btnAddBulk.Click += new System.EventHandler(this.btnAddBulk_Click);
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 22);
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
            this.btnPrint.Size = new System.Drawing.Size(180, 22);
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
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveXML,
            this.btnLoadXML});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(180, 22);
            this.btnSaveXML.Text = "Save";
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(180, 22);
            this.btnLoadXML.Text = "Load";
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // lRequiredCredits
            // 
            this.lRequiredCredits.AutoSize = true;
            this.lRequiredCredits.Location = new System.Drawing.Point(253, 21);
            this.lRequiredCredits.Name = "lRequiredCredits";
            this.lRequiredCredits.Size = new System.Drawing.Size(88, 13);
            this.lRequiredCredits.TabIndex = 23;
            this.lRequiredCredits.Text = "Required Credits:";
            // 
            // tbRequiredCredits
            // 
            this.tbRequiredCredits.Location = new System.Drawing.Point(344, 17);
            this.tbRequiredCredits.Name = "tbRequiredCredits";
            this.tbRequiredCredits.Size = new System.Drawing.Size(46, 20);
            this.tbRequiredCredits.TabIndex = 24;
            this.tbRequiredCredits.Enter += new System.EventHandler(this.control_Enter);
            this.tbRequiredCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.tbRequiredCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbRequiredCredits_Validating);
            this.tbRequiredCredits.Validated += new System.EventHandler(this.control_Validated);
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
            // gbResults
            // 
            this.gbResults.Controls.Add(this.btnBack);
            this.gbResults.Controls.Add(this.dgvYears);
            this.gbResults.Controls.Add(this.btnDelete);
            this.gbResults.Controls.Add(this.btnEdit);
            this.gbResults.Location = new System.Drawing.Point(12, 103);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(569, 205);
            this.gbResults.TabIndex = 29;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 175);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.tbRequiredCredits);
            this.gbYear.Controls.Add(this.tbValue);
            this.gbYear.Controls.Add(this.lYear);
            this.gbYear.Controls.Add(this.lDegree);
            this.gbYear.Controls.Add(this.lRequiredCredits);
            this.gbYear.Controls.Add(this.cbDegree);
            this.gbYear.Location = new System.Drawing.Point(12, 27);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(400, 75);
            this.gbYear.TabIndex = 30;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.panel1);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.btnAdd);
            this.gbSearch.Controls.Add(this.lId);
            this.gbSearch.Location = new System.Drawing.Point(418, 27);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(163, 75);
            this.gbSearch.TabIndex = 31;
            this.gbSearch.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(106, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 20);
            this.panel1.TabIndex = 28;
            // 
            // tbId
            // 
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Location = new System.Drawing.Point(3, 2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(24, 13);
            this.tbId.TabIndex = 26;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacultyApp.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(32, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(9, 9);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(85, 20);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 25;
            this.lId.Text = "Id:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 312);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(590, 22);
            this.statusStrip.TabIndex = 32;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.TextChanged += new System.EventHandler(this.statusStrip_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ManageYearsForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(590, 334);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ManageYearsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Manage Years";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageYearsForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageYearsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvYears;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnAddBulk;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnEditRow;
        private System.Windows.Forms.ToolStripMenuItem ctxBtnDeleteRow;
        private System.Windows.Forms.Label lRequiredCredits;
        private System.Windows.Forms.TextBox tbRequiredCredits;
        private System.Windows.Forms.ToolStripMenuItem btnPrintDocument;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem btnPrintSetup;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.GroupBox gbResults;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSaveXML;
        private System.Windows.Forms.ToolStripMenuItem btnLoadXML;
    }
}