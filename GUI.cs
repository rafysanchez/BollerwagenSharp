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
        c_UCC UCC;
        
        public GUI()
        {
            InitializeComponent();
            UCC = new c_UCC();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None; // Rahmen ausblenden
            //this.TopMost = true; // Formular ganz im Vordergrund, also auch vor der Taskleiste anzeigen
            //this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            UCC.An();
        }

        private void btn_aus_Click(object sender, EventArgs e)
        {
            UCC.Aus();
        }

        public void SchalterAn()
        {
            lbl_switch.Text = "AN";
            lbl_switch.ForeColor = Color.Green;
        }
        public void SchalterAus()
        {
            lbl_switch.Text = "Aus";
            lbl_switch.ForeColor = Color.Red;
        }


    }
}
