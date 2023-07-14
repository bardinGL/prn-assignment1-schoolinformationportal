using PE_PRN;

namespace schoolinformationportal
{
    public partial class Main : Form
    {
        String getparam;
        String getparamforRoleID;
        public Main(String roleID, String fullname, String ClassID)
        {
            InitializeComponent();
            getparam = ClassID;
            getparamforRoleID = roleID;

            lbHeader.Text = "Welcome " + fullname + " to Student Information Portal";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form studentinformation = new StudentInformation(getparam, getparamforRoleID);
            this.Hide();

            studentinformation.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form studentinformation = new StudentInformation(getparam, getparamforRoleID);
            this.Hide();

            studentinformation.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font("", 15, FontStyle.Bold);
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
            button1.BringToFront();
            button1.Size = new Size(220, 120);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font("", 12);
            button1.BackColor = Color.White;
            button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
            button1.Size = new Size(200, 80);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Font = new Font("", 15, FontStyle.Bold);
            button2.BackColor = Color.YellowGreen;
            button2.Location = new Point(button2.Location.X, button2.Location.Y + 10);
            button2.BringToFront();
            button2.Size = new Size(220, 120);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font("", 12);
            button2.BackColor = Color.White;
            button2.Location = new Point(button2.Location.X, button2.Location.Y - 10);
            button2.Size = new Size(200, 80);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Font = new Font("", 15, FontStyle.Bold);
            button3.BackColor = Color.YellowGreen;
            button3.Location = new Point(button3.Location.X, button3.Location.Y + 10);
            button3.BringToFront();
            button3.Size = new Size(220, 120);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new Font("", 12);
            button3.BackColor = Color.White;
            button3.Location = new Point(button3.Location.X, button3.Location.Y - 10);
            button3.Size = new Size(200, 80);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Font = new Font("", 15, FontStyle.Bold);
            button4.BackColor = Color.YellowGreen;
            button4.Location = new Point(button4.Location.X, button4.Location.Y + 10);
            button4.BringToFront();
            button4.Size = new Size(220, 120);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Font = new Font("", 12);
            button4.BackColor = Color.White;
            button4.Location = new Point(button4.Location.X, button4.Location.Y - 10);
            button4.Size = new Size(200, 80);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frClass = new ShowClass(getparam);
            frClass.ShowDialog();
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Fetures is not finished, please come back later", "Notification",
                MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("You sure you want to log out", "Log Out",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Login();
                login.ShowDialog();
            }
        }
    }
}