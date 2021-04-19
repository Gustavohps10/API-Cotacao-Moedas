using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace API
{
    public partial class FrmBitcoin : Form
    {
        public FrmBitcoin()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,BTC&key=dd507139";

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(strURL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;

                    Mercado mercado = JsonConvert.DeserializeObject<Mercado>(resultado);

                    lblMstCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Compra);
                    lblMstVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Venda);
                    lblMstVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mercado.Moeda.Variacao / 100);
                }
            }
        }
    }
}