namespace RpgGame
{
    partial class Game
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblHpPlayerA = new System.Windows.Forms.Label();
            this.lblHpPlayerB = new System.Windows.Forms.Label();
            this.lblHpPlayerC = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.RichTextBox();
            this.lblHpPlayerD = new System.Windows.Forms.Label();
            this.lblNamePlayA = new System.Windows.Forms.Label();
            this.lblNamePlayB = new System.Windows.Forms.Label();
            this.lblNamePlayC = new System.Windows.Forms.Label();
            this.lblNamePlayD = new System.Windows.Forms.Label();
            this.picPlayerD = new System.Windows.Forms.PictureBox();
            this.picPlayerC = new System.Windows.Forms.PictureBox();
            this.picPlayerB = new System.Windows.Forms.PictureBox();
            this.picPlayerA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHpPlayerA
            // 
            this.lblHpPlayerA.AutoSize = true;
            this.lblHpPlayerA.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHpPlayerA.Location = new System.Drawing.Point(20, 261);
            this.lblHpPlayerA.Name = "lblHpPlayerA";
            this.lblHpPlayerA.Size = new System.Drawing.Size(42, 24);
            this.lblHpPlayerA.TabIndex = 3;
            this.lblHpPlayerA.Text = "HP:";
            // 
            // lblHpPlayerB
            // 
            this.lblHpPlayerB.AutoSize = true;
            this.lblHpPlayerB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHpPlayerB.Location = new System.Drawing.Point(257, 261);
            this.lblHpPlayerB.Name = "lblHpPlayerB";
            this.lblHpPlayerB.Size = new System.Drawing.Size(42, 24);
            this.lblHpPlayerB.TabIndex = 4;
            this.lblHpPlayerB.Text = "HP:";
            // 
            // lblHpPlayerC
            // 
            this.lblHpPlayerC.AutoSize = true;
            this.lblHpPlayerC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHpPlayerC.Location = new System.Drawing.Point(494, 261);
            this.lblHpPlayerC.Name = "lblHpPlayerC";
            this.lblHpPlayerC.Size = new System.Drawing.Size(42, 24);
            this.lblHpPlayerC.TabIndex = 5;
            this.lblHpPlayerC.Text = "HP:";
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAttack.Location = new System.Drawing.Point(801, 434);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(114, 74);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(12, 325);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(594, 231);
            this.txtState.TabIndex = 7;
            this.txtState.Text = "";
            // 
            // lblHpPlayerD
            // 
            this.lblHpPlayerD.AutoSize = true;
            this.lblHpPlayerD.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHpPlayerD.Location = new System.Drawing.Point(733, 261);
            this.lblHpPlayerD.Name = "lblHpPlayerD";
            this.lblHpPlayerD.Size = new System.Drawing.Size(42, 24);
            this.lblHpPlayerD.TabIndex = 5;
            this.lblHpPlayerD.Text = "HP:";
            // 
            // lblNamePlayA
            // 
            this.lblNamePlayA.AutoSize = true;
            this.lblNamePlayA.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNamePlayA.Location = new System.Drawing.Point(20, 220);
            this.lblNamePlayA.Name = "lblNamePlayA";
            this.lblNamePlayA.Size = new System.Drawing.Size(81, 24);
            this.lblNamePlayA.TabIndex = 3;
            this.lblNamePlayA.Text = "PlayerA";
            // 
            // lblNamePlayB
            // 
            this.lblNamePlayB.AutoSize = true;
            this.lblNamePlayB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNamePlayB.Location = new System.Drawing.Point(257, 220);
            this.lblNamePlayB.Name = "lblNamePlayB";
            this.lblNamePlayB.Size = new System.Drawing.Size(79, 24);
            this.lblNamePlayB.TabIndex = 4;
            this.lblNamePlayB.Text = "PlayerB";
            // 
            // lblNamePlayC
            // 
            this.lblNamePlayC.AutoSize = true;
            this.lblNamePlayC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNamePlayC.Location = new System.Drawing.Point(494, 220);
            this.lblNamePlayC.Name = "lblNamePlayC";
            this.lblNamePlayC.Size = new System.Drawing.Size(80, 24);
            this.lblNamePlayC.TabIndex = 5;
            this.lblNamePlayC.Text = "PlayerC";
            // 
            // lblNamePlayD
            // 
            this.lblNamePlayD.AutoSize = true;
            this.lblNamePlayD.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNamePlayD.Location = new System.Drawing.Point(731, 220);
            this.lblNamePlayD.Name = "lblNamePlayD";
            this.lblNamePlayD.Size = new System.Drawing.Size(82, 24);
            this.lblNamePlayD.TabIndex = 5;
            this.lblNamePlayD.Text = "PlayerD";
            // 
            // picPlayerD
            // 
            this.picPlayerD.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerD.Image")));
            this.picPlayerD.Location = new System.Drawing.Point(735, 35);
            this.picPlayerD.Name = "picPlayerD";
            this.picPlayerD.Size = new System.Drawing.Size(146, 142);
            this.picPlayerD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerD.TabIndex = 2;
            this.picPlayerD.TabStop = false;
            // 
            // picPlayerC
            // 
            this.picPlayerC.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerC.Image")));
            this.picPlayerC.Location = new System.Drawing.Point(498, 35);
            this.picPlayerC.Name = "picPlayerC";
            this.picPlayerC.Size = new System.Drawing.Size(145, 160);
            this.picPlayerC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerC.TabIndex = 2;
            this.picPlayerC.TabStop = false;
            // 
            // picPlayerB
            // 
            this.picPlayerB.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerB.Image")));
            this.picPlayerB.Location = new System.Drawing.Point(261, 35);
            this.picPlayerB.Name = "picPlayerB";
            this.picPlayerB.Size = new System.Drawing.Size(148, 174);
            this.picPlayerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerB.TabIndex = 1;
            this.picPlayerB.TabStop = false;
            // 
            // picPlayerA
            // 
            this.picPlayerA.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerA.Image")));
            this.picPlayerA.Location = new System.Drawing.Point(24, 35);
            this.picPlayerA.Name = "picPlayerA";
            this.picPlayerA.Size = new System.Drawing.Size(148, 158);
            this.picPlayerA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerA.TabIndex = 0;
            this.picPlayerA.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 565);
            this.Controls.Add(this.picPlayerD);
            this.Controls.Add(this.picPlayerC);
            this.Controls.Add(this.picPlayerB);
            this.Controls.Add(this.picPlayerA);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblNamePlayD);
            this.Controls.Add(this.lblNamePlayC);
            this.Controls.Add(this.lblHpPlayerD);
            this.Controls.Add(this.lblNamePlayB);
            this.Controls.Add(this.lblHpPlayerC);
            this.Controls.Add(this.lblNamePlayA);
            this.Controls.Add(this.lblHpPlayerB);
            this.Controls.Add(this.lblHpPlayerA);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayerA;
        private System.Windows.Forms.PictureBox picPlayerB;
        private System.Windows.Forms.PictureBox picPlayerC;
        private System.Windows.Forms.Label lblHpPlayerA;
        private System.Windows.Forms.Label lblHpPlayerB;
        private System.Windows.Forms.Label lblHpPlayerC;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.RichTextBox txtState;
        private System.Windows.Forms.Label lblHpPlayerD;
        private System.Windows.Forms.Label lblNamePlayA;
        private System.Windows.Forms.Label lblNamePlayB;
        private System.Windows.Forms.Label lblNamePlayC;
        private System.Windows.Forms.Label lblNamePlayD;
        private System.Windows.Forms.PictureBox picPlayerD;
    }
}

