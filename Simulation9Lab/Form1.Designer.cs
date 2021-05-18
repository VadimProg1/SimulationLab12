
namespace Simulation9Lab
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
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Games = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Losses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_playOneTour = new System.Windows.Forms.Button();
            this.label_totalTours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start 7 tours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AllowUserToOrderColumns = true;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Games,
            this.Wins,
            this.Draws,
            this.Losses,
            this.Goals,
            this.Misses,
            this.Score});
            this.data.Location = new System.Drawing.Point(12, 69);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(905, 299);
            this.data.TabIndex = 2;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.MinimumWidth = 6;
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Width = 125;
            // 
            // Games
            // 
            this.Games.HeaderText = "Games";
            this.Games.MinimumWidth = 6;
            this.Games.Name = "Games";
            this.Games.ReadOnly = true;
            this.Games.Width = 70;
            // 
            // Wins
            // 
            this.Wins.HeaderText = "Wins";
            this.Wins.MinimumWidth = 6;
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Width = 70;
            // 
            // Draws
            // 
            this.Draws.HeaderText = "Draws";
            this.Draws.MinimumWidth = 6;
            this.Draws.Name = "Draws";
            this.Draws.ReadOnly = true;
            this.Draws.Width = 70;
            // 
            // Losses
            // 
            this.Losses.HeaderText = "Losses";
            this.Losses.MinimumWidth = 6;
            this.Losses.Name = "Losses";
            this.Losses.ReadOnly = true;
            this.Losses.Width = 70;
            // 
            // Goals
            // 
            this.Goals.HeaderText = "Goals";
            this.Goals.MinimumWidth = 6;
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Width = 70;
            // 
            // Misses
            // 
            this.Misses.HeaderText = "Misses";
            this.Misses.MinimumWidth = 6;
            this.Misses.Name = "Misses";
            this.Misses.ReadOnly = true;
            this.Misses.Width = 70;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 70;
            // 
            // button_playOneTour
            // 
            this.button_playOneTour.Enabled = false;
            this.button_playOneTour.Location = new System.Drawing.Point(290, 418);
            this.button_playOneTour.Name = "button_playOneTour";
            this.button_playOneTour.Size = new System.Drawing.Size(118, 30);
            this.button_playOneTour.TabIndex = 3;
            this.button_playOneTour.Text = "Play 1 tour";
            this.button_playOneTour.UseVisualStyleBackColor = true;
            this.button_playOneTour.Click += new System.EventHandler(this.button_playOneTour_Click);
            // 
            // label_totalTours
            // 
            this.label_totalTours.AutoSize = true;
            this.label_totalTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_totalTours.Location = new System.Drawing.Point(449, 422);
            this.label_totalTours.Name = "label_totalTours";
            this.label_totalTours.Size = new System.Drawing.Size(47, 20);
            this.label_totalTours.TabIndex = 5;
            this.label_totalTours.Text = "0 / 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 478);
            this.Controls.Add(this.label_totalTours);
            this.Controls.Add(this.button_playOneTour);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Lab9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Games;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button button_playOneTour;
        private System.Windows.Forms.Label label_totalTours;
    }
}

