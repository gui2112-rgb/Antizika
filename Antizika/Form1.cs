using System.Security.Cryptography;

namespace Antizika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalcularHash_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogAbrirArquivo = new OpenFileDialog())
            {
                dialogAbrirArquivo.Filter = "Todos os arquivos (*.*)|*.*";


                if (dialogAbrirArquivo.ShowDialog() == DialogResult.OK)

                {

                    string caminhoArquivo = dialogAbrirArquivo.FileName;

                    string HashSHA256 = CalculaHashSHA256 (caminhoArquivo);
                    Clipboard.SetText (HashSHA256);
                    MessageBox.Show("Hash colocado na área de transferência,");
                }


            }




        }



        //calcular Hash SHA256

        private string CalculaHashSHA256(string caminhoArquivo)
        {

            using (FileStream fs = File.OpenRead(caminhoArquivo)) 
            using (SHA256 sHA256 = SHA256.Create())
            {

                //Computa o HASH do arquivo e converter os bytes para string

                byte[] hashBytes = sHA256.ComputeHash(fs);
                return BitConverter.ToString(hashBytes).Replace("-","").ToLower();


            }

        }
    }
}
