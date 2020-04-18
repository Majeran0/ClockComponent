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
        private Panel[][] panels;
        public int czasomierz { get; set; }

        public Clock7Seg()
        {
            InitializeComponent();

            panels = new Panel[][]
            {
                new Panel[] {seg1A, seg1B, seg1C, seg1D, seg1E, seg1F, seg1G},
                new Panel[] {seg2A, seg2B, seg2C, seg2D, seg2E, seg2F, seg2G},
                new Panel[] {seg3A, seg3B, seg3C, seg3D, seg3E, seg3F, seg3G},
                new Panel[] {seg4A, seg4B, seg4C, seg4D, seg4E, seg4F, seg4G},
                new Panel[] {seg5A, seg5B, seg5C, seg5D, seg5E, seg5F, seg5G},
                new Panel[] {seg6A, seg6B, seg6C, seg6D, seg6E, seg6F, seg6G}
            };

            czasomierz = 0;
            for (int i = 1; i < 7; i++)
                zeruj(i);
        }
        private void zeruj(int numer)
        {
            for (int i = 0; i < 7; i++)
                panels[numer-1][i].Visible = cyfry[0][i];
        }
        private void wyswietl(int numer, int cyfra) 
        {
            for (int i = 0; i < 7; i++)
                panels[numer-1][i].Visible = cyfry[cyfra][i];
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

                    wyswietl(1, liczba1);
                    wyswietl(2, liczba2);
                }
                else
                {
                    zeruj(1);
                    wyswietl(2, godziny);
                }

            }
            if (minuty > 0)
            {
                if (minuty > 9)
                {
                    liczba2 = minuty % 10;
                    liczba1 = (minuty - liczba2)/10;

                    wyswietl(3, liczba1);
                    wyswietl(4, liczba2);
                }
                else
                {
                    zeruj(3);
                    wyswietl(4, minuty);
                }
            }
            if (sekundy > 0)
            {
                if (sekundy > 9)
                {
                    liczba2 = sekundy % 10;
                    liczba1 = (sekundy - liczba2)/10;

                    wyswietl(5, liczba1);
                    wyswietl(6, liczba2);
                }
                else
                {
                    zeruj(5);
                    wyswietl(6, sekundy);
                }
            }
        }
    }
}