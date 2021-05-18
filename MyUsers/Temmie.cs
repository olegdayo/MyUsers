using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyUsers
{
    /// <summary>
    /// Party time.
    /// </summary>
    public partial class Temmie : Form
    {
        // Initializing.
        public Temmie()
        {
            InitializeComponent();
            try
            {
                System.Media.SoundPlayer selected = new System.Media.SoundPlayer();
                selected.SoundLocation = "TemmieFlakes.wav";
                selected.PlayLooping();
            }
            catch
            {
            }
        }
    }
}