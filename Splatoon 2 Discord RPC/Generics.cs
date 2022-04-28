using System.Windows.Forms;

namespace Splatoon_2_Discord_RPC
{
    public static class Generics
    {
        public static class MessageBoxes
        {
            public static void ShowInformationMessage(string content)
            {
                MessageBox.Show(content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public static void ShowErrorMessage(string content)
            {
                MessageBox.Show(content, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
