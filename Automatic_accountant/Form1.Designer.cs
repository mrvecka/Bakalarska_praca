﻿using System.Windows.Forms;

namespace Bakalarska_praca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnSave;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;

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
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propGrid = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridValues = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbClientInfo = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.sizer = new System.Windows.Forms.TrackBar();
            this.btnGenerateFromPattern = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.txtPathPattern = new System.Windows.Forms.TextBox();
            this.txtPartConfidence = new System.Windows.Forms.TextBox();
            this.lblPatConfidence = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(344, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save as pattern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 769);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 766);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(72, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(723, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 769);
            this.panel3.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(468, 700);
            this.panel6.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 700);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propGrid
            // 
            this.propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid.Location = new System.Drawing.Point(3, 3);
            this.propGrid.Name = "propGrid";
            this.propGrid.Size = new System.Drawing.Size(454, 668);
            this.propGrid.TabIndex = 1;
            this.propGrid.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propGrid_SelectedGridItemChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridValues);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Positions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridValues
            // 
            this.dataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
            this.dataGridValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridValues.Location = new System.Drawing.Point(3, 3);
            this.dataGridValues.Name = "dataGridValues";
            this.dataGridValues.ReadOnly = true;
            this.dataGridValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridValues.Size = new System.Drawing.Size(454, 668);
            this.dataGridValues.TabIndex = 0;
            this.dataGridValues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridValues_CellContentClick);
            // 
            // key
            // 
            this.key.DataPropertyName = "Key";
            this.key.DividerWidth = 2;
            this.key.HeaderText = "Key";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 150;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.DataPropertyName = "Value";
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbClientInfo);
            this.panel5.Controls.Add(this.btnRemove);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnDefault);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbKey);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 700);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(468, 69);
            this.panel5.TabIndex = 1;
            // 
            // cmbClientInfo
            // 
            this.cmbClientInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientInfo.FormattingEnabled = true;
            this.cmbClientInfo.Location = new System.Drawing.Point(92, 40);
            this.cmbClientInfo.Name = "cmbClientInfo";
            this.cmbClientInfo.Size = new System.Drawing.Size(131, 21);
            this.cmbClientInfo.TabIndex = 11;
            this.cmbClientInfo.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(229, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDefault.Location = new System.Drawing.Point(344, 11);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(112, 23);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Reset to default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Key:";
            // 
            // cmbKey
            // 
            this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(40, 13);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(183, 21);
            this.cmbKey.TabIndex = 0;
            this.cmbKey.SelectedValueChanged += new System.EventHandler(this.cmbKey_SelectedValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lblSize);
            this.panel4.Controls.Add(this.sizer);
            this.panel4.Controls.Add(this.btnGenerateFromPattern);
            this.panel4.Controls.Add(this.btnNewFile);
            this.panel4.Controls.Add(this.txtPathPattern);
            this.panel4.Controls.Add(this.txtPartConfidence);
            this.panel4.Controls.Add(this.lblPatConfidence);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1191, 50);
            this.panel4.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(342, 22);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 13);
            this.lblSize.TabIndex = 17;
            this.lblSize.Text = "100 %";
            this.lblSize.Visible = false;
            // 
            // sizer
            // 
            this.sizer.LargeChange = 10;
            this.sizer.Location = new System.Drawing.Point(154, 3);
            this.sizer.Maximum = 130;
            this.sizer.Minimum = 70;
            this.sizer.Name = "sizer";
            this.sizer.Size = new System.Drawing.Size(181, 45);
            this.sizer.TabIndex = 16;
            this.sizer.Value = 100;
            this.sizer.Visible = false;
            this.sizer.ValueChanged += new System.EventHandler(this.sizer_ValueChanged);
            // 
            // btnGenerateFromPattern
            // 
            this.btnGenerateFromPattern.Location = new System.Drawing.Point(12, 6);
            this.btnGenerateFromPattern.Name = "btnGenerateFromPattern";
            this.btnGenerateFromPattern.Size = new System.Drawing.Size(126, 20);
            this.btnGenerateFromPattern.TabIndex = 15;
            this.btnGenerateFromPattern.Text = "Generate txt file";
            this.btnGenerateFromPattern.UseVisualStyleBackColor = true;
            this.btnGenerateFromPattern.Click += new System.EventHandler(this.btnGenerateFromPattern_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewFile.Location = new System.Drawing.Point(1068, 13);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(111, 23);
            this.btnNewFile.TabIndex = 14;
            this.btnNewFile.Text = "Choose file";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPathPattern
            // 
            this.txtPathPattern.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPathPattern.Location = new System.Drawing.Point(618, 16);
            this.txtPathPattern.Name = "txtPathPattern";
            this.txtPathPattern.ReadOnly = true;
            this.txtPathPattern.Size = new System.Drawing.Size(443, 20);
            this.txtPathPattern.TabIndex = 13;
            // 
            // txtPartConfidence
            // 
            this.txtPartConfidence.Location = new System.Drawing.Point(532, 6);
            this.txtPartConfidence.Name = "txtPartConfidence";
            this.txtPartConfidence.ReadOnly = true;
            this.txtPartConfidence.Size = new System.Drawing.Size(67, 20);
            this.txtPartConfidence.TabIndex = 12;
            // 
            // lblPatConfidence
            // 
            this.lblPatConfidence.AutoSize = true;
            this.lblPatConfidence.Location = new System.Drawing.Point(431, 10);
            this.lblPatConfidence.Name = "lblPatConfidence";
            this.lblPatConfidence.Size = new System.Drawing.Size(95, 13);
            this.lblPatConfidence.TabIndex = 11;
            this.lblPatConfidence.Text = "Partial confidence:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Image preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDefault;
        private Panel panel2;
        private DataGridView dataGridValues;
        private DataGridViewTextBoxColumn key;
        private DataGridViewTextBoxColumn value;
        private TextBox txtPartConfidence;
        private Label lblPatConfidence;
        private Panel panel5;
        private ComboBox cmbKey;
        private Button btnRemove;
        private Button btnAdd;
        private Label label4;
        private Panel panel6;
        private Button btnNewFile;
        private TextBox txtPathPattern;
        private OpenFileDialog openFileDialog1;
        private ComboBox cmbClientInfo;
        private PropertyGrid propGrid;
        private Button btnGenerateFromPattern;
        private Label lblSize;
        private Button button1;
        private TrackBar sizer;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}

