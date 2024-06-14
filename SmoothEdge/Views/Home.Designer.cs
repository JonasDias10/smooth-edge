namespace SmoothEdge.Views
{
    partial class Home
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
            TabControl = new TabControl();
            TabScreen01 = new TabPage();
            BtnRemoveBorder = new Button();
            BtnReloadWindows = new Button();
            LabelAddedWindows = new Label();
            LabelWindows = new Label();
            ListBoxAddedWindows = new ListBox();
            BtnRemoveWindow = new Button();
            ListBoxWindows = new ListBox();
            BtnAddWindow = new Button();
            TabControl.SuspendLayout();
            TabScreen01.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TabControl.Controls.Add(TabScreen01);
            TabControl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(11, 18);
            TabControl.MaximumSize = new Size(1160, 720);
            TabControl.MinimumSize = new Size(1160, 720);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1160, 720);
            TabControl.TabIndex = 0;
            // 
            // TabScreen01
            // 
            TabScreen01.BackColor = Color.White;
            TabScreen01.BorderStyle = BorderStyle.Fixed3D;
            TabScreen01.Controls.Add(BtnRemoveBorder);
            TabScreen01.Controls.Add(BtnReloadWindows);
            TabScreen01.Controls.Add(LabelAddedWindows);
            TabScreen01.Controls.Add(LabelWindows);
            TabScreen01.Controls.Add(ListBoxAddedWindows);
            TabScreen01.Controls.Add(BtnRemoveWindow);
            TabScreen01.Controls.Add(ListBoxWindows);
            TabScreen01.Controls.Add(BtnAddWindow);
            TabScreen01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabScreen01.Location = new Point(4, 37);
            TabScreen01.Name = "TabScreen01";
            TabScreen01.Padding = new Padding(3);
            TabScreen01.Size = new Size(1152, 679);
            TabScreen01.TabIndex = 0;
            TabScreen01.Text = "Home";
            // 
            // BtnRemoveBorder
            // 
            BtnRemoveBorder.BackColor = Color.LightGreen;
            BtnRemoveBorder.FlatStyle = FlatStyle.System;
            BtnRemoveBorder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemoveBorder.Location = new Point(214, 15);
            BtnRemoveBorder.Name = "BtnRemoveBorder";
            BtnRemoveBorder.Size = new Size(188, 46);
            BtnRemoveBorder.TabIndex = 7;
            BtnRemoveBorder.Text = "Remover Bordas";
            BtnRemoveBorder.UseVisualStyleBackColor = false;
            BtnRemoveBorder.Click += BtnRemoveBorder_Click;
            // 
            // BtnReloadWindows
            // 
            BtnReloadWindows.BackColor = Color.LightGreen;
            BtnReloadWindows.FlatStyle = FlatStyle.System;
            BtnReloadWindows.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReloadWindows.Location = new Point(11, 15);
            BtnReloadWindows.Name = "BtnReloadWindows";
            BtnReloadWindows.Size = new Size(188, 46);
            BtnReloadWindows.TabIndex = 6;
            BtnReloadWindows.Text = "Recaregar Janelas";
            BtnReloadWindows.UseVisualStyleBackColor = false;
            BtnReloadWindows.Click += BtnReloadWindows_Click;
            // 
            // LabelAddedWindows
            // 
            LabelAddedWindows.AutoSize = true;
            LabelAddedWindows.Location = new Point(707, 124);
            LabelAddedWindows.Name = "LabelAddedWindows";
            LabelAddedWindows.Size = new Size(185, 28);
            LabelAddedWindows.TabIndex = 5;
            LabelAddedWindows.Text = "Janelas Adicionadas";
            // 
            // LabelWindows
            // 
            LabelWindows.AutoSize = true;
            LabelWindows.Location = new Point(11, 124);
            LabelWindows.Name = "LabelWindows";
            LabelWindows.Size = new Size(73, 28);
            LabelWindows.TabIndex = 4;
            LabelWindows.Text = "Janelas";
            // 
            // ListBoxAddedWindows
            // 
            ListBoxAddedWindows.FormattingEnabled = true;
            ListBoxAddedWindows.ItemHeight = 28;
            ListBoxAddedWindows.Location = new Point(707, 158);
            ListBoxAddedWindows.Name = "ListBoxAddedWindows";
            ListBoxAddedWindows.Size = new Size(425, 508);
            ListBoxAddedWindows.TabIndex = 3;
            // 
            // BtnRemoveWindow
            // 
            BtnRemoveWindow.BackColor = Color.LightCoral;
            BtnRemoveWindow.FlatStyle = FlatStyle.System;
            BtnRemoveWindow.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            BtnRemoveWindow.Location = new Point(647, 410);
            BtnRemoveWindow.Name = "BtnRemoveWindow";
            BtnRemoveWindow.Size = new Size(54, 150);
            BtnRemoveWindow.TabIndex = 2;
            BtnRemoveWindow.Text = "<";
            BtnRemoveWindow.UseVisualStyleBackColor = false;
            BtnRemoveWindow.Click += BtnRemoveWindow_Click;
            // 
            // ListBoxWindows
            // 
            ListBoxWindows.FormattingEnabled = true;
            ListBoxWindows.ItemHeight = 28;
            ListBoxWindows.Location = new Point(11, 158);
            ListBoxWindows.Name = "ListBoxWindows";
            ListBoxWindows.Size = new Size(629, 508);
            ListBoxWindows.TabIndex = 1;
            // 
            // BtnAddWindow
            // 
            BtnAddWindow.BackColor = Color.LightGreen;
            BtnAddWindow.FlatStyle = FlatStyle.System;
            BtnAddWindow.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            BtnAddWindow.Location = new Point(647, 254);
            BtnAddWindow.Name = "BtnAddWindow";
            BtnAddWindow.Size = new Size(54, 150);
            BtnAddWindow.TabIndex = 0;
            BtnAddWindow.Text = ">";
            BtnAddWindow.UseVisualStyleBackColor = false;
            BtnAddWindow.Click += BtnAddWindow_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(TabControl);
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            TabControl.ResumeLayout(false);
            TabScreen01.ResumeLayout(false);
            TabScreen01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabScreen01;
        private Button BtnAddWindow;
        private Button BtnRemoveWindow;
        private ListBox ListBoxWindows;
        private ListBox ListBoxAddedWindows;
        private Label LabelAddedWindows;
        private Label LabelWindows;
        private Button BtnReloadWindows;
        private Button BtnRemoveBorder;
    }
}