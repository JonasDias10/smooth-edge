namespace SplitScreen.Views
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
            tabControl = new TabControl();
            tabScreen01 = new TabPage();
            labelAddedWnd = new Label();
            labelWnds = new Label();
            listBoxWindowsAdded = new ListBox();
            btnRemoveWnd = new Button();
            listBoxWindows = new ListBox();
            btnAddWnd = new Button();
            tabScreen02 = new TabPage();
            tabControl.SuspendLayout();
            tabScreen01.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tabControl.Controls.Add(tabScreen01);
            tabControl.Controls.Add(tabScreen02);
            tabControl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(11, 18);
            tabControl.MaximumSize = new Size(1160, 720);
            tabControl.MinimumSize = new Size(1160, 720);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1160, 720);
            tabControl.TabIndex = 0;
            // 
            // tabScreen01
            // 
            tabScreen01.BackColor = Color.White;
            tabScreen01.Controls.Add(labelAddedWnd);
            tabScreen01.Controls.Add(labelWnds);
            tabScreen01.Controls.Add(listBoxWindowsAdded);
            tabScreen01.Controls.Add(btnRemoveWnd);
            tabScreen01.Controls.Add(listBoxWindows);
            tabScreen01.Controls.Add(btnAddWnd);
            tabScreen01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabScreen01.Location = new Point(4, 37);
            tabScreen01.Name = "tabScreen01";
            tabScreen01.Padding = new Padding(3);
            tabScreen01.Size = new Size(1152, 679);
            tabScreen01.TabIndex = 0;
            tabScreen01.Text = "Home";
            // 
            // labelAddedWnd
            // 
            labelAddedWnd.AutoSize = true;
            labelAddedWnd.Location = new Point(721, 111);
            labelAddedWnd.Name = "labelAddedWnd";
            labelAddedWnd.Size = new Size(185, 28);
            labelAddedWnd.TabIndex = 5;
            labelAddedWnd.Text = "Janelas Adicionadas";
            // 
            // labelWnds
            // 
            labelWnds.AutoSize = true;
            labelWnds.Location = new Point(25, 111);
            labelWnds.Name = "labelWnds";
            labelWnds.Size = new Size(73, 28);
            labelWnds.TabIndex = 4;
            labelWnds.Text = "Janelas";
            // 
            // listBoxWindowsAdded
            // 
            listBoxWindowsAdded.FormattingEnabled = true;
            listBoxWindowsAdded.ItemHeight = 28;
            listBoxWindowsAdded.Location = new Point(721, 145);
            listBoxWindowsAdded.Name = "listBoxWindowsAdded";
            listBoxWindowsAdded.Size = new Size(425, 508);
            listBoxWindowsAdded.TabIndex = 3;
            // 
            // btnRemoveWnd
            // 
            btnRemoveWnd.BackColor = Color.LightCoral;
            btnRemoveWnd.FlatStyle = FlatStyle.System;
            btnRemoveWnd.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            btnRemoveWnd.Location = new Point(661, 397);
            btnRemoveWnd.Name = "btnRemoveWnd";
            btnRemoveWnd.Size = new Size(54, 150);
            btnRemoveWnd.TabIndex = 2;
            btnRemoveWnd.Text = "<";
            btnRemoveWnd.UseVisualStyleBackColor = false;
            // 
            // listBoxWindows
            // 
            listBoxWindows.FormattingEnabled = true;
            listBoxWindows.ItemHeight = 28;
            listBoxWindows.Location = new Point(25, 145);
            listBoxWindows.Name = "listBoxWindows";
            listBoxWindows.Size = new Size(629, 508);
            listBoxWindows.TabIndex = 1;
            // 
            // btnAddWnd
            // 
            btnAddWnd.BackColor = Color.LightGreen;
            btnAddWnd.FlatStyle = FlatStyle.System;
            btnAddWnd.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            btnAddWnd.Location = new Point(661, 241);
            btnAddWnd.Name = "btnAddWnd";
            btnAddWnd.Size = new Size(54, 150);
            btnAddWnd.TabIndex = 0;
            btnAddWnd.Text = ">";
            btnAddWnd.UseVisualStyleBackColor = false;
            // 
            // tabScreen02
            // 
            tabScreen02.BackColor = Color.White;
            tabScreen02.Location = new Point(4, 37);
            tabScreen02.Name = "tabScreen02";
            tabScreen02.Padding = new Padding(3);
            tabScreen02.Size = new Size(1152, 679);
            tabScreen02.TabIndex = 1;
            tabScreen02.Text = "Configurações";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(tabControl);
            MaximumSize = new Size(1200, 800);
            MinimumSize = new Size(1200, 800);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            tabControl.ResumeLayout(false);
            tabScreen01.ResumeLayout(false);
            tabScreen01.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabScreen01;
        private TabPage tabScreen02;
        private Button btnAddWnd;
        private Button btnRemoveWnd;
        private ListBox listBoxWindows;
        private ListBox listBoxWindowsAdded;
        private Label labelAddedWnd;
        private Label labelWnds;
    }
}