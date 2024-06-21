using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzybkieNotatki
{
   static class Program
   {
      
      /// Główne wejście do aplikacji 
      
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         new Form1().Show();
         Application.Run();
      }
   }
}
