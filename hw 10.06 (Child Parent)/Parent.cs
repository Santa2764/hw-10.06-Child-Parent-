namespace hw_10._06__Child_Parent_
{
    public partial class Parent : Form
    {
        private Child child;

        public Parent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            CreateChild();
        }

        public void ChangeTextBox(string text)
        {
            parentTextBox.Text = text;
        }

        public void CloseChild()
        {
            child = null;
        }

        private void CreateChild()
        {
            child = new Child(this);
            child.Show();
        }

        private void ParentTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (child != null)
                child.ChangeTextBox(parentTextBox.Text);
        }
    }
}