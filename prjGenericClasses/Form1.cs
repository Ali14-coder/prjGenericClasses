using System.Windows.Forms.Design;

namespace prjGenericClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Stack_Item<string> si = new Stack_Item<string>(5);
            si.Push("Fornite");
            si.Push("ROBOLOX");
            si.Push("Minecraft");
            si.Push("Counter-Strike 2 & GO");
            si.Push("League of Legends");

            String strDisplay = si.Display();
            MessageBox.Show("The following games have been added: \n\n" +strDisplay);
        }
    }
}
//generic collection, non-generic collection and what is a collection
