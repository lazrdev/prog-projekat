
namespace A13_DVD_Kolekcija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.izmeni = new System.Windows.Forms.TabPage();
            this.analiza = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.o_aplikaciji = new System.Windows.Forms.TabPage();
            this.izlaz = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.izmeni);
            this.tabControl1.Controls.Add(this.analiza);
            this.tabControl1.Controls.Add(this.o_aplikaciji);
            this.tabControl1.Controls.Add(this.izlaz);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 83);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(782, 432);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // izmeni
            // 
            this.izmeni.ForeColor = System.Drawing.Color.Transparent;
            this.izmeni.ImageIndex = 1;
            this.izmeni.Location = new System.Drawing.Point(87, 4);
            this.izmeni.Name = "izmeni";
            this.izmeni.Padding = new System.Windows.Forms.Padding(3);
            this.izmeni.Size = new System.Drawing.Size(691, 424);
            this.izmeni.TabIndex = 0;
            this.izmeni.Text = "Izmeni";
            this.izmeni.UseVisualStyleBackColor = true;
            // 
            // analiza
            // 
            this.analiza.ImageIndex = 0;
            this.analiza.Location = new System.Drawing.Point(87, 4);
            this.analiza.Name = "analiza";
            this.analiza.Padding = new System.Windows.Forms.Padding(3);
            this.analiza.Size = new System.Drawing.Size(691, 424);
            this.analiza.TabIndex = 1;
            this.analiza.Text = "Analiza";
            this.analiza.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bar_chart_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(1, "edit_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(2, "info_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(3, "logout_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // o_aplikaciji
            // 
            this.o_aplikaciji.ImageIndex = 2;
            this.o_aplikaciji.Location = new System.Drawing.Point(87, 4);
            this.o_aplikaciji.Name = "o_aplikaciji";
            this.o_aplikaciji.Size = new System.Drawing.Size(691, 424);
            this.o_aplikaciji.TabIndex = 2;
            this.o_aplikaciji.Text = "O Aplikaciji";
            this.o_aplikaciji.UseVisualStyleBackColor = true;
            // 
            // izlaz
            // 
            this.izlaz.ImageIndex = 3;
            this.izlaz.Location = new System.Drawing.Point(87, 4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(691, 424);
            this.izlaz.TabIndex = 3;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage izmeni;
        private System.Windows.Forms.TabPage analiza;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage o_aplikaciji;
        private System.Windows.Forms.TabPage izlaz;
    }
}

