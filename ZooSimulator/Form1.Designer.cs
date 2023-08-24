namespace ZooSimulator
{
    partial class Form1
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
            this.labelCurrentTimeClock = new System.Windows.Forms.Label();
            this.labelCurrentTimeStamp = new System.Windows.Forms.Label();
            this.labelCurrentDay = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.elephantArea = new System.Windows.Forms.Panel();
            this.giraffeArea = new System.Windows.Forms.Panel();
            this.monkeyArea = new System.Windows.Forms.Panel();
            this.labelMonkeyText = new System.Windows.Forms.Label();
            this.labelGiraffeText = new System.Windows.Forms.Label();
            this.labelElephantText = new System.Windows.Forms.Label();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.flowAnimalsList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFeedZoo = new System.Windows.Forms.Button();
            this.takeHealth = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCurrentTimeClock
            // 
            this.labelCurrentTimeClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentTimeClock.Font = new System.Drawing.Font("BigNoodleTitling", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTimeClock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentTimeClock.Location = new System.Drawing.Point(687, 0);
            this.labelCurrentTimeClock.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentTimeClock.Name = "labelCurrentTimeClock";
            this.labelCurrentTimeClock.Size = new System.Drawing.Size(157, 89);
            this.labelCurrentTimeClock.TabIndex = 3;
            this.labelCurrentTimeClock.Text = "06:25";
            this.labelCurrentTimeClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCurrentTimeClock.UseCompatibleTextRendering = true;
            // 
            // labelCurrentTimeStamp
            // 
            this.labelCurrentTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentTimeStamp.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTimeStamp.Font = new System.Drawing.Font("BigNoodleTitling", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTimeStamp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentTimeStamp.Location = new System.Drawing.Point(664, 42);
            this.labelCurrentTimeStamp.Name = "labelCurrentTimeStamp";
            this.labelCurrentTimeStamp.Size = new System.Drawing.Size(38, 30);
            this.labelCurrentTimeStamp.TabIndex = 2;
            this.labelCurrentTimeStamp.Text = "PM";
            this.labelCurrentTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCurrentDay
            // 
            this.labelCurrentDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDay.Font = new System.Drawing.Font("BigNoodleTitling", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDay.Location = new System.Drawing.Point(561, 42);
            this.labelCurrentDay.Name = "labelCurrentDay";
            this.labelCurrentDay.Size = new System.Drawing.Size(110, 30);
            this.labelCurrentDay.TabIndex = 3;
            this.labelCurrentDay.Text = "Saturday";
            this.labelCurrentDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDate.Font = new System.Drawing.Font("BigNoodleTitling", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(556, 12);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(146, 30);
            this.labelCurrentDate.TabIndex = 4;
            this.labelCurrentDate.Text = "January 2019";
            this.labelCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elephantArea
            // 
            this.elephantArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elephantArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.elephantArea.Location = new System.Drawing.Point(365, 555);
            this.elephantArea.Name = "elephantArea";
            this.elephantArea.Size = new System.Drawing.Size(466, 185);
            this.elephantArea.TabIndex = 6;
            // 
            // giraffeArea
            // 
            this.giraffeArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.giraffeArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.giraffeArea.Location = new System.Drawing.Point(609, 260);
            this.giraffeArea.Name = "giraffeArea";
            this.giraffeArea.Size = new System.Drawing.Size(222, 246);
            this.giraffeArea.TabIndex = 7;
            // 
            // monkeyArea
            // 
            this.monkeyArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monkeyArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monkeyArea.Location = new System.Drawing.Point(365, 260);
            this.monkeyArea.Name = "monkeyArea";
            this.monkeyArea.Size = new System.Drawing.Size(223, 246);
            this.monkeyArea.TabIndex = 8;
            // 
            // labelMonkeyText
            // 
            this.labelMonkeyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonkeyText.AutoSize = true;
            this.labelMonkeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonkeyText.Location = new System.Drawing.Point(360, 223);
            this.labelMonkeyText.Name = "labelMonkeyText";
            this.labelMonkeyText.Size = new System.Drawing.Size(107, 34);
            this.labelMonkeyText.TabIndex = 9;
            this.labelMonkeyText.Text = "Monkeys";
            this.labelMonkeyText.UseCompatibleTextRendering = true;
            // 
            // labelGiraffeText
            // 
            this.labelGiraffeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGiraffeText.AutoSize = true;
            this.labelGiraffeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiraffeText.Location = new System.Drawing.Point(604, 223);
            this.labelGiraffeText.Name = "labelGiraffeText";
            this.labelGiraffeText.Size = new System.Drawing.Size(95, 34);
            this.labelGiraffeText.TabIndex = 10;
            this.labelGiraffeText.Text = "Giraffes";
            this.labelGiraffeText.UseCompatibleTextRendering = true;
            // 
            // labelElephantText
            // 
            this.labelElephantText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElephantText.AutoSize = true;
            this.labelElephantText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElephantText.Location = new System.Drawing.Point(360, 518);
            this.labelElephantText.Name = "labelElephantText";
            this.labelElephantText.Size = new System.Drawing.Size(119, 34);
            this.labelElephantText.TabIndex = 11;
            this.labelElephantText.Text = "Elephants";
            this.labelElephantText.UseCompatibleTextRendering = true;
            // 
            // dateTimer
            // 
            this.dateTimer.Enabled = true;
            this.dateTimer.Interval = 300;
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // flowAnimalsList
            // 
            this.flowAnimalsList.BackColor = System.Drawing.SystemColors.Menu;
            this.flowAnimalsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowAnimalsList.Location = new System.Drawing.Point(13, 12);
            this.flowAnimalsList.Margin = new System.Windows.Forms.Padding(0);
            this.flowAnimalsList.Name = "flowAnimalsList";
            this.flowAnimalsList.Size = new System.Drawing.Size(269, 728);
            this.flowAnimalsList.TabIndex = 12;
            this.flowAnimalsList.WrapContents = false;
            // 
            // btnFeedZoo
            // 
            this.btnFeedZoo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFeedZoo.AutoSize = true;
            this.btnFeedZoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btnFeedZoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFeedZoo.FlatAppearance.BorderSize = 0;
            this.btnFeedZoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedZoo.Image = global::ZooSimulator.Properties.Resources.diet_button;
            this.btnFeedZoo.Location = new System.Drawing.Point(365, 12);
            this.btnFeedZoo.Name = "btnFeedZoo";
            this.btnFeedZoo.Size = new System.Drawing.Size(69, 60);
            this.btnFeedZoo.TabIndex = 5;
            this.btnFeedZoo.TabStop = false;
            this.btnFeedZoo.UseVisualStyleBackColor = false;
            this.btnFeedZoo.Click += new System.EventHandler(this.btnFeedZoo_Click);
            // 
            // takeHealth
            // 
            this.takeHealth.Tick += new System.EventHandler(this.takeHealth_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 749);
            this.Controls.Add(this.flowAnimalsList);
            this.Controls.Add(this.labelElephantText);
            this.Controls.Add(this.labelGiraffeText);
            this.Controls.Add(this.labelMonkeyText);
            this.Controls.Add(this.monkeyArea);
            this.Controls.Add(this.giraffeArea);
            this.Controls.Add(this.elephantArea);
            this.Controls.Add(this.btnFeedZoo);
            this.Controls.Add(this.labelCurrentTimeStamp);
            this.Controls.Add(this.labelCurrentDay);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelCurrentTimeClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ZooSimulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentTimeClock;
        private System.Windows.Forms.Label labelCurrentTimeStamp;
        private System.Windows.Forms.Label labelCurrentDay;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Button btnFeedZoo;
        private System.Windows.Forms.Panel elephantArea;
        private System.Windows.Forms.Panel giraffeArea;
        private System.Windows.Forms.Panel monkeyArea;
        private System.Windows.Forms.Label labelMonkeyText;
        private System.Windows.Forms.Label labelGiraffeText;
        private System.Windows.Forms.Label labelElephantText;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.FlowLayoutPanel flowAnimalsList;
        private System.Windows.Forms.Timer takeHealth;
    }
}

