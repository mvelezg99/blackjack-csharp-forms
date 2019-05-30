using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack___SIO
{
    public partial class Form_tablero_2pl : Form
    {
        String nombreJug1;
        String nombreJug2;
        int saldoJug1;
        int saldoJug2;
        int puntajeJug1 = 0;
        int puntajeJug2 = 0;

        int valorCartaPl1 = 0;
        int valorCartaPl2 = 0;

        int contadorPl1 = 0;
        int contadorPl2 = 0;


        List<int> cartasPl1 = new List<int>();
        List<int> cartasPl2 = new List<int>();

        Random rand = new Random();

        public Form_tablero_2pl()
        {
            InitializeComponent();
        }

        private void Form_tablero_2pl_Load(object sender, EventArgs e)
        {
            gboxRegistro.Location = new Point(25, 49);
            gboxRegistro.Size = new Size(762, 218);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            nombreJug1 = txboxNomb1.Text.ToString();
            nombreJug2 = txboxNomb2.Text.ToString();
            saldoJug1 = int.Parse(nupdDin1.Text.ToString());
            saldoJug2 = int.Parse(nupdDin2.Text.ToString());
            gboxRegistro.Hide();
            actuInfo();

            iniciarJuego();
        }

        private void actuInfo()
        {
            gboxOpc1.Text = nombreJug1;
            gboxOpc2.Text = nombreJug2;

            txboxPunt1.Text = "Juegos Ganados: " + puntajeJug1;
            txboxPunt2.Text = "Juegos Ganados: " + puntajeJug2;
            txboxSaldo1.Text = "Saldo: $" + saldoJug1;
            txboxSaldo2.Text = "Saldo: $" + saldoJug2;
            lblJug1.Text = "Puntuación " + nombreJug1 + ":";
            lblJug2.Text = "Puntuación " + nombreJug2 + ":";


        }

        private void iniciarJuego()
        {
            actuInfo();
            gboxOpc1.Hide();
            gboxOpc2.Hide();
            gboxSeguir.Hide();

            cartasPl1.Add(rand.Next(1, 11));

            cartasPl2.Add(rand.Next(1, 11));

            gboxApuesta.Show();

            jugar();

        }

        private void jugar()
        {
            cartasPl1.Add(rand.Next(1, 11));
            cartasPl2.Add(rand.Next(1, 11));

            jugarCartas(cartasPl1, ref valorCartaPl1, contadorPl1, 274, 337, 40);
            jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 685, 337, 40);

            lblPunt1.Text = valorCartaPl1.ToString();
            lblPunt2.Text = valorCartaPl2.ToString();

            prbarPunt1.Value = valorCartaPl1;
            prbarPunt2.Value = valorCartaPl2;
        }

        private void volverAJugar()
        {
            valorCartaPl1 = 0;
            valorCartaPl2 = 0;
            cartasPl1.Clear();
            cartasPl2.Clear();
            gboxApuesta.Hide();
            gboxOpc1.Hide();
            gboxOpc2.Hide();


            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                pb.Hide();
            }

            gboxSeguir.Location = new Point(407, 139);
            gboxSeguir.Size = new Size(177, 127);
            gboxSeguir.Show();
        }

        private void jugarCartas(List<int> cartasPl, ref int valorCartaPl, int contadorPl, int x, int y, int xy)
        {
            valorCartaPl = 0;

            foreach (var s in cartasPl)
            {
                valorCartaPl = valorCartaPl + s;
                contadorPl += xy;

                agregarCarta(s, contadorPl, x, y);
                //queCarta(s+1, contador+40);


                if (contadorPl >= 40)
                {
                    if (valorCartaPl < 21)
                    {
                        gboxOpc1.Show();
                        gboxOpc1.Location = new Point(30, 351);
                        gboxOpc2.Location = new Point(799, 351);
                        gboxOpc1.Size = new Size(177, 124);
                        gboxOpc2.Size = new Size(177, 124);
                    }

                }

            }

            if (valorCartaPl1 > 21)
            {
                gboxOpc1.Hide();
                gboxOpc2.Hide();
                MessageBox.Show("Señor: " + nombreJug1 + " Has perdido; Sacaste más de 21", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug2++;
                saldoJug2 = saldoJug2 + saldoJug1;
                saldoJug1 = 0;
                actuInfo();
                volverAJugar();
            }
            else if (valorCartaPl2 > 21)
            {
                gboxOpc1.Hide();
                gboxOpc2.Hide();
                MessageBox.Show("Señor: " + nombreJug2 + " Has perdido; Sacaste más de 21", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug1++;
                saldoJug1 = saldoJug1 + saldoJug2;
                saldoJug2 = 0;
                actuInfo();
                volverAJugar();

            }
            else if (valorCartaPl1 == 21)
            {
                gboxOpc1.Hide();
                gboxOpc2.Hide();
                MessageBox.Show("Señor: " + nombreJug1 + " Has ganado; Sacaste 21", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntajeJug1++;
                saldoJug1 = saldoJug1 + saldoJug2;
                saldoJug2 = 0;
                actuInfo();
                volverAJugar();

            }
            else if (valorCartaPl2 == 21)
            {
                gboxOpc1.Hide();
                gboxOpc2.Hide();
                MessageBox.Show("Señor: " + nombreJug2 + "  Has ganado; Sacaste 21", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntajeJug2++;
                saldoJug2 = saldoJug2 + saldoJug1;
                saldoJug1 = 0;
                actuInfo();
                volverAJugar();

            }

        }

        private void agregarCarta(int nCarta, int cont, int x, int y)
        {
            PictureBox carta = new PictureBox();
            carta.Size = new Size(79, 109);
            carta.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (nCarta)
            {

                case 1:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.AceDiamond;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();

                    break;

                case 2:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.TwoClub;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 3:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.ThreeDiamond;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;



                case 4:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.FourHeart;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 5:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.FiveDiamond;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;
                case 6:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.SixSpade;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 7:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.SevenClub;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 8:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.EightHeart;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 9:
                    this.Controls.Add(carta);
                    carta.Image = BlackJack___SIO.Properties.Resources.NightSpade;
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

                case 10:
                    this.Controls.Add(carta);
                    int colorCarta = rand.Next(1, 5);
                    switch (colorCarta)
                    {
                        case 1:
                            carta.Image = BlackJack___SIO.Properties.Resources.TenClub;
                            break;
                        case 2:
                            carta.Image = BlackJack___SIO.Properties.Resources.QueenDiamond;
                            break;
                        case 3:
                            carta.Image = BlackJack___SIO.Properties.Resources.JackHeart;
                            break;
                        case 4:
                            carta.Image = BlackJack___SIO.Properties.Resources.KingSpade;
                            break;
                    }
                    carta.Location = new Point(x + cont, y - cont);
                    carta.Show();
                    break;

            }
        }

        private void btnPasar1_Click_1(object sender, EventArgs e)
        {
            gboxOpc1.Hide();
            gboxOpc2.Show();
            
        }

        private void btnPasar2_Click_1(object sender, EventArgs e)
        {
            if (valorCartaPl1 > valorCartaPl2)
            {
                MessageBox.Show("Señor: " + nombreJug2 + " Has perdido; el jugador " + nombreJug1 + " te ha ganado", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug1++;
                saldoJug1 = saldoJug1 + saldoJug2;
                saldoJug2 = 0;
                actuInfo();
                volverAJugar();

            } else if (valorCartaPl2 > valorCartaPl1)
            {
                MessageBox.Show("Señor: " + nombreJug1 + " Has perdido; el jugador " + nombreJug2 + " te ha ganado", "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug2++;
                saldoJug2 = saldoJug2 + saldoJug1;
                saldoJug1 = 0;
                actuInfo();
                volverAJugar();

            }
            gboxOpc2.Hide();
            gboxOpc1.Show();
        }

        private void btnPedir1_Click_1(object sender, EventArgs e)
        {
            cartasPl1.Add(rand.Next(1, 11));
            jugarCartas(cartasPl1, ref valorCartaPl1, contadorPl1, 274, 337, 40);
            lblPunt1.Text = valorCartaPl1.ToString();
            lblPunt2.Text = valorCartaPl2.ToString();

            prbarPunt1.Value = valorCartaPl1;
            prbarPunt2.Value = valorCartaPl2;

            gboxOpc1.Hide();
            gboxOpc2.Show();
        

            


        }

        private void btnPedir2_Click_1(object sender, EventArgs e)
        {
            cartasPl2.Add(rand.Next(1, 11));
            jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 685, 337, 40);
            lblPunt1.Text = valorCartaPl1.ToString();
            lblPunt2.Text = valorCartaPl2.ToString();

            prbarPunt1.Value = valorCartaPl1;
            prbarPunt2.Value = valorCartaPl2;
        

            if (valorCartaPl2 > valorCartaPl1)
            {
                MessageBox.Show("Señor: " + nombreJug2 + " Le has ganado al jugador " + nombreJug1, "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug2++;
                saldoJug2 = saldoJug2 + saldoJug1;
                saldoJug1 = 0;
                actuInfo();
                volverAJugar();
            } else if (valorCartaPl1 > valorCartaPl2)
            {
                MessageBox.Show("Señor: " + nombreJug1 + " Le has ganado al jugador " + nombreJug2, "Blackjack - SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                puntajeJug1++;
                saldoJug1 = saldoJug1 + saldoJug2;
                saldoJug2 = 0;
                actuInfo();
                volverAJugar();
            }

            gboxOpc2.Hide();
            gboxOpc1.Show();
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡ Gracias por jugar, vuelva pronto !", "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();

        }

        private void btnSi_Click_1(object sender, EventArgs e)
        {
            iniciarJuego();
        }

    }


}

