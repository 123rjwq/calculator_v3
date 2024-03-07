namespace Lots_of_games_v3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.road = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.road2 = new System.Windows.Forms.PictureBox();
            this.machine_opponent4 = new System.Windows.Forms.PictureBox();
            this.machine_opponent1 = new System.Windows.Forms.PictureBox();
            this.machine_opponent3 = new System.Windows.Forms.PictureBox();
            this.machine_opponent2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.button_restart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // road
            // 
            this.road.Image = ((System.Drawing.Image)(resources.GetObject("road.Image")));
            this.road.Location = new System.Drawing.Point(0, 0);
            this.road.Margin = new System.Windows.Forms.Padding(2);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(840, 650);
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(449, 609);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 41);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // road2
            // 
            this.road2.Image = ((System.Drawing.Image)(resources.GetObject("road2.Image")));
            this.road2.Location = new System.Drawing.Point(0, -650);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(840, 650);
            this.road2.TabIndex = 2;
            this.road2.TabStop = false;
            // 
            // machine_opponent4
            // 
            this.machine_opponent4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.machine_opponent4.Image = ((System.Drawing.Image)(resources.GetObject("machine_opponent4.Image")));
            this.machine_opponent4.Location = new System.Drawing.Point(428, -448);
            this.machine_opponent4.Name = "machine_opponent4";
            this.machine_opponent4.Size = new System.Drawing.Size(114, 146);
            this.machine_opponent4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.machine_opponent4.TabIndex = 3;
            this.machine_opponent4.TabStop = false;
            this.machine_opponent4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // machine_opponent1
            // 
            this.machine_opponent1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.machine_opponent1.Image = ((System.Drawing.Image)(resources.GetObject("machine_opponent1.Image")));
            this.machine_opponent1.Location = new System.Drawing.Point(188, -159);
            this.machine_opponent1.Name = "machine_opponent1";
            this.machine_opponent1.Size = new System.Drawing.Size(87, 125);
            this.machine_opponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.machine_opponent1.TabIndex = 4;
            this.machine_opponent1.TabStop = false;
            // 
            // machine_opponent3
            // 
            this.machine_opponent3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.machine_opponent3.Image = ((System.Drawing.Image)(resources.GetObject("machine_opponent3.Image")));
            this.machine_opponent3.Location = new System.Drawing.Point(573, -452);
            this.machine_opponent3.Name = "machine_opponent3";
            this.machine_opponent3.Size = new System.Drawing.Size(83, 107);
            this.machine_opponent3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.machine_opponent3.TabIndex = 5;
            this.machine_opponent3.TabStop = false;
            this.machine_opponent3.Click += new System.EventHandler(this.machine_opponent3_Click);
            // 
            // machine_opponent2
            // 
            this.machine_opponent2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.machine_opponent2.Image = ((System.Drawing.Image)(resources.GetObject("machine_opponent2.Image")));
            this.machine_opponent2.Location = new System.Drawing.Point(311, -1460);
            this.machine_opponent2.Name = "machine_opponent2";
            this.machine_opponent2.Size = new System.Drawing.Size(80, 125);
            this.machine_opponent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.machine_opponent2.TabIndex = 6;
            this.machine_opponent2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.LightCoral;
            this.labelLose.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.Location = new System.Drawing.Point(305, 169);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(228, 36);
            this.labelLose.TabIndex = 7;
            this.labelLose.Text = "Вы проиграли(";
            // 
            // button_restart
            // 
            this.button_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restart.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_restart.Location = new System.Drawing.Point(369, 314);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(112, 42);
            this.button_restart.TabIndex = 8;
            this.button_restart.Text = "Начать заново";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(461, -1991);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(48, 35);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 9;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.LightCoral;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.Location = new System.Drawing.Point(12, 9);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(80, 26);
            this.labelCoins.TabIndex = 10;
            this.labelCoins.Text = "Счет: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.machine_opponent2);
            this.Controls.Add(this.machine_opponent3);
            this.Controls.Add(this.machine_opponent1);
            this.Controls.Add(this.machine_opponent4);
            this.Controls.Add(this.player);
            this.Controls.Add(this.road);
            this.Controls.Add(this.road2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_opponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox machine_opponent4;
        private System.Windows.Forms.PictureBox machine_opponent1;
        private System.Windows.Forms.PictureBox machine_opponent3;
        private System.Windows.Forms.PictureBox machine_opponent2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
    }
}

