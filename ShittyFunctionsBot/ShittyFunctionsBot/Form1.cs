using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace ShittyFunctionsBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRomanConverter_Click(object sender, EventArgs e)
        {
            RomanNumeralConverter RomanNumeralConverter = new RomanNumeralConverter();
            RomanNumeralConverter.Show();    
        }
    }
}
