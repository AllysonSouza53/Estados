using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estados
{
    public partial class Form1 : Form
    {
        int ne1 = 0;
        int ne2 = 0;
        int ne3 = 0;
        int ne4 = 0;
        int ne5 = 0;
        int ne = 27;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTE_Click(object sender, EventArgs e)
        {
            string Estado = TE.Text;
            

            if(Estado == "Rio Grande do Sul - RS" || Estado == "Santa Catarina - SC" || Estado == "Paraná - PR")
            {
                Sc.Items.Add(Estado);
                TE.Items.Remove(TE.Text);
                ne1++;
                NS.Text = ne1.ToString();
            }
            else if (Estado == "Minas Gerais - MG" || Estado == "Espírito Santo - ES" || Estado == "São Paulo - SP" || Estado == "Rio de Janeiro - RJ")
            {
                SEc.Items.Add(Estado);
                TE.Items.Remove(TE.Text);
                ne2++;
                NSE.Text = ne2.ToString();
            }
            else if (Estado == "Mato Grosso - MT" || Estado == "Mato Grosso do Sul - MS" || Estado == "Goiás - GO" || Estado == "Distrito Federal - DF")
            {
                CO.Items.Add(Estado);
                TE.Items.Remove(TE.Text);
                ne3++;
                NCO.Text = ne3.ToString();
            }
            else if (Estado == "Sergipe - SE" || Estado == "Rio Grande do Norte - RN"|| Estado == "Piauí - PI" || Estado == "Maranhão - MA" || Estado == "Bahia - BA" || Estado == "Paraíba - PB" || Estado == "Pernambuco - PE" || Estado == "Ceará - CE" || Estado == "Tocantins - TO" || Estado == "Alagoas - AL")
            {
                NE.Items.Add(Estado);
                TE.Items.Remove(TE.Text);
                ne4++;
                NNE.Text = ne4.ToString();
            }
            else if (Estado == "Acre - AC" || Estado == "Amazonas - AM" || Estado == "Pará - PA" || Estado == "Roraima - RR" || Estado == "Rondônia - RO" || Estado == "Amapá - AP")
            {
                N.Items.Add(Estado);
                TE.Items.Remove(TE.Text);
                ne5++;
                NN.Text = ne5.ToString();
            }

            ne--;
            NTE.Text = ne.ToString();
        }
    }
}
