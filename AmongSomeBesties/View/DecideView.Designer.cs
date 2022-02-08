
namespace AmongSomeBesties.View
{
    partial class DecideScene
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
            this.btn_Rei = new System.Windows.Forms.Button();
            this.btn_Hua = new System.Windows.Forms.Button();
            this.btn_Joe = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
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
            this.lbl_Dialog.Text = "2069 BC - On the board of SS Sukon:\r\nSomebody has eaten all of the ice cream and " +
    "you as the smartest among the crew have the mission to find who.\r\n\r\n \r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AmongSomeBesties.Properties.Resources.detective;
            this.pictureBox1.Location = new System.Drawing.Point(146, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Rei
            // 
            this.btn_Rei.AutoSize = true;
            this.btn_Rei.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rei.Location = new System.Drawing.Point(452, 142);
            this.btn_Rei.Name = "btn_Rei";
            this.btn_Rei.Size = new System.Drawing.Size(178, 27);
            this.btn_Rei.TabIndex = 3;
            this.btn_Rei.Text = "Rei";
            this.btn_Rei.UseVisualStyleBackColor = true;
            this.btn_Rei.Click += new System.EventHandler(this.btn_Rei_Click);
            // 
            // btn_Hua
            // 
            this.btn_Hua.AutoSize = true;
            this.btn_Hua.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hua.Location = new System.Drawing.Point(452, 175);
            this.btn_Hua.Name = "btn_Hua";
            this.btn_Hua.Size = new System.Drawing.Size(178, 27);
            this.btn_Hua.TabIndex = 4;
            this.btn_Hua.Text = "Captain Fu Hua";
            this.btn_Hua.UseVisualStyleBackColor = true;
            this.btn_Hua.Click += new System.EventHandler(this.btn_Rei_Click);
            // 
            // btn_Joe
            // 
            this.btn_Joe.AutoSize = true;
            this.btn_Joe.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Joe.Location = new System.Drawing.Point(452, 208);
            this.btn_Joe.Name = "btn_Joe";
            this.btn_Joe.Size = new System.Drawing.Size(178, 27);
            this.btn_Joe.TabIndex = 5;
            this.btn_Joe.Text = "Joe";
            this.btn_Joe.UseVisualStyleBackColor = true;
            this.btn_Joe.Click += new System.EventHandler(this.btn_Rei_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.AutoSize = true;
            this.btn_Red.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Red.Location = new System.Drawing.Point(452, 241);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(178, 27);
            this.btn_Red.TabIndex = 6;
            this.btn_Red.Text = "Sussy Baka";
            this.btn_Red.UseVisualStyleBackColor = true;
            this.btn_Red.Click += new System.EventHandler(this.btn_Rei_Click);
            // 
            // btn_end
            // 
            this.btn_end.AutoSize = true;
            this.btn_end.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.Location = new System.Drawing.Point(452, 274);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(218, 27);
            this.btn_end.TabIndex = 7;
            this.btn_end.Text = "Leave it a COLD case";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_Rei_Click);
            // 
            // DecideScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmongSomeBesties.Properties.Resources.spaceship_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Joe);
            this.Controls.Add(this.btn_Hua);
            this.Controls.Add(this.btn_Rei);
            this.Controls.Add(this.lbl_Dialog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DecideScene";
            this.Text = "DecideScene";
            this.Load += new System.EventHandler(this.DecideScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Rei;
        private System.Windows.Forms.Button btn_Hua;
        private System.Windows.Forms.Button btn_Joe;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_end;
    }
}