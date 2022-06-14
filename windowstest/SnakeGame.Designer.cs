namespace SnakeGame
{
    partial class SnakeGame
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
            this.title = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.points = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.gameloop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.title.Location = new System.Drawing.Point(32, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 16);
            this.title.TabIndex = 1;
            this.title.Text = "Snake";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.canvas.Location = new System.Drawing.Point(35, 35);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(400, 400);
            this.canvas.TabIndex = 2;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.points.Location = new System.Drawing.Point(396, 16);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(14, 16);
            this.points.TabIndex = 3;
            this.points.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label.Location = new System.Drawing.Point(344, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 16);
            this.label.TabIndex = 4;
            this.label.Text = "points:";
            // 
            // gameloop
            // 
            this.gameloop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.label);
            this.Controls.Add(this.points);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer gameloop;
        private System.Windows.Forms.Panel canvas;
    }
}

