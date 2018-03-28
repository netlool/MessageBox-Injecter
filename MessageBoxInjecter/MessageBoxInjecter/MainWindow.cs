using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxInjecter.Utils;
namespace MessageBoxInjecter
{
    public partial class MainWindow : Form
    {
        static string NAME()
        {
            return "MessageBoxInjecter";
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmethods.Enabled = false;
        }

        private void btnofd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".NET Assembly| *.exe| .NET DLL| *.dll";
            ofd.Title = "Choose Assembly";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbpath.Text = ofd.FileName;
                try
                {
                    Globals.md = ModuleDefMD.Load(tbpath.Text);
                }catch(Exception)
                {
                    MessageBox.Show(null, "Failed while loading Assembly", NAME(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                List<String> methods = MethodLoader.LoadMethods();
                foreach(var item in methods)
                {
                    cbmethods.Items.Add(item);
                }
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            if (tbpath.Text.Equals("") || tbout.Text.Equals(""))
                MessageBox.Show(null, "Choose an Assembly!", NAME(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
             
                bool lol = checkBox1.Checked;
                try
                {
                    if (lol)
                        Inject.Injectmethod(tbmsg.Text);
                    else
                    {
                        var item = cbmethods.Text;
                        string[] splitted = item.Split(':');
                        string method = splitted[1];
                        Inject.Injectmethod(tbmsg.Text, method);
                    }
                    MessageBox.Show(null, "Successfully injected!", NAME(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "Failed while injecting methods " + ex.Message + "\n" + ex.StackTrace, NAME(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Globals.md.Write(tbout.Text);
                MessageBox.Show(null, "Assembly saved to: " + tbout.Text, NAME(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnSfd_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                tbout.Text = sfd.FileName;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbmethods.Enabled = false;
            }else
            {
                cbmethods.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbmsg.Text);
        }
    }
}
