namespace schoolinformationportal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = lbHeader.Parent.PointToScreen(lbHeader.Location);
            pos = pbBackground.PointToClient(pos);
            lbHeader.Parent = pbBackground;
            lbHeader.Location = pos;
            lbHeader.BackColor = Color.Transparent;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}