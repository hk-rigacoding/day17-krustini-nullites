using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day17_krustini_nullites
{
    public partial class Form1 : Form
    {
        desu_laukums speele;

        public Form1()
        {
            InitializeComponent();
        }

        private void sāktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancēt desu_laukumu
            speele = new desu_laukums();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    speele.set_desa(i, j, 120, 120, i*250 + 100, j*200 + 60);
                    this.Controls.Add(speele.getDesa(i,j));
                    speele.getDesa(i, j).BringToFront();
                }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //laukums.Location = new Point(0,30);
            //laukums.Size = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height-30);
            //laukums.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bilde.Location = new Point(0, 30);
            bilde.Size = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height-30);
            bilde.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (speele == null)
                return;

            if (speele.X_gaajiens)
                gaajiens.Text = "Gaajiens : X";
            else
                gaajiens.Text = "Gaajiens : O";


            if (speele.uzvara == 8)
            {
                gaajiens.Text = "NEIZŠĶIRTS !";
            }

                else

           if (speele.uzvara > -1 && speele.uzvara < 8)
            {
                if (speele.g_skaits == 5 || speele.g_skaits == 7 || speele.g_skaits == 9)
                gaajiens.Text = "UZVARA X !";

                if (speele.g_skaits == 6 || speele.g_skaits == 8 )
                    gaajiens.Text = "UZVARA O !";

                /*
                //3x horizontālas rindas
                uzvaras_varianti[0] = statuss[0, 0] + statuss[1, 0] + statuss[2, 0];
                uzvaras_varianti[1] = statuss[0, 1] + statuss[1, 1] + statuss[2, 1];
                uzvaras_varianti[2] = statuss[0, 2] + statuss[1, 2] + statuss[2, 2];

                //3x vertikāles
                uzvaras_varianti[3] = statuss[0, 0] + statuss[0, 1] + statuss[0, 2];
                uzvaras_varianti[4] = statuss[1, 0] + statuss[1, 1] + statuss[1, 2];
                uzvaras_varianti[5] = statuss[2, 0] + statuss[2, 1] + statuss[2, 2];

                //2x diagonāles
                uzvaras_varianti[6] = statuss[0, 0] + statuss[1, 1] + statuss[2, 2];
                uzvaras_varianti[7] = statuss[2, 0] + statuss[1, 1] + statuss[0, 2];
                */
                switch (speele.uzvara)
                {
                    case 0:
                        speele.getDesa(0, 0).BackColor = Color.Green;
                        speele.getDesa(1, 0).BackColor = Color.Green;
                        speele.getDesa(2, 0).BackColor = Color.Green;
                        break;

                    case 1:
                        speele.getDesa(0, 1).BackColor = Color.Green;
                        speele.getDesa(1, 1).BackColor = Color.Green;
                        speele.getDesa(2, 1).BackColor = Color.Green;
             
                       break;

                    case 2:
                        speele.getDesa(0, 2).BackColor = Color.Green;
                        speele.getDesa(1, 2).BackColor = Color.Green;
                        speele.getDesa(2, 2).BackColor = Color.Green;
                        break;
                    case 3:
                        speele.getDesa(0, 0).BackColor = Color.Green;
                        speele.getDesa(0, 1).BackColor = Color.Green;
                        speele.getDesa(0, 2).BackColor = Color.Green;
                        break;
                    case 4:
                        speele.getDesa(1, 0).BackColor = Color.Green;
                        speele.getDesa(1, 1).BackColor = Color.Green;
                        speele.getDesa(1, 2).BackColor = Color.Green;
                        break;
                    case 5:
                        speele.getDesa(2, 0).BackColor = Color.Green;
                        speele.getDesa(2, 1).BackColor = Color.Green;
                        speele.getDesa(2, 2).BackColor = Color.Green;
                        break;
                    case 6:
                        speele.getDesa(0, 0).BackColor = Color.Green;
                        speele.getDesa(1, 1).BackColor = Color.Green;
                        speele.getDesa(2, 2).BackColor = Color.Green;
                        break;

                    case 7:
                        speele.getDesa(2, 0).BackColor = Color.Green;
                        speele.getDesa(1, 1).BackColor = Color.Green;
                        speele.getDesa(0, 2).BackColor = Color.Green;
                        break;

                }


            }




        }


    }

    // ko mums vajag krustiņiem - nullītēm ?

    //spēles noteikumi ?
    //trīs uzvar, rindā, kolonnā vai diagonāle
    //liek viens pēc otra
    //nepāra gājieni ir X un pāra gājieni ir O ?
    //(sākam ar X)

    // 9 pictureboksi
    // bildes - X un O

    class desu_laukums : PictureBox
    {
        //vai iet X ?
       public bool X_gaajiens;
        PictureBox[,] desas;
        string[,] statuss;
        public int uzvara;
        public int g_skaits;

        // 9 pictureboksi
        // bildes - X un O
        public desu_laukums()
        {
            desas = new PictureBox[3, 3];
            statuss = new string[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    statuss[i, j] = "";

            X_gaajiens = true;
            uzvara = -1;
            g_skaits = 0;
        }

        int Calc()
        {

            //8 varianti
            string[] uzvaras_varianti = new string[8];

            //uzvaras_varianti[0] = "XXX";
            //uzvaras_varianti[1] = "OOO";

            //3x horizontālas rindas
            uzvaras_varianti[0] = statuss[0, 0] + statuss[1, 0] + statuss[2, 0];
            uzvaras_varianti[1] = statuss[0, 1] + statuss[1, 1] + statuss[2, 1];
            uzvaras_varianti[2] = statuss[0, 2] + statuss[1, 2] + statuss[2, 2];

            //3x vertikāles
            uzvaras_varianti[3] = statuss[0, 0] + statuss[0, 1] + statuss[0, 2];
            uzvaras_varianti[4] = statuss[1, 0] + statuss[1, 1] + statuss[1, 2];
            uzvaras_varianti[5] = statuss[2, 0] + statuss[2, 1] + statuss[2, 2];

            //2x diagonāles
            uzvaras_varianti[6] = statuss[0, 0] + statuss[1, 1] + statuss[2, 2];
            uzvaras_varianti[7] = statuss[2, 0] + statuss[1, 1] + statuss[0, 2];


            for (int i=0; i< 8; i++)
                if (uzvaras_varianti[i] == "XXX" || uzvaras_varianti[i] == "OOO")
                {
                    return i;
                }

            return -1;
        }

        public void set_desa(int i, int j, int sizeX, int sizeY, int locX, int locY)
        {
            desas[i, j] = new PictureBox();
            desas[i, j].Size = new Size(sizeX, sizeY);
            desas[i, j].Location = new Point(locX, locY);

            //desas[i, j].Image = Properties.Resources.o;
            //desas[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

            //mouse click, jo tas ļauj viegli noteikt labo/kreiso peles taustu !
            desas[i, j].MouseClick += Desu_laukums_MouseClick;

            

        }

        public PictureBox getDesa(int i, int j)
        {
            return desas[i, j];
        }


        private void Desu_laukums_MouseClick(object sender, MouseEventArgs e)
        {
            

            //izpilda gājienu
            for (int i=0; i< 3; i++)
                for (int j = 0; j < 3; j++)
                if (sender.Equals(desas[i, j]))
                {

                        if (statuss[i, j] != "")
                            return;

                        if (uzvara > -1)
                            return;
                        
                        g_skaits++;

                        if (X_gaajiens)
                        {
                            desas[i, j].Image = Properties.Resources.x;
                            statuss[i, j] = "X";
                            desas[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                            X_gaajiens = false;
                        } else
                        {
                            desas[i, j].Image = Properties.Resources.o;
                            statuss[i, j] = "O";
                            desas[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                            X_gaajiens = true;
                        }

                        break;
                 }


            //kalkulē rezultātu
            uzvara = Calc();

            if (g_skaits == 9 && uzvara == -1)
                uzvara = 8;//neizšķirts


        }
    }
    
}
