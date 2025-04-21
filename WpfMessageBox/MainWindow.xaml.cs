using Microsoft.Win32;
using System.Windows;

namespace WpfMessageBox
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Could not open file.","Error", MessageBoxButton.OK,MessageBoxImage.Error);

           MessageBoxResult result =  MessageBox.Show("Do you agree?.", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes) 
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }


        }

        private void btnDialog_Click(object sender, RoutedEventArgs e)
        {


            OpenFileDialog fileDialog = new OpenFileDialog();

            //Filtro per la ricerca:ATTENZIONE ALLA SINTASSI CORRETTA!
            fileDialog.Filter = "C# Source Files | *.cs";

            //Imposto l'apertura iniziale della finestra sempre nello stesso punto (es Desktop)
            fileDialog.InitialDirectory = "C:\\Users\\gabry\\Desktop";

            //Inposto un titolo alla finestra 
            fileDialog.Title = "Selezionare Files Cs..";

            //Imposto selezione multipla che implica un array di stringhe 
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if (success == true) 
            { 
                //ottengo il percorso completo del file o dei files
                string [] paths = fileDialog.FileNames;

                //ottengo solo il nome del file o dei files
                string [] fileNames = fileDialog.SafeFileNames;

                //visualizzo percorso completo file
                //tbInfo2.Text = paths;


            }
            else
            {

            }
        }
    }
}