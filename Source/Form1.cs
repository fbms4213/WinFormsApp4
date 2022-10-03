namespace Source;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        lbl_timer.Text = DateTime.Now.ToLongTimeString();

        if (progressBar1.Value == progressBar1.Maximum)
            progressBar1.Value = progressBar1.Minimum;


        progressBar1.Value += 10;


        // progressBar1.Step = 1;
        // progressBar1.PerformStep();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        statusLabel.Text = e.Location.ToString();

    }

    private void trackBar_Scroll(object sender, EventArgs e)
    {
        lbl_red.Text = trackBar1.Value.ToString();
        lbl_green.Text = trackBar2.Value.ToString();
        lbl_blue.Text = trackBar3.Value.ToString();

        panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);


    }
}
