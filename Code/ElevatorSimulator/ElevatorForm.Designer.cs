namespace ElevatorSimulator
{
    partial class ElevatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorForm));
            this.DoorOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.DoorCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.Moves = new System.Windows.Forms.Timer(this.components);
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.BtnFirstFloor = new System.Windows.Forms.PictureBox();
            this.BtnSecondFloor = new System.Windows.Forms.PictureBox();
            this.ForceClose = new System.Windows.Forms.PictureBox();
            this.ForceOpen = new System.Windows.Forms.PictureBox();
            this.DisplayPanel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRequestBot = new System.Windows.Forms.PictureBox();
            this.BtnRequestTop = new System.Windows.Forms.PictureBox();
            this.BotDoorPanel = new System.Windows.Forms.Panel();
            this.LeftDoorBot = new System.Windows.Forms.PictureBox();
            this.RightDoorBot = new System.Windows.Forms.PictureBox();
            this.DoorPanel = new System.Windows.Forms.Panel();
            this.LeftDoorTop = new System.Windows.Forms.PictureBox();
            this.RightDoorTop = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElevatorFirst = new System.Windows.Forms.PictureBox();
            this.Log = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFirstFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSecondFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRequestBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRequestTop)).BeginInit();
            this.BotDoorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorBot)).BeginInit();
            this.DoorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log)).BeginInit();
            this.SuspendLayout();
            // 
            // DoorOpenTimer
            // 
            this.DoorOpenTimer.Interval = 10;
            this.DoorOpenTimer.Tick += new System.EventHandler(this.DoorOpenTimer_Tick);
            // 
            // DoorCloseTimer
            // 
            this.DoorCloseTimer.Interval = 10;
            this.DoorCloseTimer.Tick += new System.EventHandler(this.DoorCloseTimer_Tick);
            // 
            // Moves
            // 
            this.Moves.Interval = 10;
            this.Moves.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 10;
            this.MoveUp.Tick += new System.EventHandler(this.MoveUp_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 3000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // BtnFirstFloor
            // 
            this.BtnFirstFloor.BackgroundImage = global::ElevatorSimulator.Properties.Resources.iconground;
            this.BtnFirstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFirstFloor.Location = new System.Drawing.Point(381, 429);
            this.BtnFirstFloor.Name = "BtnFirstFloor";
            this.BtnFirstFloor.Size = new System.Drawing.Size(50, 50);
            this.BtnFirstFloor.TabIndex = 19;
            this.BtnFirstFloor.TabStop = false;
            this.BtnFirstFloor.Click += new System.EventHandler(this.BtnFirstFloor_Click);
            // 
            // BtnSecondFloor
            // 
            this.BtnSecondFloor.BackColor = System.Drawing.Color.Transparent;
            this.BtnSecondFloor.BackgroundImage = global::ElevatorSimulator.Properties.Resources.icon1st;
            this.BtnSecondFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecondFloor.Location = new System.Drawing.Point(463, 429);
            this.BtnSecondFloor.Name = "BtnSecondFloor";
            this.BtnSecondFloor.Size = new System.Drawing.Size(50, 50);
            this.BtnSecondFloor.TabIndex = 18;
            this.BtnSecondFloor.TabStop = false;
            this.BtnSecondFloor.Click += new System.EventHandler(this.BtnSecondFloor_Click);
            // 
            // ForceClose
            // 
            this.ForceClose.BackgroundImage = global::ElevatorSimulator.Properties.Resources.closedoorsbutton;
            this.ForceClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForceClose.Location = new System.Drawing.Point(463, 360);
            this.ForceClose.Name = "ForceClose";
            this.ForceClose.Size = new System.Drawing.Size(50, 50);
            this.ForceClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ForceClose.TabIndex = 17;
            this.ForceClose.TabStop = false;
            this.ForceClose.Click += new System.EventHandler(this.ForceClose_Click);
            // 
            // ForceOpen
            // 
            this.ForceOpen.BackgroundImage = global::ElevatorSimulator.Properties.Resources.opendoorbutton;
            this.ForceOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForceOpen.Location = new System.Drawing.Point(381, 360);
            this.ForceOpen.Name = "ForceOpen";
            this.ForceOpen.Size = new System.Drawing.Size(50, 50);
            this.ForceOpen.TabIndex = 16;
            this.ForceOpen.TabStop = false;
            this.ForceOpen.Click += new System.EventHandler(this.ForceOpen_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackgroundImage = global::ElevatorSimulator.Properties.Resources.GroundFloor;
            this.DisplayPanel.Location = new System.Drawing.Point(371, 79);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(150, 245);
            this.DisplayPanel.TabIndex = 15;
            this.DisplayPanel.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ElevatorSimulator.Properties.Resources.Metalbg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(357, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 490);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRequestBot
            // 
            this.BtnRequestBot.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestUp;
            this.BtnRequestBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRequestBot.Location = new System.Drawing.Point(243, 422);
            this.BtnRequestBot.Name = "BtnRequestBot";
            this.BtnRequestBot.Size = new System.Drawing.Size(52, 51);
            this.BtnRequestBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRequestBot.TabIndex = 13;
            this.BtnRequestBot.TabStop = false;
            this.BtnRequestBot.Click += new System.EventHandler(this.BtnRequestBot_Click);
            // 
            // BtnRequestTop
            // 
            this.BtnRequestTop.BackgroundImage = global::ElevatorSimulator.Properties.Resources.BtnRequestDown;
            this.BtnRequestTop.Location = new System.Drawing.Point(242, 131);
            this.BtnRequestTop.Name = "BtnRequestTop";
            this.BtnRequestTop.Size = new System.Drawing.Size(52, 52);
            this.BtnRequestTop.TabIndex = 13;
            this.BtnRequestTop.TabStop = false;
            this.BtnRequestTop.Click += new System.EventHandler(this.BtnRequestTop_Click);
            // 
            // BotDoorPanel
            // 
            this.BotDoorPanel.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorInside1;
            this.BotDoorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotDoorPanel.Controls.Add(this.LeftDoorBot);
            this.BotDoorPanel.Controls.Add(this.RightDoorBot);
            this.BotDoorPanel.Location = new System.Drawing.Point(114, 361);
            this.BotDoorPanel.Name = "BotDoorPanel";
            this.BotDoorPanel.Size = new System.Drawing.Size(106, 190);
            this.BotDoorPanel.TabIndex = 12;
            // 
            // LeftDoorBot
            // 
            this.LeftDoorBot.Image = ((System.Drawing.Image)(resources.GetObject("LeftDoorBot.Image")));
            this.LeftDoorBot.Location = new System.Drawing.Point(0, 0);
            this.LeftDoorBot.Name = "LeftDoorBot";
            this.LeftDoorBot.Size = new System.Drawing.Size(53, 190);
            this.LeftDoorBot.TabIndex = 3;
            this.LeftDoorBot.TabStop = false;
            // 
            // RightDoorBot
            // 
            this.RightDoorBot.Image = ((System.Drawing.Image)(resources.GetObject("RightDoorBot.Image")));
            this.RightDoorBot.Location = new System.Drawing.Point(53, 0);
            this.RightDoorBot.Name = "RightDoorBot";
            this.RightDoorBot.Size = new System.Drawing.Size(53, 190);
            this.RightDoorBot.TabIndex = 3;
            this.RightDoorBot.TabStop = false;
            // 
            // DoorPanel
            // 
            this.DoorPanel.BackgroundImage = global::ElevatorSimulator.Properties.Resources.ElevatorInside1;
            this.DoorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoorPanel.Controls.Add(this.LeftDoorTop);
            this.DoorPanel.Controls.Add(this.RightDoorTop);
            this.DoorPanel.Location = new System.Drawing.Point(114, 70);
            this.DoorPanel.Name = "DoorPanel";
            this.DoorPanel.Size = new System.Drawing.Size(106, 190);
            this.DoorPanel.TabIndex = 10;
            // 
            // LeftDoorTop
            // 
            this.LeftDoorTop.Image = ((System.Drawing.Image)(resources.GetObject("LeftDoorTop.Image")));
            this.LeftDoorTop.Location = new System.Drawing.Point(0, 0);
            this.LeftDoorTop.Name = "LeftDoorTop";
            this.LeftDoorTop.Size = new System.Drawing.Size(53, 190);
            this.LeftDoorTop.TabIndex = 3;
            this.LeftDoorTop.TabStop = false;
            // 
            // RightDoorTop
            // 
            this.RightDoorTop.Image = ((System.Drawing.Image)(resources.GetObject("RightDoorTop.Image")));
            this.RightDoorTop.Location = new System.Drawing.Point(53, -1);
            this.RightDoorTop.Name = "RightDoorTop";
            this.RightDoorTop.Size = new System.Drawing.Size(53, 190);
            this.RightDoorTop.TabIndex = 3;
            this.RightDoorTop.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(114, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 190);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ElevatorFirst
            // 
            this.ElevatorFirst.Image = ((System.Drawing.Image)(resources.GetObject("ElevatorFirst.Image")));
            this.ElevatorFirst.Location = new System.Drawing.Point(14, 32);
            this.ElevatorFirst.Name = "ElevatorFirst";
            this.ElevatorFirst.Size = new System.Drawing.Size(307, 265);
            this.ElevatorFirst.TabIndex = 0;
            this.ElevatorFirst.TabStop = false;
            // 
            // Log
            // 
            this.Log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Log.Location = new System.Drawing.Point(568, 26);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.RowHeadersVisible = false;
            this.Log.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.Log.RowTemplate.Height = 28;
            this.Log.Size = new System.Drawing.Size(283, 563);
            this.Log.TabIndex = 20;

            // 
            // ElevatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(865, 606);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BtnFirstFloor);
            this.Controls.Add(this.BtnSecondFloor);
            this.Controls.Add(this.ForceClose);
            this.Controls.Add(this.ForceOpen);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRequestBot);
            this.Controls.Add(this.BtnRequestTop);
            this.Controls.Add(this.BotDoorPanel);
            this.Controls.Add(this.DoorPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ElevatorFirst);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElevatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElevatorSimulator";
            this.Load += new System.EventHandler(this.ElevatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnFirstFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSecondFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRequestBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRequestTop)).EndInit();
            this.BotDoorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorBot)).EndInit();
            this.DoorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftDoorTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDoorTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ElevatorFirst;
        private System.Windows.Forms.Timer DoorOpenTimer;
        private System.Windows.Forms.PictureBox LeftDoorTop;
        private System.Windows.Forms.Timer DoorCloseTimer;
        private System.Windows.Forms.PictureBox RightDoorTop;
        private System.Windows.Forms.Timer Moves;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LeftDoorBot;
        private System.Windows.Forms.PictureBox RightDoorBot;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Panel DoorPanel;
        private System.Windows.Forms.Panel BotDoorPanel;
        private System.Windows.Forms.PictureBox BtnRequestTop;
        private System.Windows.Forms.PictureBox BtnRequestBot;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox DisplayPanel;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.PictureBox ForceOpen;
        private System.Windows.Forms.PictureBox ForceClose;
        private System.Windows.Forms.PictureBox BtnSecondFloor;
        private System.Windows.Forms.PictureBox BtnFirstFloor;
        private System.Windows.Forms.DataGridView Log;
    }
}

