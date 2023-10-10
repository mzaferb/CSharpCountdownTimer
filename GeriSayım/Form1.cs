namespace GeriSayım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int second = 0;
        int minute = 0;
        int hour = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            second = Convert.ToInt32(secondNud.Value);
            minute = Convert.ToInt32(minuteNud.Value);
            hour = Convert.ToInt32(hourNud.Value);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (hour == 0 && minute == 0 && second == 0)
            {
                MessageBox.Show("Time is over!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            second--;
            if (second == -1)
            {
                second = 59;
                minute--;
            }
            if (minute == -1)
            {
                minute = 59;
                hour--;
            }
            secondLbl.Text = second.ToString("D2");
            minuteLbl.Text = minute.ToString("D2");
            hourLbl.Text = hour.ToString("D3");
            timer1.Start();
        }
    }
}