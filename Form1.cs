namespace _9._23_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            MoveButton.Location = new Point(new Random().Next(0, this.Width - 100), new Random().Next(0, this.Height - 100));
        }

        private void MoveForm_Click(object sender, EventArgs e)
        {
            this.Location = new Point(new Random().Next(0, 1700), new Random().Next(0, 800));
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if (ChangeColor.BackColor == Color.Red) ChangeColor.BackColor = Color.Yellow;
            else if (ChangeColor.BackColor == Color.Yellow) ChangeColor.BackColor = Color.Lime;
            else ChangeColor.BackColor = Color.Red;
        }
    }
}
