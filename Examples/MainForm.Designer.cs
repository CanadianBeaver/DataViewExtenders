﻿namespace Examples
{
  partial class MainForm
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
      System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.FlowLayoutPanel buttonsPanel;
      System.Windows.Forms.Button btnLoadData;
      System.Windows.Forms.Button btnSaveData;
      System.Windows.Forms.Button btnExit;
      this.departmentsGridView = new System.Windows.Forms.DataGridView();
      this.employeesGridView = new System.Windows.Forms.DataGridView();
      this.departmentsPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.employeesPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.departmentsNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.employeesNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
      this.Database = new Examples.Database.daoDataSet();
      this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
      btnLoadData = new System.Windows.Forms.Button();
      btnSaveData = new System.Windows.Forms.Button();
      btnExit = new System.Windows.Forms.Button();
      mainLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsNavigator)).BeginInit();
      this.departmentsNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeesNavigator)).BeginInit();
      this.employeesNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
      buttonsPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // mainLayoutPanel
      // 
      mainLayoutPanel.ColumnCount = 2;
      mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      mainLayoutPanel.Controls.Add(this.departmentsGridView, 0, 1);
      mainLayoutPanel.Controls.Add(this.employeesGridView, 1, 1);
      mainLayoutPanel.Controls.Add(this.departmentsPanel, 0, 2);
      mainLayoutPanel.Controls.Add(this.employeesPanel, 1, 2);
      mainLayoutPanel.Controls.Add(this.departmentsNavigator, 0, 0);
      mainLayoutPanel.Controls.Add(this.employeesNavigator, 1, 0);
      mainLayoutPanel.Controls.Add(buttonsPanel, 0, 3);
      mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
      mainLayoutPanel.Name = "mainLayoutPanel";
      mainLayoutPanel.RowCount = 4;
      mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      mainLayoutPanel.Size = new System.Drawing.Size(784, 562);
      mainLayoutPanel.TabIndex = 0;
      // 
      // departmentsGridView
      // 
      this.departmentsGridView.AutoGenerateColumns = false;
      this.departmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.departmentsGridView.DataSource = this.departmentsBindingSource;
      this.departmentsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.departmentsGridView.Location = new System.Drawing.Point(3, 28);
      this.departmentsGridView.Name = "departmentsGridView";
      this.departmentsGridView.Size = new System.Drawing.Size(386, 242);
      this.departmentsGridView.TabIndex = 0;
      // 
      // employeesGridView
      // 
      this.employeesGridView.AutoGenerateColumns = false;
      this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.employeesGridView.DataSource = this.employeesBindingSource;
      this.employeesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.employeesGridView.Location = new System.Drawing.Point(395, 28);
      this.employeesGridView.Name = "employeesGridView";
      this.employeesGridView.Size = new System.Drawing.Size(386, 242);
      this.employeesGridView.TabIndex = 1;
      // 
      // departmentsPanel
      // 
      this.departmentsPanel.AutoScroll = true;
      this.departmentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.departmentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.departmentsPanel.Location = new System.Drawing.Point(3, 276);
      this.departmentsPanel.Name = "departmentsPanel";
      this.departmentsPanel.Size = new System.Drawing.Size(386, 242);
      this.departmentsPanel.TabIndex = 2;
      // 
      // employeesPanel
      // 
      this.employeesPanel.AutoScroll = true;
      this.employeesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.employeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.employeesPanel.Location = new System.Drawing.Point(395, 276);
      this.employeesPanel.Name = "employeesPanel";
      this.employeesPanel.Size = new System.Drawing.Size(386, 242);
      this.employeesPanel.TabIndex = 3;
      // 
      // departmentsNavigator
      // 
      this.departmentsNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.departmentsNavigator.BindingSource = this.departmentsBindingSource;
      this.departmentsNavigator.CountItem = this.bindingNavigatorCountItem;
      this.departmentsNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.departmentsNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
      this.departmentsNavigator.Location = new System.Drawing.Point(0, 0);
      this.departmentsNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.departmentsNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.departmentsNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.departmentsNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.departmentsNavigator.Name = "departmentsNavigator";
      this.departmentsNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.departmentsNavigator.Size = new System.Drawing.Size(392, 25);
      this.departmentsNavigator.TabIndex = 4;
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // employeesNavigator
      // 
      this.employeesNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
      this.employeesNavigator.BindingSource = this.employeesBindingSource;
      this.employeesNavigator.CountItem = this.bindingNavigatorCountItem1;
      this.employeesNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.employeesNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
      this.employeesNavigator.Location = new System.Drawing.Point(392, 0);
      this.employeesNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.employeesNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.employeesNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.employeesNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.employeesNavigator.Name = "employeesNavigator";
      this.employeesNavigator.PositionItem = this.bindingNavigatorPositionItem1;
      this.employeesNavigator.Size = new System.Drawing.Size(392, 25);
      this.employeesNavigator.TabIndex = 5;
      // 
      // bindingNavigatorMoveFirstItem1
      // 
      this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
      this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem1.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem1
      // 
      this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
      this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
      // 
      // bindingNavigatorSeparator3
      // 
      this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem1
      // 
      this.bindingNavigatorPositionItem1.AccessibleName = "Position";
      this.bindingNavigatorPositionItem1.AutoSize = false;
      this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem1.Text = "0";
      this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem1
      // 
      this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem1.Text = "of {0}";
      this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator4
      // 
      this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem1
      // 
      this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
      this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem1.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem1
      // 
      this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
      this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem1.Text = "Move last";
      // 
      // bindingNavigatorSeparator5
      // 
      this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorAddNewItem1
      // 
      this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
      this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem1.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem1
      // 
      this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
      this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem1.Text = "Delete";
      // 
      // Database
      // 
      this.Database.DataSetName = "daoDataSet";
      this.Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // buttonsPanel
      // 
      buttonsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
      buttonsPanel.AutoSize = true;
      buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      mainLayoutPanel.SetColumnSpan(buttonsPanel, 2);
      buttonsPanel.Controls.Add(btnLoadData);
      buttonsPanel.Controls.Add(btnSaveData);
      buttonsPanel.Controls.Add(btnExit);
      buttonsPanel.Location = new System.Drawing.Point(528, 524);
      buttonsPanel.Name = "buttonsPanel";
      buttonsPanel.Size = new System.Drawing.Size(253, 35);
      buttonsPanel.TabIndex = 6;
      // 
      // btnLoadData
      // 
      btnLoadData.AutoSize = true;
      btnLoadData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      btnLoadData.Location = new System.Drawing.Point(3, 3);
      btnLoadData.Name = "btnLoadData";
      btnLoadData.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
      btnLoadData.Size = new System.Drawing.Size(87, 29);
      btnLoadData.TabIndex = 0;
      btnLoadData.Text = "Reload data";
      btnLoadData.UseVisualStyleBackColor = true;
      btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
      // 
      // btnSaveData
      // 
      btnSaveData.AutoSize = true;
      btnSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      btnSaveData.Location = new System.Drawing.Point(96, 3);
      btnSaveData.Name = "btnSaveData";
      btnSaveData.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
      btnSaveData.Size = new System.Drawing.Size(78, 29);
      btnSaveData.TabIndex = 1;
      btnSaveData.Text = "Save data";
      btnSaveData.UseVisualStyleBackColor = true;
      btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
      // 
      // btnExit
      // 
      btnExit.AutoSize = true;
      btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      btnExit.Location = new System.Drawing.Point(195, 3);
      btnExit.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
      btnExit.Name = "btnExit";
      btnExit.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
      btnExit.Size = new System.Drawing.Size(55, 29);
      btnExit.TabIndex = 2;
      btnExit.Text = "Close";
      btnExit.UseVisualStyleBackColor = true;
      btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // departmentsBindingSource
      // 
      this.departmentsBindingSource.DataMember = "Departments";
      this.departmentsBindingSource.DataSource = this.Database;
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.Database;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 562);
      this.Controls.Add(mainLayoutPanel);
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DataGridViewExtenders examples";
      mainLayoutPanel.ResumeLayout(false);
      mainLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsNavigator)).EndInit();
      this.departmentsNavigator.ResumeLayout(false);
      this.departmentsNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeesNavigator)).EndInit();
      this.employeesNavigator.ResumeLayout(false);
      this.employeesNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
      buttonsPanel.ResumeLayout(false);
      buttonsPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView departmentsGridView;
    private System.Windows.Forms.DataGridView employeesGridView;
    private System.Windows.Forms.FlowLayoutPanel departmentsPanel;
    private System.Windows.Forms.FlowLayoutPanel employeesPanel;
    private System.Windows.Forms.BindingNavigator departmentsNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.BindingNavigator employeesNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    private Database.daoDataSet Database;
    private System.Windows.Forms.BindingSource departmentsBindingSource;
    private System.Windows.Forms.BindingSource employeesBindingSource;
  }
}
