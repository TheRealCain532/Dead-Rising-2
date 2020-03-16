namespace Dead_Rising_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connected = new System.Windows.Forms.Button();
            this.tmapi = new System.Windows.Forms.RadioButton();
            this.ccapi = new System.Windows.Forms.RadioButton();
            this.speed = new System.Windows.Forms.TrackBar();
            this.weapons = new MetroFramework.Controls.MetroToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GOD = new MetroFramework.Controls.MetroToggle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.atext = new System.Windows.Forms.Label();
            this.ctext = new System.Windows.Forms.Label();
            this.physics = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.Label();
            this.MLevel = new System.Windows.Forms.Button();
            this.MMoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clip = new MetroFramework.Controls.MetroToggle();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MOVE = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connected
            // 
            this.connected.Dock = System.Windows.Forms.DockStyle.Top;
            this.connected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connected.Location = new System.Drawing.Point(20, 60);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(261, 23);
            this.connected.TabIndex = 0;
            this.connected.Text = "Connect/Attach";
            this.connected.UseVisualStyleBackColor = true;
            this.connected.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmapi
            // 
            this.tmapi.AutoSize = true;
            this.tmapi.BackColor = System.Drawing.Color.Transparent;
            this.tmapi.Checked = true;
            this.tmapi.Location = new System.Drawing.Point(206, 13);
            this.tmapi.Name = "tmapi";
            this.tmapi.Size = new System.Drawing.Size(47, 17);
            this.tmapi.TabIndex = 1;
            this.tmapi.TabStop = true;
            this.tmapi.Text = "DEX";
            this.tmapi.UseVisualStyleBackColor = false;
            // 
            // ccapi
            // 
            this.ccapi.AutoSize = true;
            this.ccapi.BackColor = System.Drawing.Color.Transparent;
            this.ccapi.Location = new System.Drawing.Point(160, 13);
            this.ccapi.Name = "ccapi";
            this.ccapi.Size = new System.Drawing.Size(46, 17);
            this.ccapi.TabIndex = 2;
            this.ccapi.Text = "CEX";
            this.ccapi.UseVisualStyleBackColor = false;
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.SystemColors.Window;
            this.speed.LargeChange = 0;
            this.speed.Location = new System.Drawing.Point(20, 214);
            this.speed.Maximum = 255;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(261, 45);
            this.speed.TabIndex = 4;
            this.speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speed.Value = 2;
            this.speed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // weapons
            // 
            this.weapons.AutoSize = true;
            this.weapons.CustomBackground = false;
            this.weapons.DisplayStatus = true;
            this.weapons.FontSize = MetroFramework.MetroLinkSize.Small;
            this.weapons.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.weapons.Location = new System.Drawing.Point(23, 89);
            this.weapons.Name = "weapons";
            this.weapons.Size = new System.Drawing.Size(80, 17);
            this.weapons.Style = MetroFramework.MetroColorStyle.Blue;
            this.weapons.TabIndex = 7;
            this.weapons.Text = "Off";
            this.weapons.Theme = MetroFramework.MetroThemeStyle.Light;
            this.weapons.UseStyleColors = false;
            this.weapons.UseVisualStyleBackColor = true;
            this.weapons.CheckedChanged += new System.EventHandler(this.weapons_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unbreakable Weapons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "God Mode";
            // 
            // GOD
            // 
            this.GOD.AutoSize = true;
            this.GOD.CustomBackground = false;
            this.GOD.DisplayStatus = true;
            this.GOD.FontSize = MetroFramework.MetroLinkSize.Small;
            this.GOD.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.GOD.Location = new System.Drawing.Point(23, 112);
            this.GOD.Name = "GOD";
            this.GOD.Size = new System.Drawing.Size(80, 17);
            this.GOD.Style = MetroFramework.MetroColorStyle.Blue;
            this.GOD.TabIndex = 9;
            this.GOD.Text = "Off";
            this.GOD.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GOD.UseStyleColors = false;
            this.GOD.UseVisualStyleBackColor = true;
            this.GOD.CheckedChanged += new System.EventHandler(this.GOD_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.atext);
            this.groupBox1.Controls.Add(this.ctext);
            this.groupBox1.Controls.Add(this.ccapi);
            this.groupBox1.Controls.Add(this.tmapi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox1.Location = new System.Drawing.Point(20, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 36);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // atext
            // 
            this.atext.AutoSize = true;
            this.atext.ForeColor = System.Drawing.Color.Red;
            this.atext.Location = new System.Drawing.Point(82, 15);
            this.atext.Name = "atext";
            this.atext.Size = new System.Drawing.Size(70, 13);
            this.atext.TabIndex = 4;
            this.atext.Text = "Not Attached";
            // 
            // ctext
            // 
            this.ctext.AutoSize = true;
            this.ctext.ForeColor = System.Drawing.Color.Red;
            this.ctext.Location = new System.Drawing.Point(3, 15);
            this.ctext.Name = "ctext";
            this.ctext.Size = new System.Drawing.Size(79, 13);
            this.ctext.TabIndex = 3;
            this.ctext.Text = "Not Connected";
            // 
            // physics
            // 
            this.physics.FormattingEnabled = true;
            this.physics.Items.AddRange(new object[] {
            "Jump Speed",
            "Move Speed",
            "Walk Through Walls"});
            this.physics.Location = new System.Drawing.Point(20, 187);
            this.physics.Name = "physics";
            this.physics.Size = new System.Drawing.Size(261, 21);
            this.physics.TabIndex = 12;
            this.physics.SelectedIndexChanged += new System.EventHandler(this.physics_SelectedIndexChanged);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(97, 234);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(74, 13);
            this.value.TabIndex = 13;
            this.value.Text = "Current Value:";
            // 
            // MLevel
            // 
            this.MLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MLevel.Location = new System.Drawing.Point(20, 158);
            this.MLevel.Name = "MLevel";
            this.MLevel.Size = new System.Drawing.Size(125, 23);
            this.MLevel.TabIndex = 14;
            this.MLevel.Text = "Max Level (On gain)";
            this.MLevel.UseVisualStyleBackColor = true;
            this.MLevel.Click += new System.EventHandler(this.MLevel_Click);
            // 
            // MMoney
            // 
            this.MMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MMoney.Location = new System.Drawing.Point(156, 158);
            this.MMoney.Name = "MMoney";
            this.MMoney.Size = new System.Drawing.Size(125, 23);
            this.MMoney.TabIndex = 15;
            this.MMoney.Text = "Max Money (On Gain)";
            this.MMoney.UseVisualStyleBackColor = true;
            this.MMoney.Click += new System.EventHandler(this.MMoney_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Walk Through Walls";
            // 
            // clip
            // 
            this.clip.AutoSize = true;
            this.clip.CustomBackground = false;
            this.clip.DisplayStatus = true;
            this.clip.Enabled = false;
            this.clip.FontSize = MetroFramework.MetroLinkSize.Small;
            this.clip.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.clip.Location = new System.Drawing.Point(23, 135);
            this.clip.Name = "clip";
            this.clip.Size = new System.Drawing.Size(80, 17);
            this.clip.Style = MetroFramework.MetroColorStyle.Blue;
            this.clip.TabIndex = 16;
            this.clip.Text = "Off";
            this.clip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clip.UseStyleColors = false;
            this.clip.UseVisualStyleBackColor = true;
            this.clip.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Credits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cain532, GamePwnzer";
            // 
            // MOVE
            // 
            this.MOVE.Tick += new System.EventHandler(this.JUMP_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 299);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clip);
            this.Controls.Add(this.MMoney);
            this.Controls.Add(this.MLevel);
            this.Controls.Add(this.value);
            this.Controls.Add(this.physics);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GOD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weapons);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.connected);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dead Rising 2 Tool";
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connected;
        private System.Windows.Forms.RadioButton tmapi;
        private System.Windows.Forms.RadioButton ccapi;
        private System.Windows.Forms.TrackBar speed;
        private MetroFramework.Controls.MetroToggle weapons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroToggle GOD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label atext;
        private System.Windows.Forms.Label ctext;
        private System.Windows.Forms.ComboBox physics;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Button MLevel;
        private System.Windows.Forms.Button MMoney;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroToggle clip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer MOVE;
    }
}

