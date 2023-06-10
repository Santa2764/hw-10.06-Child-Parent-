namespace hw_10._06__Child_Parent_
{
    public partial class Child : Form
    {
        private Parent parent;

        public Child()
        {
            InitializeComponent();
        }

        public Child(Parent parent) : this()
        {
            this.parent = parent;
        }

        public void ChangeTextBox(string text)
        {
            childTextBox.Text = text;
        }

        private void ChildTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            parent.ChangeTextBox(childTextBox.Text);
        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.CloseChild();
        }
    }
}
