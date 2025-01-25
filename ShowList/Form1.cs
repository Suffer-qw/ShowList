namespace ShowList
{
    public partial class Form1 : Form
    {
        MyList my = new MyList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my.Append(textBox1.Text);
            my.ShowList(listBox1);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            my.upend(textBox1.Text);
            my.ShowList(listBox1);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            my.next(textBox1.Text);
            my.ShowList(listBox1);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            my.prev(textBox1.Text);
            my.ShowList(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            my.ToStart();
            my.ShowList(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            my.ToEnd();
            my.ShowList(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            my.ToNext();
            my.ShowList(listBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            my.ToPrev();
            my.ShowList(listBox1);
        }



        private void button7_Click(object sender, EventArgs e)
        {
            my.delete();
            my.ShowList(listBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = my.Q();
            listBox2.Items.Insert(0, b);
        }

   
    }
}
