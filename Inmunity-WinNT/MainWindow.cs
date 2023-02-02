
using System.Threading;

namespace Inmunity_WinNT {
public partial class MainWindow : Form {
  public MainWindow() { InitializeComponent(); }

  private void btnInmunify_Click(object sender, EventArgs e) {
    btnInmunify.Enabled = false;
    String raw = txtField1.Text;
    txtField1.Enabled = false;
    txtField1.Text = "⌛⌛⌛";
    txtField1.Text = Utils.Inmunify(raw);
    btnInmunify.Enabled = true;
    txtField1.Enabled = true;
  }
}
}