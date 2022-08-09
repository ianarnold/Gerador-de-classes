using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomeClasse.Text.Equals(""))
            {
                MessageBox.Show("Digite o nome da classe");
            }
            else
            {
                string[] lines = { "using System;", "using System.Collections.Generic;", "using System.Linq;", "using System.Text;",
                                    "using System.Threading.Tasks;", "namespace GeradorDeClasses", "{", "\tinternal class "+ char.ToUpper(txtNomeClasse.Text[0]) + txtNomeClasse.Text.Substring(1),
                                    "\t{"};
                File.WriteAllLinesAsync("../../../" + char.ToUpper(txtNomeClasse.Text[0]) + txtNomeClasse.Text.Substring(1) + ".cs", lines);

                for (int i = 0; i < lstClasses.Items.Count; i++)
                {
                    string[] lines2 = { "\t\tprivate string " + lstClasses.Items[i].ToString() + ";" };
                    File.AppendAllLinesAsync("../../../" + char.ToUpper(txtNomeClasse.Text[0]) + txtNomeClasse.Text.Substring(1) + ".cs", lines2);
                }

                for (int i = 0; i < lstClasses.Items.Count; i++)
                {
                    string[] lines3 = { "\n\t\tpublic void set" + char.ToUpper(lstClasses.Items[i].ToString()[0]) + lstClasses.Items[i].ToString().Substring(1) + "(String _"+lstClasses.Items[i].ToString()
                    + ") { "+ lstClasses.Items[i].ToString() + " = _"+ lstClasses.Items[i].ToString() + "; }"};
                    File.AppendAllLinesAsync("../../../" + txtNomeClasse.Text + ".cs", lines3);
                }

                for (int i = 0; i < lstClasses.Items.Count; i++)
                {
                    string[] lines4 = { "\n\t\tpublic String get" + char.ToUpper(lstClasses.Items[i].ToString()[0]) + lstClasses.Items[i].ToString().Substring(1) + "() { return " + lstClasses.Items[i].ToString() + "; }" };
                    File.AppendAllLinesAsync("../../../" + txtNomeClasse.Text + ".cs", lines4);
                }

                string[] lines5 = { "\t}", "}" };
                File.AppendAllLinesAsync("../../../" + txtNomeClasse.Text + ".cs", lines5);

                string filetext = File.ReadAllText("../../../" + char.ToUpper(txtNomeClasse.Text[0]) + txtNomeClasse.Text.Substring(1) + ".cs");
                richTextBox1.Text = filetext;

                MessageBox.Show("Classe criada");


            }
        }


        private void btnAdicionaPropriedade_Click(object sender, EventArgs e)
        {
            if (lstClasses.Items.Contains(txtAdicionaPropriedade.Text))
            {
                MessageBox.Show("Propriedade já existente");
            }
            else
            {
                lstClasses.Items.Add(txtAdicionaPropriedade.Text);
            }
        }
    }
}
