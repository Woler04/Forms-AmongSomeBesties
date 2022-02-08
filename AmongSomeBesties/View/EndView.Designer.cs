
namespace AmongSomeBesties.View
{
    partial class EndView
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
            this.lbl_end = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_end
            // 
            this.lbl_end.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_end.Font = new System.Drawing.Font("OCR A Extended", 25F);
            this.lbl_end.Location = new System.Drawing.Point(76, 121);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Padding = new System.Windows.Forms.Padding(15);
            this.lbl_end.Size = new System.Drawing.Size(648, 219);
            this.lbl_end.TabIndex = 0;
            this.lbl_end.Text = "You blame Rei. She can\'t accept that you could think she would do such a think to" +
    " you. And now she has depression.";
            this.lbl_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmongSomeBesties.Properties.Resources.end_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_end);
            this.Name = "EndView";
            this.Text = "End";
            this.Load += new System.EventHandler(this.End_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_end;
    }
}