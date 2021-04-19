using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public partial class FrmDolar : Form
    {
        public FrmDolar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=dd507139";

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(strURL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;

                    Mercado mercado = JsonConvert.DeserializeObject<Mercado>(resultado);

                    lblMstCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Compra);
                    lblMstVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Venda);
                    lblMstVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mercado.Moeda.Variacao/100);
                }
            }
        }

        private void lblMstVenda_Click(object sender, EventArgs e)
        {

        }

        private void lblMstCompra_Click(object sender, EventArgs e)
        {

        }

        private void lblMstVariacao_Click(object sender, EventArgs e)
        {

        }

        private void lblVariacao_Click(object sender, EventArgs e)
        {

        }

        private void lblVenda_Click(object sender, EventArgs e)
        {

        }

        private void lblCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
