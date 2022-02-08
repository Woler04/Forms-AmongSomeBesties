
namespace AmongSomeBesties.View
{
    partial class InterrorgationRoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Dialog = new System.Windows.Forms.Label();
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AmongSomeBesties.Properties.Resources.detective;
            this.pictureBox1.Location = new System.Drawing.Point(403, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Dialog
            // 
            this.lbl_Dialog.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Dialog.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dialog.Location = new System.Drawing.Point(91, 331);
            this.lbl_Dialog.Name = "lbl_Dialog";
            this.lbl_Dialog.Padding = new System.Windows.Forms.Padding(15);
            this.lbl_Dialog.Size = new System.Drawing.Size(612, 110);
            this.lbl_Dialog.TabIndex = 7;
            // 
            // pic_red
            // 
            this.pic_red.BackColor = System.Drawing.Color.Transparent;
            this.pic_red.Image = global::AmongSomeBesties.Properties.Resources.red;
            this.pic_red.Location = new System.Drawing.Point(152, 214);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(91, 114);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_red.TabIndex = 8;
            this.pic_red.TabStop = false;
            this.pic_red.Click += new System.EventHandler(this.pic_red_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(628, 147);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Go back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // InterrorgationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmongSomeBesties.Properties.Resources.interrogation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pic_red);
            this.Controls.Add(this.lbl_Dialog);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InterrorgationRoom";
            this.Text = "RedView";
            this.Load += new System.EventHandler(this.InterrorgationRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Dialog;
        private System.Windows.Forms.PictureBox pic_red;
        private System.Windows.Forms.Button btn_Back;
    }
}