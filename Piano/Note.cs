using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    class Note
    {

        private int noteFrequency;
        private int noteLength;

        public int NoteLength
        {
            get { return noteLength; }
            set { noteLength = value; }
        }
        

        public int NoteFrequency
        {
            get { return noteFrequency; }
            set { noteFrequency = value; }
        }
    }
}
