using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BollerwagenSharp
{
    public partial class GUI : Form
    {
        c_GPIO GPIO;
        
        public GUI()
        {
            InitializeComponent();
            GPIO = new c_GPIO();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None; // Rahmen ausblenden
            //this.TopMost = true; // Formular ganz im Vordergrund, also auch vor der Taskleiste anzeigen
            //this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = GPIO.schalter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GPIO.an();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GPIO.aus();
        }


    }
}
