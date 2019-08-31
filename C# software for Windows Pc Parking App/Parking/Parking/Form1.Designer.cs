namespace Parking
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
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.A1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Testing button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 444);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ovalShape1.Enabled = false;
            this.ovalShape1.Location = new System.Drawing.Point(354, 265);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(170, 145);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Blue;
            this.A1.Enabled = false;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.White;
            this.A1.Location = new System.Drawing.Point(293, 17);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(279, 104);
            this.A1.TabIndex = 3;
            this.A1.Text = "A1";
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.lblA1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(109, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(420, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Steps";
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Blue;
            this.A2.Enabled = false;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.White;
            this.A2.Location = new System.Drawing.Point(290, 137);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(282, 104);
            this.A2.TabIndex = 11;
            this.A2.Text = "A2";
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Blue;
            this.B1.Enabled = false;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.White;
            this.B1.Location = new System.Drawing.Point(206, 265);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(85, 170);
            this.B1.TabIndex = 12;
            this.B1.Text = "B1";
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Blue;
            this.B2.Enabled = false;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.White;
            this.B2.Location = new System.Drawing.Point(106, 265);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(85, 170);
            this.B2.TabIndex = 13;
            this.B2.Text = "B2";
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Blue;
            this.B3.Enabled = false;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.White;
            this.B3.Location = new System.Drawing.Point(12, 265);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(85, 170);
            this.B3.TabIndex = 14;
            this.B3.Text = "B3";
            this.B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refresh
            // 
            this.refresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label A1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label B3;
        private System.Windows.Forms.Timer refresh;
    }
}

