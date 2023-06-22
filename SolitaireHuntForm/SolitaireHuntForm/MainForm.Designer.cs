namespace SolitaireHuntForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.position11 = new System.Windows.Forms.PictureBox();
            this.position12 = new System.Windows.Forms.PictureBox();
            this.position13 = new System.Windows.Forms.PictureBox();
            this.position21 = new System.Windows.Forms.PictureBox();
            this.position22 = new System.Windows.Forms.PictureBox();
            this.position23 = new System.Windows.Forms.PictureBox();
            this.position31 = new System.Windows.Forms.PictureBox();
            this.position32 = new System.Windows.Forms.PictureBox();
            this.position33 = new System.Windows.Forms.PictureBox();
            this.endPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.position11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.undoToolStripMenuItem.Text = "Отменить ход";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.rulesToolStripMenuItem.Text = "Правила";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // position11
            // 
            this.position11.ErrorImage = null;
            this.position11.InitialImage = null;
            this.position11.Location = new System.Drawing.Point(50, 60);
            this.position11.Name = "position11";
            this.position11.Size = new System.Drawing.Size(108, 150);
            this.position11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position11.TabIndex = 1;
            this.position11.TabStop = false;
            this.position11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Position11_MouseClick);
            // 
            // position12
            // 
            this.position12.Location = new System.Drawing.Point(250, 60);
            this.position12.Name = "position12";
            this.position12.Size = new System.Drawing.Size(108, 150);
            this.position12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position12.TabIndex = 2;
            this.position12.TabStop = false;
            // 
            // position13
            // 
            this.position13.Location = new System.Drawing.Point(450, 60);
            this.position13.Name = "position13";
            this.position13.Size = new System.Drawing.Size(108, 150);
            this.position13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position13.TabIndex = 3;
            this.position13.TabStop = false;
            // 
            // position21
            // 
            this.position21.Location = new System.Drawing.Point(50, 270);
            this.position21.Name = "position21";
            this.position21.Size = new System.Drawing.Size(108, 150);
            this.position21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position21.TabIndex = 4;
            this.position21.TabStop = false;
            // 
            // position22
            // 
            this.position22.Location = new System.Drawing.Point(250, 270);
            this.position22.Name = "position22";
            this.position22.Size = new System.Drawing.Size(108, 150);
            this.position22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position22.TabIndex = 5;
            this.position22.TabStop = false;
            this.position22.Click += new System.EventHandler(this.Position22_Click);
            // 
            // position23
            // 
            this.position23.ErrorImage = null;
            this.position23.Location = new System.Drawing.Point(450, 270);
            this.position23.Name = "position23";
            this.position23.Size = new System.Drawing.Size(108, 150);
            this.position23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position23.TabIndex = 6;
            this.position23.TabStop = false;
            // 
            // position31
            // 
            this.position31.Location = new System.Drawing.Point(50, 480);
            this.position31.Name = "position31";
            this.position31.Size = new System.Drawing.Size(108, 150);
            this.position31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position31.TabIndex = 7;
            this.position31.TabStop = false;
            // 
            // position32
            // 
            this.position32.Location = new System.Drawing.Point(250, 480);
            this.position32.Name = "position32";
            this.position32.Size = new System.Drawing.Size(108, 150);
            this.position32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position32.TabIndex = 8;
            this.position32.TabStop = false;
            // 
            // position33
            // 
            this.position33.Location = new System.Drawing.Point(450, 480);
            this.position33.Name = "position33";
            this.position33.Size = new System.Drawing.Size(108, 150);
            this.position33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.position33.TabIndex = 9;
            this.position33.TabStop = false;
            // 
            // endPictureBox
            // 
            this.endPictureBox.Location = new System.Drawing.Point(661, 270);
            this.endPictureBox.Name = "endPictureBox";
            this.endPictureBox.Size = new System.Drawing.Size(108, 150);
            this.endPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.endPictureBox.TabIndex = 10;
            this.endPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(803, 681);
            this.Controls.Add(this.endPictureBox);
            this.Controls.Add(this.position33);
            this.Controls.Add(this.position32);
            this.Controls.Add(this.position31);
            this.Controls.Add(this.position23);
            this.Controls.Add(this.position22);
            this.Controls.Add(this.position21);
            this.Controls.Add(this.position13);
            this.Controls.Add(this.position12);
            this.Controls.Add(this.position11);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 728);
            this.MinimumSize = new System.Drawing.Size(821, 728);
            this.Name = "MainForm";
            this.Text = "Пасьянс «Охота»";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.position11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox position11;
        private System.Windows.Forms.PictureBox position12;
        private System.Windows.Forms.PictureBox position13;
        private System.Windows.Forms.PictureBox position21;
        private System.Windows.Forms.PictureBox position22;
        private System.Windows.Forms.PictureBox position23;
        private System.Windows.Forms.PictureBox position31;
        private System.Windows.Forms.PictureBox position32;
        private System.Windows.Forms.PictureBox position33;
        private System.Windows.Forms.PictureBox endPictureBox;
    }
}

