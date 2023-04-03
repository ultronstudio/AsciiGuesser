using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiGuesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHadej_Click(object sender, EventArgs e)
        {
            // deklarace a inicializace proměnných
            string pismena = tboxPismeno.Text.ToUpper();
            Random random = new Random();
            int mysleneCislo = random.Next(65, 90);

            // pokud bude zadán text delší než 1 znak (ošetřeno ve vlastnostech textboxu)
            if (pismena.Length > 1)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Byl zadán více než jeden znak.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // pokud bude uživatelem zadané písmeno rovno náhodně "myšlenému" písmenu programu
                if ((int)pismena[0] == mysleneCislo)
                {
                    SystemSounds.Question.Play();
                    MessageBox.Show($"Uhodl jsi počítačem myšlené písmeno {pismena[0]}.", "Úspěch!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show($"Neuhodl jsi počítačem myšlené písmeno. Hádal jsi {pismena[0]}, ale myšlené písmeno bylo {(char)mysleneCislo}", "Neúspěch!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Kliknutí na ikonu otazníku v záhlaví aplikace zobrazí MessageBox s informacemi o aplikaci
        /// </summary>
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SystemSounds.Question.Play();
            MessageBox.Show("Aplikace AsciiGuesser\n2023 © Petr Vurm\n\nAplikace AsciiGuesser byla vytvořena jako domácí úkol z předmětu PROGRAMOVÁNÍ na SPŠ Hradební", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
