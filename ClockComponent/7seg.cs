using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClockComponent
{
    public partial class Clock7Seg : UserControl
    {
        private bool[][] cyfry = new bool[][]
        {
            new bool[] { true, true, true, true, true, true, false },
            new bool[] { false, true, true, false, false, false, false},
            new bool[] { true, true, false, true, true, false, true},
            new bool[] { true, true, true, true, false, false, true},
            new bool[] { false, true, true, false, false, true, true},
            new bool[] { true, false, true, true, false, true, true},
            new bool[] { true, false, true, true, true, true, true},
            new bool[] { true, true, true, false, false, false, false},
            new bool[] { true, true, true, true, true, true, true},
            new bool[] { true, true, true, true, false, true, true}
        };

        public int czasomierz { get; set; }

        public Clock7Seg()
        {
            InitializeComponent();
            czasomierz = 0;
            zeruj1();
            zeruj2();
            zeruj3();
            zeruj4();
            zeruj5();
            zeruj6();
        }
        private void zeruj1()
        {
            seg1A.Visible = true;
            seg1B.Visible = true;
            seg1C.Visible = true;
            seg1D.Visible = true;
            seg1E.Visible = true;
            seg1F.Visible = true;
            seg1G.Visible = false;
        }
        private void zeruj2()
        {
            seg2A.Visible = true;
            seg2B.Visible = true;
            seg2C.Visible = true;
            seg2D.Visible = true;
            seg2E.Visible = true;
            seg2F.Visible = true;
            seg2G.Visible = false;
        }
        private void zeruj3()
        {
            seg3A.Visible = true;
            seg3B.Visible = true;
            seg3C.Visible = true;
            seg3D.Visible = true;
            seg3E.Visible = true;
            seg3F.Visible = true;
            seg3G.Visible = false;
        }
        private void zeruj4()
        {
            seg4A.Visible = true;
            seg4B.Visible = true;
            seg4C.Visible = true;
            seg4D.Visible = true;
            seg4E.Visible = true;
            seg4F.Visible = true;
            seg4G.Visible = false;
        }
        private void zeruj5()
        {
            seg5A.Visible = true;
            seg5B.Visible = true;
            seg5C.Visible = true;
            seg5D.Visible = true;
            seg5E.Visible = true;
            seg5F.Visible = true;
            seg5G.Visible = false;
        }
        private void zeruj6()
        {
            seg6A.Visible = true;
            seg6B.Visible = true;
            seg6C.Visible = true;
            seg6D.Visible = true;
            seg6E.Visible = true;
            seg6F.Visible = true;
            seg6G.Visible = false;
        }
        
        public void ustaw(int czas)
        {
            var godziny = czas / 3600;
            var reszta = czas - godziny * 3600;
            var minuty = reszta / 60;
            var sekundy = reszta - minuty * 60;
            int liczba1;
            int liczba2;
            if (godziny > 0)
            {
                if(godziny > 9)
                {
                    liczba2 = godziny % 10;
                    liczba1 = (godziny - liczba2)/10;

                    seg1A.Visible = cyfry[liczba1][0];
                    seg1B.Visible = cyfry[liczba1][1];
                    seg1C.Visible = cyfry[liczba1][2];
                    seg1D.Visible = cyfry[liczba1][3];
                    seg1E.Visible = cyfry[liczba1][4];
                    seg1F.Visible = cyfry[liczba1][5];
                    seg1G.Visible = cyfry[liczba1][6];

                    seg2A.Visible = cyfry[liczba2][0];
                    seg2B.Visible = cyfry[liczba2][1];
                    seg2C.Visible = cyfry[liczba2][2];
                    seg2D.Visible = cyfry[liczba2][3];
                    seg2E.Visible = cyfry[liczba2][4];
                    seg2F.Visible = cyfry[liczba2][5];
                    seg2G.Visible = cyfry[liczba2][6];
                }
                else
                {
                    zeruj1();
                    seg2A.Visible = cyfry[godziny][0];
                    seg2B.Visible = cyfry[godziny][1];
                    seg2C.Visible = cyfry[godziny][2];
                    seg2D.Visible = cyfry[godziny][3];
                    seg2E.Visible = cyfry[godziny][4];
                    seg2F.Visible = cyfry[godziny][5];
                    seg2G.Visible = cyfry[godziny][6];
                }

            }
            if (minuty > 0)
            {
                if (minuty > 9)
                {
                    liczba2 = minuty % 10;
                    liczba1 = (minuty - liczba2)/10;

                    seg3A.Visible = cyfry[liczba1][0];
                    seg3B.Visible = cyfry[liczba1][1];
                    seg3C.Visible = cyfry[liczba1][2];
                    seg3D.Visible = cyfry[liczba1][3];
                    seg3E.Visible = cyfry[liczba1][4];
                    seg3F.Visible = cyfry[liczba1][5];
                    seg3G.Visible = cyfry[liczba1][6];

                    seg4A.Visible = cyfry[liczba2][0];
                    seg4B.Visible = cyfry[liczba2][1];
                    seg4C.Visible = cyfry[liczba2][2];
                    seg4D.Visible = cyfry[liczba2][3];
                    seg4E.Visible = cyfry[liczba2][4];
                    seg4F.Visible = cyfry[liczba2][5];
                    seg4G.Visible = cyfry[liczba2][6];
                }
                else
                {
                    zeruj3();
                    seg4A.Visible = cyfry[minuty][0];
                    seg4B.Visible = cyfry[minuty][1];
                    seg4C.Visible = cyfry[minuty][2];
                    seg4D.Visible = cyfry[minuty][3];
                    seg4E.Visible = cyfry[minuty][4];
                    seg4F.Visible = cyfry[minuty][5];
                    seg4G.Visible = cyfry[minuty][6];
                }
            }
            if (sekundy > 0)
            {
                if (sekundy > 9)
                {
                    liczba2 = sekundy % 10;
                    liczba1 = (sekundy - liczba2)/10;

                    seg5A.Visible = cyfry[liczba1][0];
                    seg5B.Visible = cyfry[liczba1][1];
                    seg5C.Visible = cyfry[liczba1][2];
                    seg5D.Visible = cyfry[liczba1][3];
                    seg5E.Visible = cyfry[liczba1][4];
                    seg5F.Visible = cyfry[liczba1][5];
                    seg5G.Visible = cyfry[liczba1][6];

                    seg6A.Visible = cyfry[liczba2][0];
                    seg6B.Visible = cyfry[liczba2][1];
                    seg6C.Visible = cyfry[liczba2][2];
                    seg6D.Visible = cyfry[liczba2][3];
                    seg6E.Visible = cyfry[liczba2][4];
                    seg6F.Visible = cyfry[liczba2][5];
                    seg6G.Visible = cyfry[liczba2][6];
                }
                else
                {
                    zeruj5();
                    seg6A.Visible = cyfry[sekundy][0];
                    seg6B.Visible = cyfry[sekundy][1];
                    seg6C.Visible = cyfry[sekundy][2];
                    seg6D.Visible = cyfry[sekundy][3];
                    seg6E.Visible = cyfry[sekundy][4];
                    seg6F.Visible = cyfry[sekundy][5];
                    seg6G.Visible = cyfry[sekundy][6];
                }
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
