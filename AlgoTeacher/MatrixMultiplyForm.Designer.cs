﻿namespace AlgoTeacher
{
    partial class MatrixMultiplyForm
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
            if ( disposing && (components != null) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixMultiplyForm));
            this.ViewPanel = new DevExpress.XtraEditors.PanelControl();
            this.workbookView1 = new SpreadsheetGear.Windows.Forms.WorkbookView();
            this.questionControl = new AlgoTeacher.User_Controls.QuestionControl();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPanel)).BeginInit();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.Controls.Add(this.workbookView1);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1170, 392);
            this.ViewPanel.TabIndex = 1;
            // 
            // workbookView1
            // 
            this.workbookView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workbookView1.FormulaBar = null;
            this.workbookView1.Location = new System.Drawing.Point(2, 2);
            this.workbookView1.Name = "workbookView1";
            this.workbookView1.Size = new System.Drawing.Size(1166, 388);
            this.workbookView1.TabIndex = 0;
            this.workbookView1.WorkbookSetState = resources.GetString("workbookView1.WorkbookSetState");
            // 
            // questionControl
            // 
            this.questionControl.AnswerButtonEnabled = false;
            this.questionControl.CalculateButtonEnabled = true;
            this.questionControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.questionControl.Location = new System.Drawing.Point(0, 392);
            this.questionControl.MinimumSize = new System.Drawing.Size(500, 80);
            this.questionControl.Name = "questionControl";
            this.questionControl.Size = new System.Drawing.Size(1170, 80);
            this.questionControl.TabIndex = 2;
            // 
            // MatrixMultiplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 472);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.questionControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MatrixMultiplyForm";
            this.Text = "MatrixMultiplyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatrixMultiplyForm_FormClosed);
            this.Load += new System.EventHandler(this.MatrixMultiplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPanel)).EndInit();
            this.ViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ViewPanel;
        private User_Controls.QuestionControl questionControl;
        private SpreadsheetGear.Windows.Forms.WorkbookView workbookView1;
    }
}