using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Piano
{
    public partial class Piano : Form
    {
        public Piano()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noteImage.ImageLocation = "MusicalNote.png";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
        }

        private void playNote(Panel keyPanel, string notePath)
        {
            Color keyColor = keyPanel.BackColor;
            keyPanel.BackColor = Color.Red;
            keyPanel.Refresh();

            using (SoundPlayer sp = new SoundPlayer(notePath))
            {
                sp.Play();
            }

            Thread.Sleep(50);

            keyPanel.BackColor = keyColor;

        }


        #region notes

        private void cKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(cKey, @"Sounds/WEP sus m3 C3 -11.wav");
        }

        private void cSharpKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(cSharpKey, @"Sounds/WEP sus m3 C#3 -11.wav");
        }

        private void dKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(dKey, @"Sounds/WEP sus m3 D3 -11.wav");
        }

        private void dSharpKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(dSharpKey, @"Sounds/WEP sus m3 D#3 -11.wav");
        }

        private void eKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(eKey, @"Sounds/WEP sus m3 E3 -11.wav");
        }

        private void fKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(fKey, @"Sounds/WEP sus m3 F3 -11.wav");
        }

        private void fSharpKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(fSharpKey, @"Sounds/WEP sus m3 F#3 -11.wav");
        }

        private void gKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(gKey, @"Sounds/WEP sus m3 G3 -11.wav");
        }

        private void gSharpKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(gSharpKey, @"Sounds/WEP sus m3 G#3 -11.wav");
        }

        private void aKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(aKey, @"Sounds/WEP sus m3 A3 -11.wav");
        }

        private void aSharpKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(aSharpKey, @"Sounds/WEP sus m3 A#3 -11.wav");

        }

        private void bKey_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(bKey, @"Sounds/WEP sus m3 B3 -11.wav");
        }

        private void c2Key_MouseClick(object sender, MouseEventArgs e)
        {
            playNote(c2Key, @"Sounds/WEP sus m3 C4 -11.wav");
        }

        #endregion


        #region keyInputNotes

        private void playButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.A)
            {
                playNote(cKey, @"Sounds/WEP sus m3 C3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.W)
            {
                playNote(cSharpKey, @"Sounds/WEP sus m3 C#3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.S)
            {
                playNote(dKey, @"Sounds/WEP sus m3 D3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.E)
            {
                playNote(dSharpKey, @"Sounds/WEP sus m3 D#3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.D)
            {
                playNote(eKey, @"Sounds/WEP sus m3 E3 -11.wav");
            }
            else if (e.KeyValue == (int)Keys.F)
            {
                playNote(fKey, @"Sounds/WEP sus m3 F3 -11.wav");

            }

            else if (e.KeyValue == (int)Keys.T)
            {
                playNote(fSharpKey, @"Sounds/WEP sus m3 F#3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.G)
            {
                playNote(gKey, @"Sounds/WEP sus m3 G3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.Y)
            {
                playNote(gSharpKey, @"Sounds/WEP sus m3 G#3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.H)
            {
                playNote(aKey, @"Sounds/WEP sus m3 A3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.U)
            {
                playNote(aSharpKey, @"Sounds/WEP sus m3 A#3 -11.wav");
            }

            else if (e.KeyValue == (int)Keys.J)
            {
                playNote(bKey, @"Sounds/WEP sus m3 B3 -11.wav");
            }
            else if (e.KeyValue == (int)Keys.K)
            {
                playNote(c2Key, @"Sounds/WEP sus m3 C4 -11.wav");
            }

        }


        #endregion

    }
}
