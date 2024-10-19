namespace Math_Calculations_App
{
    public partial class MathCalculationsApp : Form
    {
        public MathCalculationsApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Text = "Kare'nin iþlemleri";
            Dikdortgenbutton.Visible = false;
            Karebutton.Visible = true;
            label1.Text = "Kare";
            label2.Text = "Bir kenarý giriniz";
            label4.Visible = false;
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Text = "Dikdörtgenin iþlemleri";
            label1.Text = "Dikdörtgen";

            label4.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Kýsa kenarý giriniz";
            label4.Text = "Uzun kenarý giriniz";
            Karebutton.Visible = false;
            Dikdortgenbutton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Daire";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Karenin Deðiþkenleri 
            int birkenar, alan, cevre;
      
            birkenar = Convert.ToInt32(textbox0.Text);


            alan = birkenar * birkenar;
            cevre = birkenar * 4;

            Alandeger.Text = alan.ToString();
            Cevredeger.Text = cevre.ToString();


            /*-------------------------------------------------------------*/


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MathCalculationsApp_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void Dikdortgenbutton_Click(object sender, EventArgs e)
        {


            int kýsakenar, uzunkenar, alan, cevre;

            kýsakenar = Convert.ToInt32(textbox0.Text);
            uzunkenar = Convert.ToInt32(textBox1.Text);


            alan = kýsakenar * uzunkenar;
            cevre = (kýsakenar + uzunkenar) * 2;


            Alandeger.Text = alan.ToString();
            Cevredeger.Text = cevre.ToString();
        
        }
    }
}
