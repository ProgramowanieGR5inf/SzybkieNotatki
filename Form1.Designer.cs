namespace SzybkieNotatki
{
    partial class Form1
    {
    
        private System.ComponentModel.IContainer components = null;

       
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowaNotatkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńNotatkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażNagłówekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schowajNagłówekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przezroczystośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zawszeNaWierzchuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przesuńTekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doLewejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doCentrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doPrawejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeczytajNaGłosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 250);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaNotatkaToolStripMenuItem,
            this.usuńNotatkęToolStripMenuItem,
            this.pokażNagłówekToolStripMenuItem,
            this.schowajNagłówekToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.kolorToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.przezroczystośćToolStripMenuItem,
            this.zawszeNaWierzchuToolStripMenuItem,
            this.przesuńTekstToolStripMenuItem,
            this.zamknijProgramToolStripMenuItem,
            this.przeczytajNaGłosToolStripMenuItem,
            this.otwórzPlikToolStripMenuItem,
            this.zapiszPlikToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 340);
            // 
            // nowaNotatkaToolStripMenuItem
            // 
            this.nowaNotatkaToolStripMenuItem.Name = "nowaNotatkaToolStripMenuItem";
            this.nowaNotatkaToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.nowaNotatkaToolStripMenuItem.Text = "Nowa notatka";
            this.nowaNotatkaToolStripMenuItem.Click += new System.EventHandler(this.nowaNotatkaToolStripMenuItem_Click);
            // 
            // usuńNotatkęToolStripMenuItem
            // 
            this.usuńNotatkęToolStripMenuItem.Name = "usuńNotatkęToolStripMenuItem";
            this.usuńNotatkęToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.usuńNotatkęToolStripMenuItem.Text = "Usuń notatkę";
            this.usuńNotatkęToolStripMenuItem.Click += new System.EventHandler(this.usuńKartkęToolStripMenuItem_Click);
            // 
            // pokażNagłówekToolStripMenuItem
            // 
            this.pokażNagłówekToolStripMenuItem.Name = "pokażNagłówekToolStripMenuItem";
            this.pokażNagłówekToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.pokażNagłówekToolStripMenuItem.Text = "Pokaż nagłówek";
            this.pokażNagłówekToolStripMenuItem.Click += new System.EventHandler(this.pokażNagłówekToolStripMenuItem_Click);
            // 
            // schowajNagłówekToolStripMenuItem
            // 
            this.schowajNagłówekToolStripMenuItem.Name = "schowajNagłówekToolStripMenuItem";
            this.schowajNagłówekToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.schowajNagłówekToolStripMenuItem.Text = "Schowaj nagłówek";
            this.schowajNagłówekToolStripMenuItem.Click += new System.EventHandler(this.schowajNagłówekToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.kolorToolStripMenuItem.Text = "Kolor";
            this.kolorToolStripMenuItem.Click += new System.EventHandler(this.kolorToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // przezroczystośćToolStripMenuItem
            // 
            this.przezroczystośćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.przezroczystośćToolStripMenuItem.Name = "przezroczystośćToolStripMenuItem";
            this.przezroczystośćToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.przezroczystośćToolStripMenuItem.Text = "Przezroczystość";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem2.Text = "0%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem3.Text = "30%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem4.Text = "70%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // zawszeNaWierzchuToolStripMenuItem
            // 
            this.zawszeNaWierzchuToolStripMenuItem.Name = "zawszeNaWierzchuToolStripMenuItem";
            this.zawszeNaWierzchuToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.zawszeNaWierzchuToolStripMenuItem.Text = "Zawsze na wierzchu";
            this.zawszeNaWierzchuToolStripMenuItem.Click += new System.EventHandler(this.zawszeNaWierzchuToolStripMenuItem_Click);
            // 
            // przesuńTekstToolStripMenuItem
            // 
            this.przesuńTekstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doLewejToolStripMenuItem,
            this.doCentrumToolStripMenuItem,
            this.doPrawejToolStripMenuItem});
            this.przesuńTekstToolStripMenuItem.Name = "przesuńTekstToolStripMenuItem";
            this.przesuńTekstToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.przesuńTekstToolStripMenuItem.Text = "Przesuń tekst";
            // 
            // doLewejToolStripMenuItem
            // 
            this.doLewejToolStripMenuItem.Name = "doLewejToolStripMenuItem";
            this.doLewejToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.doLewejToolStripMenuItem.Text = "Do lewej";
            this.doLewejToolStripMenuItem.Click += new System.EventHandler(this.doLewejToolStripMenuItem_Click);
            // 
            // doCentrumToolStripMenuItem
            // 
            this.doCentrumToolStripMenuItem.Name = "doCentrumToolStripMenuItem";
            this.doCentrumToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.doCentrumToolStripMenuItem.Text = "Do centrum";
            this.doCentrumToolStripMenuItem.Click += new System.EventHandler(this.doCentrumToolStripMenuItem_Click);
            // 
            // doPrawejToolStripMenuItem
            // 
            this.doPrawejToolStripMenuItem.Name = "doPrawejToolStripMenuItem";
            this.doPrawejToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.doPrawejToolStripMenuItem.Text = "Do prawej";
            this.doPrawejToolStripMenuItem.Click += new System.EventHandler(this.doPrawejToolStripMenuItem_Click);
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // przeczytajNaGłosToolStripMenuItem
            // 
            this.przeczytajNaGłosToolStripMenuItem.Name = "przeczytajNaGłosToolStripMenuItem";
            this.przeczytajNaGłosToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.przeczytajNaGłosToolStripMenuItem.Text = "Przeczytaj na głos";
            this.przeczytajNaGłosToolStripMenuItem.Click += new System.EventHandler(this.przeczytajNaGłosToolStripMenuItem_Click);
            // 
            // otwórzPlikToolStripMenuItem
            // 
            this.otwórzPlikToolStripMenuItem.Name = "otwórzPlikToolStripMenuItem";
            this.otwórzPlikToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.otwórzPlikToolStripMenuItem.Text = "Otwórz plik";
            this.otwórzPlikToolStripMenuItem.Click += new System.EventHandler(this.otwórzPlikToolStripMenuItem_Click);
            // 
            // zapiszPlikToolStripMenuItem
            // 
            this.zapiszPlikToolStripMenuItem.Name = "zapiszPlikToolStripMenuItem";
            this.zapiszPlikToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.zapiszPlikToolStripMenuItem.Text = "Zapisz plik";
            this.zapiszPlikToolStripMenuItem.Click += new System.EventHandler(this.zapiszPlikToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SzybkieNotatki.Properties.Resources.NotatkiTlo;
            this.ClientSize = new System.Drawing.Size(402, 370);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "SzybkieNotatki";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaNotatkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńNotatkęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażNagłówekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schowajNagłówekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem przezroczystośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem zawszeNaWierzchuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przesuńTekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doLewejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doCentrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doPrawejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeczytajNaGłosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszPlikToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

