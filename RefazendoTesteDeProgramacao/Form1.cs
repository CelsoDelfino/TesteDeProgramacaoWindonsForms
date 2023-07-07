namespace RefazendoTesteDeProgramacao
{
    public partial class Form1 : Form
    {
        List<string> linhas = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.fileSystemWatcher.EnableRaisingEvents = true;
            CopiarArquivoParaPastaDestino();
        }
       

        public void AtivarThreads()
        {
            Thread threadA = new Thread(() => ColunaA(linhas));
            threadA.Start();
            threadA.Join();
            Thread threadB = new Thread(() => ColunaB(linhas));
            threadB.Start();
        }

        public List<string> ColunaThreadB(List<string> linhas)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                foreach (var linha in linhas)
                {
                    var colunaIndice = linha;
                    listView1.Items.Add(colunaIndice[2].ToString());
                }
            }));
            
            return linhas;
        }

        public void CopiarArquivoParaPastaDestino()
        {
            try
            {
                File.Copy("C:\\MonitorarDiretorioFonte\\ArquivoDoTeste.csv", "C:\\Monitorar\\ArquivoDoTeste.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(e.FullPath))
                {
                    string linha;

                    while ((linha = reader.ReadLine()) != null)
                    {
                        linhas.Add(linha);
                    }
                }
                AtivarThreads();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ColunaA(List<string> linhas)
        {
            foreach (var linha in linhas)
            {
                Thread.Sleep(10);
                if (IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        var colunaIndice = linha;
                        listView1.Items.Add(colunaIndice[0].ToString());   
                    });
                }
            }
        }


        public void ColunaB(List<string> linhas)
        {
            foreach (var linha in linhas)
            {
                Thread.Sleep(10);
                if (IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        var colunaIndice = linha;
                        listView1.Items.Add(colunaIndice[2].ToString());
                    });
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}