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
            groupBox1.Text = "Kare'nin i�lemleri";
            Dikdortgenbutton.Visible = false;
            Karebutton.Visible = true;
            label1.Text = "Kare";
            label2.Text = "Bir kenar� giriniz";
            label4.Visible = false;
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Text = "Dikd�rtgenin i�lemleri";
            label1.Text = "Dikd�rtgen";

            label4.Visible = true;
            textBox1.Visible = true;
            label2.Text = "K�sa kenar� giriniz";
            label4.Text = "Uzun kenar� giriniz";
            Karebutton.Visible = false;
            Dikdortgenbutton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Daire";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Karenin De�i�kenleri 
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


            int k�sakenar, uzunkenar, alan, cevre;

            k�sakenar = Convert.ToInt32(textbox0.Text);
            uzunkenar = Convert.ToInt32(textBox1.Text);


            alan = k�sakenar * uzunkenar;
            cevre = (k�sakenar + uzunkenar) * 2;


            Alandeger.Text = alan.ToString();
            Cevredeger.Text = cevre.ToString();
        
        }
    }
}
