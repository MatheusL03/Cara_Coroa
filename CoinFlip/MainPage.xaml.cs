namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SortearBtn_Clicked(object sender, EventArgs e) //Ao cliclar no botão `SORTEAR` ela realiza toda operção que foi feito na Função `VerificarResultado` 
        {
            string escolha = Sidespicker.SelectedItem.ToString(); // Uma variavel para verificar qual opção do Picker foi escolhida pelo usuario. 

            VerificarResultado(escolha); //Exibi o resultado, e foi passado como parâmetro na Função `VerificarResultado` 
        }


        private void VerificarResultado(string escolha)
        {
            Random nr = new Random();  // Crio uma variavel que gera numeros aleatorios  

            bool resultado = nr.Next(2) == 0;  // Faço essa variavel ter um limite de até 2 numeros para exibir. 


            if ((escolha == "Cara" && resultado) || (escolha == "Coroa" && !resultado)) // Condição para verificar se deu cara ou coroa 
            {
                imgMoeda.Source = "cara.jpg"; // ESSA MERDA NÃO FUNCIONA!
                ResulLabel.Text = "Você Ganhou!"; // Essa Sim! 
            }
            else

            {
                imgMoeda.Source = "coroa.jpg";  // ESSA MERDA NÃO FUNCIONA! 
                ResulLabel.Text = "Você Perdeu!"; // Essa Sim! 
            }


        }
    }

}
