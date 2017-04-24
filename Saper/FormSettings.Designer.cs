namespace Saper
{
    partial class FormSettings
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.hScrollBarX = new System.Windows.Forms.HScrollBar();
            this.hScrollBarY = new System.Windows.Forms.HScrollBar();
            this.labelY = new System.Windows.Forms.Label();
            this.hScrollBarBombs = new System.Windows.Forms.HScrollBar();
            this.labelBomb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(324, 149);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(9, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(10, 15);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(94, 29);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X fields";
            // 
            // hScrollBarX
            // 
            this.hScrollBarX.LargeChange = 1;
            this.hScrollBarX.Location = new System.Drawing.Point(149, 15);
            this.hScrollBarX.Maximum = 30;
            this.hScrollBarX.Minimum = 5;
            this.hScrollBarX.Name = "hScrollBarX";
            this.hScrollBarX.Size = new System.Drawing.Size(239, 29);
            this.hScrollBarX.TabIndex = 0;
            this.hScrollBarX.Value = 10;
            this.hScrollBarX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarX_Scroll);
            // 
            // hScrollBarY
            // 
            this.hScrollBarY.LargeChange = 1;
            this.hScrollBarY.Location = new System.Drawing.Point(149, 58);
            this.hScrollBarY.Maximum = 30;
            this.hScrollBarY.Minimum = 5;
            this.hScrollBarY.Name = "hScrollBarY";
            this.hScrollBarY.Size = new System.Drawing.Size(239, 29);
            this.hScrollBarY.TabIndex = 3;
            this.hScrollBarY.Value = 10;
            this.hScrollBarY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarY_Scroll);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(10, 58);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(93, 29);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y fields";
            // 
            // hScrollBarBombs
            // 
            this.hScrollBarBombs.LargeChange = 1;
            this.hScrollBarBombs.Location = new System.Drawing.Point(149, 100);
            this.hScrollBarBombs.Maximum = 30;
            this.hScrollBarBombs.Minimum = 5;
            this.hScrollBarBombs.Name = "hScrollBarBombs";
            this.hScrollBarBombs.Size = new System.Drawing.Size(239, 29);
            this.hScrollBarBombs.TabIndex = 5;
            this.hScrollBarBombs.Value = 10;
            this.hScrollBarBombs.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBombs_Scroll);
            // 
            // labelBomb
            // 
            this.labelBomb.AutoSize = true;
            this.labelBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBomb.Location = new System.Drawing.Point(10, 100);
            this.labelBomb.Name = "labelBomb";
            this.labelBomb.Size = new System.Drawing.Size(89, 29);
            this.labelBomb.TabIndex = 6;
            this.labelBomb.Text = "Bombs";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 185);
            this.Controls.Add(this.hScrollBarBombs);
            this.Controls.Add(this.labelBomb);
            this.Controls.Add(this.hScrollBarY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.hScrollBarX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.HScrollBar hScrollBarX;
        private System.Windows.Forms.HScrollBar hScrollBarY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.HScrollBar hScrollBarBombs;
        private System.Windows.Forms.Label labelBomb;
    }
}