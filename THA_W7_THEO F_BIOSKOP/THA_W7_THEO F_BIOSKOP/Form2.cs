using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace THA_W7_THEO_F_BIOSKOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            sound = new SoundPlayer("music.wav");
        }
        List<string> desc = new List<string>() { "Scott Lang (Paul Rudd), Hope Van Dyne (Evangeline Lilly) Dr. Hank Pym (Michael Douglas)\ndan Janet Van Dyne (Michelle Pfeiffer) menjelajahi Alam Kuantum, tempat mereka bertemu\ndengan makhluk aneh dan memulai petualangan yang melampaui batas yang mereka pikir mungkin." };
        public static string nama = "";
        private SoundPlayer sound;
        List<List<Button>> savebtn = new List<List<Button>>();
        List<List<Button>> movietime = new List<List<Button>> ();
        int seathelp = 0;
        List<string> waktu = new List<string> { "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB", "10.00 WIB", "13.00 WIB", "15.30 WIB"};
        static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"D:\CODE\NYOBA\THA_W7_THEO F_BIOSKOP\DAFTARFILM.txt");
        string[] files = File.ReadAllLines(path);
        int x = 25;
        int y = 25;
        string judulfilm = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            panelseat.Visible = false;
            purchasing.Visible = false;
            label1.Text = "Halo " + nama + ",Welcome to XXI CINEMA!!";
            label1.Font = new Font("Montserrat", 14, FontStyle.Bold);
            for (int i=0;i<8;i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(140,200);
                baru.Location = new Point(x, y);
                baru.Image = daftarposterlist.Images[i];
                Button film = new Button();
                film.Location = new Point(x, 243);
                film.Text = daftarposterlist.Images.Keys[i].ToString();
                film.Click += Film_Click;
                film.Tag = i;
                film.Size = new Size(140, 54);
                x += 150;
                panel1.Controls.Add(baru);
                panel1.Controls.Add(film);

            }
            Random rand = new Random();
            for (int a = 0; a < 8; a++) // kok kursi ku masih sama yo pdhl ws tak for gini haram
            {
                for (int z = 0; z < 3; z++)
                {
                    // haruse ya, a mbe z sg jadi tag e, anggepane a itu index film ke berapa, z itu index jam ke brapa. jadi ak mikire, buat membedakan dee lagi ndek list mana itu pake tag a mbe z lek caramu gini,, sek mr gni ae iki salah rasae for loopmu
                    int posx = 47;
                    int posy = 113;
                    int numberseat = 1;
                    List<Button> buttonseat = new List<Button>();
                    for (int i = 0; i < 10; i++) // generate kursi
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Button seat = new Button();
                            seat.Tag = numberseat.ToString();
                            numberseat++;
                            seat.Location = new Point(posx, posy);
                            seat.BackColor = Color.Silver;
                            seat.Click += Seat_Click;
                            posx += 44;
                            seat.Size = new Size(30, 30);
                            buttonseat.Add(seat);
                            seathelp++;
                        }
                        posx = 47;
                        posy += 44;
                    }
                    int jumlah = 0;
                    
                    for (int i = 0; i < 100; i++)
                    {
                        int r = rand.Next(0, 100);
                        buttonseat[r].BackColor = Color.Green;
                        jumlah++;
                        if(jumlah >= 70)
                        {
                            break;
                        }
                    }
                    savebtn.Add(buttonseat);
                }
            }

            int xx = 200; int nex = 0;
            for(int j = 0;j<8;j++)
            {
                List<Button> buttonmov = new List<Button>();
                for (int i = 0; i < 3; i++)
                {
                    Button time1 = new Button();
                    time1.Text = waktu[i];
                    time1.Location = new Point(xx, 70);
                    time1.Size = new Size(120, 50);
                    time1.Click += Time1_Click;
                    time1.Tag = nex.ToString();
                    nex++;
                    buttonmov.Add(time1);
                    xx += 130;
                }
                xx = 200;
                movietime.Add(buttonmov);
            }
        }

        private void Film_Click(object sender, EventArgs e)
        {
            paneltime.Controls.Clear();
            Button apa = sender as Button;
            //MessageBox.Show(apa.Tag.ToString());
            PictureBox baru = new PictureBox(); //GAMBAR
            baru.Size = new Size(140,200);
            baru.Location = new Point(19,13);
            baru.Image = daftarposterlist.Images[int.Parse(apa.Tag.ToString())];
            Label baru1 = new Label(); // JUDUL FILM
            baru1.Location = new Point(200, 17);
            baru1.Size = new Size(200, 50);
            baru1.Text = daftarposterlist.Images.Keys[int.Parse(apa.Tag.ToString())].ToString();
            judulfilm = baru1.Text;
            baru1.Font = new Font("Arial", 12, FontStyle.Bold);
            paneltime.Controls.Add(baru);
            paneltime.Controls.Add(baru1);
            for (int i = 0; i < 3; i++)
            {
                paneltime.Controls.Add(movietime[int.Parse(apa.Tag.ToString())][i]);
            }
        }

        int resetcolor = 0;
        private void Time1_Click(object sender, EventArgs e)
        {
            Button tombol = sender as Button; // kursi
            sound.Play();
            //MessageBox.Show(tombol.Tag.ToString());
            resetcolor = Convert.ToInt32(tombol.Tag.ToString());
            panelseat.Visible = true;
            Label jdl = new Label();
            jdl.Text = judulfilm;
            jdl.Location = new Point(47, 60);
            jdl.Size = new Size(250, 50);
            jdl.Font = new Font("Arial", 12, FontStyle.Bold);
            Button time1 = new Button(); //tombol back
            time1.Text = "GO BACK <<";
            time1.Location = new Point(1100, 600);
            time1.Size = new Size(120, 50);
            time1.Click += Time1_Click1;
            panelseat.Controls.Add(time1);
            panelseat.Controls.Add(jdl);
            //label1.Text = "SEATHELP : " + seathelp.ToString();
            Label jdl1 = new Label();
            jdl1.Text = "L    A    Y    A    R";
            jdl1.Location = new Point(170, 609);
            jdl1.Size = new Size(250, 50);
            jdl1.Font = new Font("Arial", 18, FontStyle.Bold);
            panelseat.Controls.Add(jdl1);
            purchasing.Text = "";
            result = "";
            invoice.Clear();
            for (int i = 0;i<100;i++)
            {
                panelseat.Controls.Add(savebtn[int.Parse(tombol.Tag.ToString())][i]);
            }
            Button reset = new Button();
            reset.Text = "Reset";
            reset.Location = new Point(580, 110);
            reset.Size = new Size(60, 30);
            reset.Click += Reset_Click;
            panelseat.Controls.Add(reset);
            Button savepur = new Button();
            savepur.Text = "Save Purchase";
            savepur.Location = new Point(640, 110);
            savepur.Click += Savepur_Click;
            savepur.Size = new Size(100, 30);
            panelseat.Controls.Add(savepur);
        }

        private void Savepur_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<invoice.Count;i++)
            {
                savebtn[resetcolor][Convert.ToInt32(invoice[i])-1].BackColor = Color.Green;
            }
            invoice.Clear();
            purchasing.Text = "Succes Purchase Seat";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < savebtn[resetcolor].Count;i++)
            {
                savebtn[resetcolor][i].BackColor = Color.Silver;
            }
            for (int i = 0; i < 100; i++)
            {
                panelseat.Controls.Remove(savebtn[resetcolor][i]);
            }
            for (int i = 0; i < 100; i++)
            {
                panelseat.Controls.Add(savebtn[resetcolor][i]);
            }
            invoice.Clear();
            purchasing.Text = ""; 
        }

        Label purchasing = new Label();
        List<string> invoice = new List<string>();
        string result = "";
        private void Seat_Click(object sender, EventArgs e)
        {
            purchasing.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            Button s = sender as Button;
            if (s.BackColor == Color.Green)
            {
                MessageBox.Show("Oops, Kursi sudah dipilih!");
            }
            else
            {
                List<string> inv = new List<string>();
                purchasing.Visible = true;
                panelseat.Controls.Add(purchasing);
                purchasing.Location = new Point(578, 150);
                purchasing.Size = new Size(500, 200);
                if(s.BackColor == Color.Red)
                {
                    s.BackColor = Color.Silver;
                    for(int i = invoice.Count-1;i>=0;i--)
                    {
                        if (invoice[i].Contains(s.Tag.ToString()))
                        {
                            invoice.Remove(s.Tag.ToString());
                        }
                    }
                    result = "";
                    foreach (string tes in invoice)
                    {
                        result += tes + ",";
                    }
                    purchasing.Text = "RESERVED SEAT : \n" + result;
                }
                else
                {
                    invoice.Add(s.Tag.ToString());
                    //invoice.Sort();
                    result = "";
                    foreach(string tes in invoice)
                    {
                        result += tes + ",";
                    }
                    purchasing.Text = "RESERVED SEAT : \n" + result;
                    s.BackColor = Color.Red;
                }
            }
        }

        private void Time1_Click1(object sender, EventArgs e) // back
        {
            panelseat.Visible = false;
            panelseat.Controls.Clear();
            for(int i = 0;i<invoice.Count;i++)
            {
                savebtn[resetcolor][Convert.ToInt32(invoice[i]) - 1].BackColor = Color.Silver;
            }
            sound.Stop();
        }

        private void paneltime_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
