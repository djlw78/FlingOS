﻿namespace Drivers.Debugger.App
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Press refresh to start");
            this.label1 = new System.Windows.Forms.Label();
            this.PipeNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AssemblyNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BinPathBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectingProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CurrentMethodBox = new System.Windows.Forms.TextBox();
            this.MethodLabelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NearestLabelAddessBox = new System.Windows.Forms.TextBox();
            this.NearestLabelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SingleStepButton = new System.Windows.Forms.Button();
            this.StepButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.SuspendButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ProcessesTreeView = new System.Windows.Forms.TreeView();
            this.AbortButton = new System.Windows.Forms.Button();
            this.DestroyButton = new System.Windows.Forms.Button();
            this.MethodLocalLabelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.BreakpointsTreeView = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DebugPointsTreeView = new System.Windows.Forms.TreeView();
            this.ClearBreakpointButton = new System.Windows.Forms.Button();
            this.SetBreakpointButton = new System.Windows.Forms.Button();
            this.Thex86RegistersControl = new Drivers.Debugger.App.x86RegistersControl();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pipe:";
            // 
            // PipeNameBox
            // 
            this.PipeNameBox.Location = new System.Drawing.Point(50, 10);
            this.PipeNameBox.Name = "PipeNameBox";
            this.PipeNameBox.Size = new System.Drawing.Size(124, 20);
            this.PipeNameBox.TabIndex = 1;
            this.PipeNameBox.Text = "FlingOSDebug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assembly:";
            // 
            // AssemblyNameBox
            // 
            this.AssemblyNameBox.Location = new System.Drawing.Point(258, 10);
            this.AssemblyNameBox.Name = "AssemblyNameBox";
            this.AssemblyNameBox.Size = new System.Drawing.Size(124, 20);
            this.AssemblyNameBox.TabIndex = 3;
            this.AssemblyNameBox.Text = "Kernel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bin path:";
            // 
            // BinPathBox
            // 
            this.BinPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinPathBox.Location = new System.Drawing.Point(465, 10);
            this.BinPathBox.Name = "BinPathBox";
            this.BinPathBox.Size = new System.Drawing.Size(383, 20);
            this.BinPathBox.TabIndex = 5;
            this.BinPathBox.Text = "G:\\Fling OS\\Fling OS\\Kernel\\Kernel\\bin\\Debug";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(586, 36);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectingProgressBar
            // 
            this.ConnectingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectingProgressBar.Enabled = false;
            this.ConnectingProgressBar.Location = new System.Drawing.Point(748, 36);
            this.ConnectingProgressBar.MarqueeAnimationSpeed = 50;
            this.ConnectingProgressBar.Name = "ConnectingProgressBar";
            this.ConnectingProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ConnectingProgressBar.Step = 1;
            this.ConnectingProgressBar.TabIndex = 7;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.SetBreakpointButton);
            this.MainPanel.Controls.Add(this.ClearBreakpointButton);
            this.MainPanel.Controls.Add(this.DebugPointsTreeView);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.BreakpointsTreeView);
            this.MainPanel.Controls.Add(this.FilterBox);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.MethodLocalLabelLabel);
            this.MainPanel.Controls.Add(this.CurrentMethodBox);
            this.MainPanel.Controls.Add(this.MethodLabelBox);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.NearestLabelAddessBox);
            this.MainPanel.Controls.Add(this.NearestLabelBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.Thex86RegistersControl);
            this.MainPanel.Controls.Add(this.SingleStepButton);
            this.MainPanel.Controls.Add(this.StepButton);
            this.MainPanel.Controls.Add(this.ResumeButton);
            this.MainPanel.Controls.Add(this.SuspendButton);
            this.MainPanel.Controls.Add(this.RefreshButton);
            this.MainPanel.Controls.Add(this.ProcessesTreeView);
            this.MainPanel.Enabled = false;
            this.MainPanel.Location = new System.Drawing.Point(12, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(836, 832);
            this.MainPanel.TabIndex = 8;
            // 
            // CurrentMethodBox
            // 
            this.CurrentMethodBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentMethodBox.Location = new System.Drawing.Point(372, 57);
            this.CurrentMethodBox.Multiline = true;
            this.CurrentMethodBox.Name = "CurrentMethodBox";
            this.CurrentMethodBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CurrentMethodBox.Size = new System.Drawing.Size(461, 335);
            this.CurrentMethodBox.TabIndex = 12;
            this.CurrentMethodBox.WordWrap = false;
            // 
            // MethodLabelBox
            // 
            this.MethodLabelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MethodLabelBox.Location = new System.Drawing.Point(450, 31);
            this.MethodLabelBox.Name = "MethodLabelBox";
            this.MethodLabelBox.Size = new System.Drawing.Size(383, 20);
            this.MethodLabelBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Method label :";
            // 
            // NearestLabelAddessBox
            // 
            this.NearestLabelAddessBox.Location = new System.Drawing.Point(450, 5);
            this.NearestLabelAddessBox.Name = "NearestLabelAddessBox";
            this.NearestLabelAddessBox.Size = new System.Drawing.Size(67, 20);
            this.NearestLabelAddessBox.TabIndex = 9;
            // 
            // NearestLabelBox
            // 
            this.NearestLabelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NearestLabelBox.Location = new System.Drawing.Point(523, 5);
            this.NearestLabelBox.Name = "NearestLabelBox";
            this.NearestLabelBox.Size = new System.Drawing.Size(310, 20);
            this.NearestLabelBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nearest label :";
            // 
            // SingleStepButton
            // 
            this.SingleStepButton.Location = new System.Drawing.Point(273, 135);
            this.SingleStepButton.Name = "SingleStepButton";
            this.SingleStepButton.Size = new System.Drawing.Size(75, 23);
            this.SingleStepButton.TabIndex = 5;
            this.SingleStepButton.Text = "Single Step";
            this.SingleStepButton.UseVisualStyleBackColor = true;
            this.SingleStepButton.Click += new System.EventHandler(this.SingleStepButton_Click);
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(273, 106);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(75, 23);
            this.StepButton.TabIndex = 4;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(273, 77);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(75, 23);
            this.ResumeButton.TabIndex = 3;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // SuspendButton
            // 
            this.SuspendButton.Location = new System.Drawing.Point(273, 48);
            this.SuspendButton.Name = "SuspendButton";
            this.SuspendButton.Size = new System.Drawing.Size(75, 23);
            this.SuspendButton.TabIndex = 2;
            this.SuspendButton.Text = "Suspend";
            this.SuspendButton.UseVisualStyleBackColor = true;
            this.SuspendButton.Click += new System.EventHandler(this.SuspendButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(273, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ProcessesTreeView
            // 
            this.ProcessesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessesTreeView.HideSelection = false;
            this.ProcessesTreeView.Location = new System.Drawing.Point(4, 3);
            this.ProcessesTreeView.Name = "ProcessesTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Press refresh to start";
            this.ProcessesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.ProcessesTreeView.Size = new System.Drawing.Size(263, 684);
            this.ProcessesTreeView.TabIndex = 0;
            this.ProcessesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProcessesTreeView_AfterSelect);
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Location = new System.Drawing.Point(773, 907);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 9;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // DestroyButton
            // 
            this.DestroyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestroyButton.Location = new System.Drawing.Point(667, 36);
            this.DestroyButton.Name = "DestroyButton";
            this.DestroyButton.Size = new System.Drawing.Size(75, 23);
            this.DestroyButton.TabIndex = 10;
            this.DestroyButton.Text = "Destroy";
            this.DestroyButton.UseVisualStyleBackColor = true;
            this.DestroyButton.Click += new System.EventHandler(this.DestroyButton_Click);
            // 
            // MethodLocalLabelLabel
            // 
            this.MethodLocalLabelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MethodLocalLabelLabel.AutoSize = true;
            this.MethodLocalLabelLabel.Location = new System.Drawing.Point(369, 395);
            this.MethodLocalLabelLabel.Name = "MethodLocalLabelLabel";
            this.MethodLocalLabelLabel.Size = new System.Drawing.Size(66, 13);
            this.MethodLocalLabelLabel.TabIndex = 13;
            this.MethodLocalLabelLabel.Text = "[NO LOCAL]";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter :";
            // 
            // FilterBox
            // 
            this.FilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBox.Location = new System.Drawing.Point(324, 436);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(509, 20);
            this.FilterBox.TabIndex = 15;
            this.FilterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            // 
            // BreakpointsTreeView
            // 
            this.BreakpointsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BreakpointsTreeView.HideSelection = false;
            this.BreakpointsTreeView.Location = new System.Drawing.Point(286, 484);
            this.BreakpointsTreeView.Name = "BreakpointsTreeView";
            this.BreakpointsTreeView.Size = new System.Drawing.Size(547, 109);
            this.BreakpointsTreeView.TabIndex = 16;
            this.BreakpointsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BreakpointsTreeView_AfterSelect);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Breakpoints:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 638);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Debug points:";
            // 
            // DebugPointsTreeView
            // 
            this.DebugPointsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugPointsTreeView.HideSelection = false;
            this.DebugPointsTreeView.Location = new System.Drawing.Point(286, 654);
            this.DebugPointsTreeView.Name = "DebugPointsTreeView";
            this.DebugPointsTreeView.Size = new System.Drawing.Size(547, 140);
            this.DebugPointsTreeView.TabIndex = 19;
            this.DebugPointsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DebugPointsTreeView_AfterSelect);
            // 
            // ClearBreakpointButton
            // 
            this.ClearBreakpointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearBreakpointButton.Location = new System.Drawing.Point(286, 600);
            this.ClearBreakpointButton.Name = "ClearBreakpointButton";
            this.ClearBreakpointButton.Size = new System.Drawing.Size(75, 23);
            this.ClearBreakpointButton.TabIndex = 20;
            this.ClearBreakpointButton.Text = "Clear";
            this.ClearBreakpointButton.UseVisualStyleBackColor = true;
            this.ClearBreakpointButton.Click += new System.EventHandler(this.ClearBreakpointButton_Click);
            // 
            // SetBreakpointButton
            // 
            this.SetBreakpointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetBreakpointButton.Location = new System.Drawing.Point(286, 800);
            this.SetBreakpointButton.Name = "SetBreakpointButton";
            this.SetBreakpointButton.Size = new System.Drawing.Size(75, 23);
            this.SetBreakpointButton.TabIndex = 21;
            this.SetBreakpointButton.Text = "Set";
            this.SetBreakpointButton.UseVisualStyleBackColor = true;
            this.SetBreakpointButton.Click += new System.EventHandler(this.SetBreakpointButton_Click);
            // 
            // Thex86RegistersControl
            // 
            this.Thex86RegistersControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Thex86RegistersControl.EAX = ((uint)(0u));
            this.Thex86RegistersControl.EBP = ((uint)(0u));
            this.Thex86RegistersControl.EBX = ((uint)(0u));
            this.Thex86RegistersControl.ECX = ((uint)(0u));
            this.Thex86RegistersControl.EDX = ((uint)(0u));
            this.Thex86RegistersControl.EIP = ((uint)(0u));
            this.Thex86RegistersControl.ESP = ((uint)(0u));
            this.Thex86RegistersControl.Location = new System.Drawing.Point(4, 693);
            this.Thex86RegistersControl.Name = "Thex86RegistersControl";
            this.Thex86RegistersControl.Size = new System.Drawing.Size(255, 136);
            this.Thex86RegistersControl.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 938);
            this.Controls.Add(this.DestroyButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ConnectingProgressBar);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BinPathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AssemblyNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PipeNameBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "FlingOS Debugger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PipeNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AssemblyNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BinPathBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ProgressBar ConnectingProgressBar;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TreeView ProcessesTreeView;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button SuspendButton;
        private System.Windows.Forms.Button SingleStepButton;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Button DestroyButton;
        private x86RegistersControl Thex86RegistersControl;
        private System.Windows.Forms.TextBox NearestLabelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NearestLabelAddessBox;
        private System.Windows.Forms.TextBox MethodLabelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CurrentMethodBox;
        private System.Windows.Forms.Label MethodLocalLabelLabel;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView BreakpointsTreeView;
        private System.Windows.Forms.TreeView DebugPointsTreeView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SetBreakpointButton;
        private System.Windows.Forms.Button ClearBreakpointButton;
    }
}