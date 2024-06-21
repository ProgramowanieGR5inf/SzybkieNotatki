using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzybkieNotatki
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void schowajNagłówekToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FormBorderStyle = FormBorderStyle.None;
      }

      private void pokażNagłówekToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FormBorderStyle = FormBorderStyle.FixedToolWindow;
      }

      private void nowaNotatkaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new Form1().Show();
      }

      private void usuńKartkęToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Program wykonali: Wioletta Paraluk-Staniek, Małgorzata Pach, Łukasz Mermer \n\n\t  \n\n\t ");
      }

      private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         fontDialog1.ShowDialog();
         richTextBox1.SelectionFont = fontDialog1.Font;
      }

      private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
      {
         colorDialog1.ShowDialog();
         richTextBox1.SelectionColor = colorDialog1.Color;
      }

      private void toolStripMenuItem2_Click(object sender, EventArgs e)
      {
         Opacity = 1;
      }

      private void toolStripMenuItem3_Click(object sender, EventArgs e)
      {
         Opacity = 0.7;
      }

      private void toolStripMenuItem4_Click(object sender, EventArgs e)
      {
         Opacity = 0.3;
      }

      private void zawszeNaWierzchuToolStripMenuItem_Click(object sender, EventArgs e)
      {
         TopMost = ! TopMost;
      }

      private void doLewejToolStripMenuItem_Click(object sender, EventArgs e)
      {
         richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
      }

      private void doCentrumToolStripMenuItem_Click(object sender, EventArgs e)
      {
         richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
      }

      private void doPrawejToolStripMenuItem_Click(object sender, EventArgs e)
      {
         richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
      }

      private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void przeczytajNaGłosToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new System.Speech.Synthesis.SpeechSynthesizer().Speak(richTextBox1.Text);
      }

      private void otwórzPlikToolStripMenuItem_Click(object sender, EventArgs e)
      {
         openFileDialog1.ShowDialog();
         richTextBox1.LoadFile(openFileDialog1.FileName);
      }

      private void zapiszPlikToolStripMenuItem_Click(object sender, EventArgs e)
      {
         saveFileDialog1.ShowDialog();
         richTextBox1.SaveFile(saveFileDialog1.FileName);
      }

      static Form1()
      {
         
         foreach (var p in System.IO.Directory.GetFiles(@".\", "*.rtf"))
         {
            
            var okno = new Form1();
           
            okno.richTextBox1.LoadFile(p);
            
            okno.Show();
         }
         
      }
      

      int ostatniaPozycjaMyszyX;
      int ostatniaPozycjaMyszyY;
      private void Form1_MouseDown(object sender, MouseEventArgs e)
      {
         ostatniaPozycjaMyszyX = Cursor.Position.X;
         ostatniaPozycjaMyszyY = Cursor.Position.Y;
      }

      private void Form1_MouseMove(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left) {
            Left += Cursor.Position.X - ostatniaPozycjaMyszyX;
            Top += Cursor.Position.Y - ostatniaPozycjaMyszyY;
            ostatniaPozycjaMyszyX = Cursor.Position.X;
            ostatniaPozycjaMyszyY = Cursor.Position.Y;
         }
      }
    }
}
