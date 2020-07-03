namespace poorpaint
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawOptions = new System.Windows.Forms.GroupBox();
            this.load_but = new System.Windows.Forms.Button();
            this.shapeOpt = new System.Windows.Forms.ComboBox();
            this.save_but = new System.Windows.Forms.Button();
            this.eraserOpt = new System.Windows.Forms.Button();
            this.colorOptBlue = new System.Windows.Forms.PictureBox();
            this.colorOptRed = new System.Windows.Forms.PictureBox();
            this.colorOptGreen = new System.Windows.Forms.PictureBox();
            this.colorOptBlack = new System.Windows.Forms.PictureBox();
            this.bar_panel = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.PictureBox();
            this.maximize_button = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.drawOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptBlack)).BeginInit();
            this.bar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // drawOptions
            // 
            this.drawOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drawOptions.BackColor = System.Drawing.Color.White;
            this.drawOptions.Controls.Add(this.load_but);
            this.drawOptions.Controls.Add(this.shapeOpt);
            this.drawOptions.Controls.Add(this.save_but);
            this.drawOptions.Controls.Add(this.eraserOpt);
            this.drawOptions.Controls.Add(this.colorOptBlue);
            this.drawOptions.Controls.Add(this.colorOptRed);
            this.drawOptions.Controls.Add(this.colorOptGreen);
            this.drawOptions.Controls.Add(this.colorOptBlack);
            this.drawOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawOptions.Location = new System.Drawing.Point(0, 750);
            this.drawOptions.Name = "drawOptions";
            this.drawOptions.Size = new System.Drawing.Size(323, 50);
            this.drawOptions.TabIndex = 1;
            this.drawOptions.TabStop = false;
            this.drawOptions.Text = "Poor Options";
            // 
            // load_but
            // 
            this.load_but.Location = new System.Drawing.Point(268, 19);
            this.load_but.Name = "load_but";
            this.load_but.Size = new System.Drawing.Size(45, 21);
            this.load_but.TabIndex = 4;
            this.load_but.Text = "Load";
            this.load_but.UseVisualStyleBackColor = true;
            this.load_but.Click += new System.EventHandler(this.load_but_Click);
            // 
            // shapeOpt
            // 
            this.shapeOpt.FormattingEnabled = true;
            this.shapeOpt.Items.AddRange(new object[] {
            "FreeMode",
            "Line",
            "Rectangle"});
            this.shapeOpt.Location = new System.Drawing.Point(138, 19);
            this.shapeOpt.Name = "shapeOpt";
            this.shapeOpt.Size = new System.Drawing.Size(73, 21);
            this.shapeOpt.TabIndex = 5;
            this.shapeOpt.SelectionChangeCommitted += new System.EventHandler(this.shapeOpt_SelectionChangeCommitted);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(217, 19);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(45, 21);
            this.save_but.TabIndex = 3;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // eraserOpt
            // 
            this.eraserOpt.BackColor = System.Drawing.Color.LightCoral;
            this.eraserOpt.Location = new System.Drawing.Point(112, 20);
            this.eraserOpt.Name = "eraserOpt";
            this.eraserOpt.Size = new System.Drawing.Size(20, 20);
            this.eraserOpt.TabIndex = 4;
            this.eraserOpt.Text = "E";
            this.eraserOpt.UseVisualStyleBackColor = false;
            this.eraserOpt.Click += new System.EventHandler(this.eraserOpt_Click);
            // 
            // colorOptBlue
            // 
            this.colorOptBlue.BackColor = System.Drawing.Color.Blue;
            this.colorOptBlue.Location = new System.Drawing.Point(85, 20);
            this.colorOptBlue.Name = "colorOptBlue";
            this.colorOptBlue.Size = new System.Drawing.Size(20, 20);
            this.colorOptBlue.TabIndex = 3;
            this.colorOptBlue.TabStop = false;
            this.colorOptBlue.Click += new System.EventHandler(this.colorOptGreen_Click);
            // 
            // colorOptRed
            // 
            this.colorOptRed.BackColor = System.Drawing.Color.Red;
            this.colorOptRed.Location = new System.Drawing.Point(59, 20);
            this.colorOptRed.Name = "colorOptRed";
            this.colorOptRed.Size = new System.Drawing.Size(20, 20);
            this.colorOptRed.TabIndex = 2;
            this.colorOptRed.TabStop = false;
            this.colorOptRed.Click += new System.EventHandler(this.colorOptGreen_Click);
            // 
            // colorOptGreen
            // 
            this.colorOptGreen.BackColor = System.Drawing.Color.Green;
            this.colorOptGreen.Location = new System.Drawing.Point(33, 20);
            this.colorOptGreen.Name = "colorOptGreen";
            this.colorOptGreen.Size = new System.Drawing.Size(20, 20);
            this.colorOptGreen.TabIndex = 1;
            this.colorOptGreen.TabStop = false;
            this.colorOptGreen.Click += new System.EventHandler(this.colorOptGreen_Click);
            // 
            // colorOptBlack
            // 
            this.colorOptBlack.BackColor = System.Drawing.Color.Black;
            this.colorOptBlack.Location = new System.Drawing.Point(7, 20);
            this.colorOptBlack.Name = "colorOptBlack";
            this.colorOptBlack.Size = new System.Drawing.Size(20, 20);
            this.colorOptBlack.TabIndex = 0;
            this.colorOptBlack.TabStop = false;
            this.colorOptBlack.Click += new System.EventHandler(this.colorOptGreen_Click);
            // 
            // bar_panel
            // 
            this.bar_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bar_panel.Controls.Add(this.add_button);
            this.bar_panel.Controls.Add(this.minimize_button);
            this.bar_panel.Controls.Add(this.maximize_button);
            this.bar_panel.Controls.Add(this.exit_button);
            this.bar_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar_panel.Location = new System.Drawing.Point(0, 0);
            this.bar_panel.Name = "bar_panel";
            this.bar_panel.Size = new System.Drawing.Size(800, 29);
            this.bar_panel.TabIndex = 2;
            this.bar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_panel_MouseDown);
            this.bar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bar_panel_MouseMove);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.BackgroundImage = global::poorpaint.Properties.Resources.plus;
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Location = new System.Drawing.Point(0, 0);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(27, 29);
            this.add_button.TabIndex = 3;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimize_button.BackgroundImage = global::poorpaint.Properties.Resources.minus;
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.Location = new System.Drawing.Point(713, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(29, 29);
            this.minimize_button.TabIndex = 2;
            this.minimize_button.TabStop = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // maximize_button
            // 
            this.maximize_button.BackColor = System.Drawing.Color.Transparent;
            this.maximize_button.BackgroundImage = global::poorpaint.Properties.Resources.fullscreen;
            this.maximize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_button.Location = new System.Drawing.Point(742, 0);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(29, 29);
            this.maximize_button.TabIndex = 1;
            this.maximize_button.TabStop = false;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = global::poorpaint.Properties.Resources.cross;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button.InitialImage = global::poorpaint.Properties.Resources.cross;
            this.exit_button.Location = new System.Drawing.Point(771, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(29, 29);
            this.exit_button.TabIndex = 0;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 800);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.bar_panel);
            this.Controls.Add(this.drawOptions);
            this.Controls.Add(this.canvas);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Poor Paint";
            this.drawOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorOptBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorOptBlack)).EndInit();
            this.bar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox colorOptBlue;
        private System.Windows.Forms.PictureBox colorOptRed;
        private System.Windows.Forms.PictureBox colorOptGreen;
        private System.Windows.Forms.PictureBox colorOptBlack;
        protected System.Windows.Forms.GroupBox drawOptions;
        private System.Windows.Forms.Button eraserOpt;
        private System.Windows.Forms.ComboBox shapeOpt;
        private System.Windows.Forms.Panel bar_panel;
        private System.Windows.Forms.PictureBox exit_button;
        private System.Windows.Forms.PictureBox maximize_button;
        private System.Windows.Forms.PictureBox minimize_button;
        private System.Windows.Forms.Button load_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button add_button;
    }
}

