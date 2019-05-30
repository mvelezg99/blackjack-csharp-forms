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
    public partial class Form_tablero_1pl : Form
    {
        String nombreJugador;
        int saldo;
        int puntajeJugador = 0;

        int valorCartaPl1 = 0;
        int valorCartaPl2 = 0;

        int contadorPl1 = 0;
        int contadorPl2 = 0;


        List<int> cartasPl1 = new List<int>();
        List<int> cartasPl2 = new List<int>();

        Random rand = new Random();

        public Form_tablero_1pl()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            nombreJugador = txboxNombre.Text.ToString();
            saldo = int.Parse(nupdDinero.Text.ToString());
            gboxRegistro.Hide();
            actuInfo();

            iniciarJuego();
        }
        private void actuInfo()
        {
            txboxNom.Text = "Nombre: " + nombreJugador;
            txboxPuntaje.Text = "Juegos Ganados: " + puntajeJugador;
            txboxSaldo.Text = "Saldo: $" + saldo;

        }

        private void iniciarJuego()
        {
            actuInfo();
            gboxOpciones.Hide();
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

            jugarCartas(cartasPl1, ref valorCartaPl1, contadorPl1, 462, 317, 40);
            jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 558, -25, -40);

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
            gboxOpciones.Hide();


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

                if (contadorPl >= 40)
                {
                    if (valorCartaPl < 21)
                    {
                        gboxOpciones.Show();
                        gboxOpciones.Location = new Point(172, 266);
                        gboxOpciones.Size = new Size(177, 124);
                    }

                }

            }

            if (valorCartaPl1 > 21)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                MessageBox.Show("Señor: " + nombreJugador + " Has perdido; Sacaste más de 21, sacaste " + valorCartaPl,"Blackjack - SIO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                volverAJugar();
                this.Close();
            }
            else if (valorCartaPl2 > 21)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                gboxOpciones.Hide();
                MessageBox.Show("¡ Señor: " + nombreJugador + " Has ganado, La casa ha sacado más de 21, sacó " + valorCartaPl2 + " Felicidades !","BlackJack-SIO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                puntajeJugador++;
                saldo = (saldo * 2);
                if (puntajeJugador > 2)
                {
                    puntajeJugador = (puntajeJugador - 1) * 3;
                    saldo = saldo * 3;

                }
                actuInfo();
                volverAJugar();

            }
            else if (valorCartaPl1 == 21)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                gboxOpciones.Hide();
                MessageBox.Show("¡ Señor: " + nombreJugador + " Has sacado 21, has ganado Felicidades !","BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntajeJugador++;
                saldo = (saldo * 2);
                if (puntajeJugador > 2)
                {
                    puntajeJugador = puntajeJugador * 3;
                    saldo = (saldo / 2) * 3;

                }
                actuInfo();
                volverAJugar();

            }
            else if (valorCartaPl2 == 21)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                MessageBox.Show("Señor: " + nombreJugador + " Has perdido La Casa ha sacado 21, te ha ganado", "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                volverAJugar();
                this.Close();

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

        private void Form_tablero_1pl_Load(object sender, EventArgs e)
        {
            gboxRegistro.Location = new Point(25, 49);
            gboxRegistro.Size = new Size(329, 211);
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            
            if (valorCartaPl2 == valorCartaPl1)
            {
                cartasPl2.Add(rand.Next(1, 11));
                jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 558, -25, -40);

                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                prbarPunt1.Value = valorCartaPl1;
                prbarPunt2.Value = valorCartaPl2;
            }
            else if(valorCartaPl1 > valorCartaPl2)
            {
                cartasPl2.Add(rand.Next(1, 11));
                jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 558, -25, -40);

                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                prbarPunt1.Value = valorCartaPl1;
                prbarPunt2.Value = valorCartaPl2;

                if (valorCartaPl1 > valorCartaPl2)
                {
                    gboxOpciones.Hide();
                    MessageBox.Show("¡ Señor: " + nombreJugador + " Has ganado Felicidades ! Sacaste " + valorCartaPl1 + " y la casa sacó " + valorCartaPl2, "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    puntajeJugador++;
                    saldo = (saldo * 2);
                    if (puntajeJugador > 2)
                    {
                        puntajeJugador = puntajeJugador * 3;
                        saldo = (saldo / 2) * 3;

                    }
                    volverAJugar();
                    actuInfo();
                }

                

            }
            else if (valorCartaPl2 > valorCartaPl1)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                MessageBox.Show("Señor: " + nombreJugador + " Has perdido La Casa te ha ganado. Sacaste " + valorCartaPl1 + " y la casa sacó " + valorCartaPl2, "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                volverAJugar();
                this.Close();

            }




        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            

            cartasPl1.Add(rand.Next(1, 11));
            jugarCartas(cartasPl1, ref valorCartaPl1, contadorPl1, 462, 317, 40);
            if (valorCartaPl2 <= valorCartaPl1 && valorCartaPl2 > 0)
            {
                cartasPl2.Add(rand.Next(1, 11));
                jugarCartas(cartasPl2, ref valorCartaPl2, contadorPl2, 558, -25, -40);

                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                prbarPunt1.Value = valorCartaPl1;
                prbarPunt2.Value = valorCartaPl2;
            }
            else if (valorCartaPl1 > valorCartaPl2)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                gboxOpciones.Hide();
                MessageBox.Show("¡ Señor: " + nombreJugador + " Has ganado Felicidades ! Sacaste "+ valorCartaPl1 + " y la casa sacó " + valorCartaPl2, "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puntajeJugador++;
                saldo = (saldo * 2);
                if (puntajeJugador > 2)
                {
                    puntajeJugador = puntajeJugador * 3;
                    saldo = (saldo / 2) * 3;

                }
                volverAJugar();
                actuInfo();

            }
            else if (valorCartaPl2 > valorCartaPl1)
            {
                lblPunt1.Text = valorCartaPl1.ToString();
                lblPunt2.Text = valorCartaPl2.ToString();

                MessageBox.Show("Señor: " + nombreJugador + " Has perdido La Casa te ha ganado. La casa sacó "+valorCartaPl2+" y tu sacaste "+valorCartaPl1, "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                volverAJugar();
                this.Close();


            }



        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡ Gracias por jugar, vuelva pronto !", "BlackJack-SIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }
    }
}
