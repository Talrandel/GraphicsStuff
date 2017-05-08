namespace MandelbrotSet
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxrMin = new System.Windows.Forms.TextBox();
            this.textBoxrMax = new System.Windows.Forms.TextBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelrMin = new System.Windows.Forms.Label();
            this.labelrMax = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxr = new System.Windows.Forms.TextBox();
            this.textBoxg = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.labelr = new System.Windows.Forms.Label();
            this.labelg = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.labelMoveX = new System.Windows.Forms.Label();
            this.labelMoveY = new System.Windows.Forms.Label();
            this.textBoxiMin = new System.Windows.Forms.TextBox();
            this.textBoxiMax = new System.Windows.Forms.TextBox();
            this.labeliMin = new System.Windows.Forms.Label();
            this.labeliMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Location = new System.Drawing.Point(772, 406);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(691, 478);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxrMin
            // 
            this.textBoxrMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxrMin.Location = new System.Drawing.Point(814, 12);
            this.textBoxrMin.Name = "textBoxrMin";
            this.textBoxrMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxrMin.TabIndex = 2;
            this.textBoxrMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxrMax
            // 
            this.textBoxrMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxrMax.Location = new System.Drawing.Point(814, 38);
            this.textBoxrMax.Name = "textBoxrMax";
            this.textBoxrMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxrMax.TabIndex = 2;
            this.textBoxrMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIterations.Location = new System.Drawing.Point(814, 120);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(100, 20);
            this.textBoxIterations.TabIndex = 2;
            this.textBoxIterations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.Location = new System.Drawing.Point(814, 146);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeight.Location = new System.Drawing.Point(814, 172);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelrMin
            // 
            this.labelrMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelrMin.AutoSize = true;
            this.labelrMin.Location = new System.Drawing.Point(695, 15);
            this.labelrMin.Name = "labelrMin";
            this.labelrMin.Size = new System.Drawing.Size(27, 13);
            this.labelrMin.TabIndex = 3;
            this.labelrMin.Text = "rMin";
            // 
            // labelrMax
            // 
            this.labelrMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelrMax.AutoSize = true;
            this.labelrMax.Location = new System.Drawing.Point(695, 41);
            this.labelrMax.Name = "labelrMax";
            this.labelrMax.Size = new System.Drawing.Size(30, 13);
            this.labelrMax.TabIndex = 3;
            this.labelrMax.Text = "rMax";
            // 
            // labelIterations
            // 
            this.labelIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(695, 123);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(50, 13);
            this.labelIterations.TabIndex = 3;
            this.labelIterations.Text = "Iterations";
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(695, 149);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(695, 175);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height";
            // 
            // textBoxr
            // 
            this.textBoxr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxr.Location = new System.Drawing.Point(814, 198);
            this.textBoxr.Name = "textBoxr";
            this.textBoxr.Size = new System.Drawing.Size(100, 20);
            this.textBoxr.TabIndex = 2;
            this.textBoxr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxg
            // 
            this.textBoxg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxg.Location = new System.Drawing.Point(814, 224);
            this.textBoxg.Name = "textBoxg";
            this.textBoxg.Size = new System.Drawing.Size(100, 20);
            this.textBoxg.TabIndex = 2;
            this.textBoxg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxb
            // 
            this.textBoxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxb.Location = new System.Drawing.Point(814, 250);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(100, 20);
            this.textBoxb.TabIndex = 2;
            this.textBoxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelr
            // 
            this.labelr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelr.AutoSize = true;
            this.labelr.Location = new System.Drawing.Point(695, 201);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(10, 13);
            this.labelr.TabIndex = 3;
            this.labelr.Text = "r";
            // 
            // labelg
            // 
            this.labelg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelg.AutoSize = true;
            this.labelg.Location = new System.Drawing.Point(695, 227);
            this.labelg.Name = "labelg";
            this.labelg.Size = new System.Drawing.Size(13, 13);
            this.labelg.TabIndex = 3;
            this.labelg.Text = "g";
            // 
            // labelb
            // 
            this.labelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(695, 253);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(13, 13);
            this.labelb.TabIndex = 3;
            this.labelb.Text = "b";
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZoom.Location = new System.Drawing.Point(814, 276);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.Size = new System.Drawing.Size(100, 20);
            this.textBoxZoom.TabIndex = 2;
            this.textBoxZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelZoom
            // 
            this.labelZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(695, 279);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(34, 13);
            this.labelZoom.TabIndex = 3;
            this.labelZoom.Text = "Zoom";
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(728, 329);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 23);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "U";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.Location = new System.Drawing.Point(698, 354);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "L";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Location = new System.Drawing.Point(728, 379);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "D";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.Location = new System.Drawing.Point(759, 354);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "R";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoveX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMoveX.Enabled = false;
            this.textBoxMoveX.Location = new System.Drawing.Point(814, 356);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.ReadOnly = true;
            this.textBoxMoveX.Size = new System.Drawing.Size(36, 20);
            this.textBoxMoveX.TabIndex = 2;
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoveY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMoveY.Enabled = false;
            this.textBoxMoveY.Location = new System.Drawing.Point(856, 356);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.ReadOnly = true;
            this.textBoxMoveY.Size = new System.Drawing.Size(36, 20);
            this.textBoxMoveY.TabIndex = 2;
            // 
            // labelMoveX
            // 
            this.labelMoveX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMoveX.AutoSize = true;
            this.labelMoveX.Location = new System.Drawing.Point(814, 337);
            this.labelMoveX.Name = "labelMoveX";
            this.labelMoveX.Size = new System.Drawing.Size(41, 13);
            this.labelMoveX.TabIndex = 5;
            this.labelMoveX.Text = "MoveX";
            // 
            // labelMoveY
            // 
            this.labelMoveY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMoveY.AutoSize = true;
            this.labelMoveY.Location = new System.Drawing.Point(853, 337);
            this.labelMoveY.Name = "labelMoveY";
            this.labelMoveY.Size = new System.Drawing.Size(41, 13);
            this.labelMoveY.TabIndex = 5;
            this.labelMoveY.Text = "MoveY";
            // 
            // textBoxiMin
            // 
            this.textBoxiMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxiMin.Location = new System.Drawing.Point(814, 67);
            this.textBoxiMin.Name = "textBoxiMin";
            this.textBoxiMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxiMin.TabIndex = 2;
            this.textBoxiMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxiMax
            // 
            this.textBoxiMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxiMax.Location = new System.Drawing.Point(814, 93);
            this.textBoxiMax.Name = "textBoxiMax";
            this.textBoxiMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxiMax.TabIndex = 2;
            this.textBoxiMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labeliMin
            // 
            this.labeliMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeliMin.AutoSize = true;
            this.labeliMin.Location = new System.Drawing.Point(695, 70);
            this.labeliMin.Name = "labeliMin";
            this.labeliMin.Size = new System.Drawing.Size(26, 13);
            this.labeliMin.TabIndex = 3;
            this.labeliMin.Text = "iMin";
            // 
            // labeliMax
            // 
            this.labeliMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeliMax.AutoSize = true;
            this.labeliMax.Location = new System.Drawing.Point(695, 96);
            this.labeliMax.Name = "labeliMax";
            this.labeliMax.Size = new System.Drawing.Size(29, 13);
            this.labeliMax.TabIndex = 3;
            this.labeliMax.Text = "iMax";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(921, 485);
            this.Controls.Add(this.labelMoveY);
            this.Controls.Add(this.labelMoveX);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelg);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.labeliMax);
            this.Controls.Add(this.labelrMax);
            this.Controls.Add(this.textBoxMoveY);
            this.Controls.Add(this.textBoxMoveX);
            this.Controls.Add(this.textBoxZoom);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.labeliMin);
            this.Controls.Add(this.labelrMin);
            this.Controls.Add(this.textBoxg);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxr);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxiMax);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.textBoxiMin);
            this.Controls.Add(this.textBoxrMax);
            this.Controls.Add(this.textBoxrMin);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonDraw);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Maldelbrot set";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxrMin;
        private System.Windows.Forms.TextBox textBoxrMax;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelrMin;
        private System.Windows.Forms.Label labelrMax;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxr;
        private System.Windows.Forms.TextBox textBoxg;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Label labelg;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox textBoxZoom;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.Label labelMoveX;
        private System.Windows.Forms.Label labelMoveY;
        private System.Windows.Forms.TextBox textBoxiMin;
        private System.Windows.Forms.TextBox textBoxiMax;
        private System.Windows.Forms.Label labeliMin;
        private System.Windows.Forms.Label labeliMax;
    }
}

