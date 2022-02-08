
namespace AmongSomeBesties.View
{
    partial class EntrySceneView
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
            this.lbl_Dialog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Option2 = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Dialog
            // 
            this.lbl_Dialog.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Dialog.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dialog.Location = new System.Drawing.Point(91, 331);
            this.lbl_Dialog.Name = "lbl_Dialog";
            this.lbl_Dialog.Padding = new System.Windows.Forms.Padding(15);
            this.lbl_Dialog.Size = new System.Drawing.Size(612, 110);
            this.lbl_Dialog.TabIndex = 0;
            this.lbl_Dialog.Text = "2069 BC - On the board of SS Sukon:\r\nSomebody has eaten all of your ice cream and" +
    " you as the smartest among the crew have the mission to find who.\r\n\r\n \r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AmongSomeBesties.Properties.Resources.detective;
            this.pictureBox1.Location = new System.Drawing.Point(257, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Option2
            // 
            this.btn_Option2.AutoSize = true;
            this.btn_Option2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Option2.Location = new System.Drawing.Point(554, 157);
            this.btn_Option2.Name = "btn_Option2";
            this.btn_Option2.Size = new System.Drawing.Size(178, 27);
            this.btn_Option2.TabIndex = 2;
            this.btn_Option2.Text = "See All Suspects";
            this.btn_Option2.UseVisualStyleBackColor = true;
            this.btn_Option2.Click += new System.EventHandler(this.btn_Option2_Click);
            // 
            // btn_d
            // 
            this.btn_d.AutoSize = true;
            this.btn_d.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.Location = new System.Drawing.Point(95, 157);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(148, 27);
            this.btn_d.TabIndex = 3;
            this.btn_d.Text = "Decide who is";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_Decide);
            // 
            // EntrySceneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmongSomeBesties.Properties.Resources.spaceship_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_Option2);
            this.Controls.Add(this.lbl_Dialog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EntrySceneView";
            this.Text = "EntrySceneView";
            this.Load += new System.EventHandler(this.EntrySceneView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Option2;
        private System.Windows.Forms.Button btn_d;
    }
}