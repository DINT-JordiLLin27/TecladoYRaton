using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BotonIzquierdoTextBox.IsReadOnly = true;
            BotonDerechoTextBox.IsReadOnly = true;
        }

        //Función que cambia a mayúsculas el contenido de MayusculasTextBox
        private void CambiaLetrasMayusculas()
        {
            MayusculasTextBox.CharacterCasing = CharacterCasing.Upper;
        }

        //Evento que controla si se ha presionado la tecla F1 y si es así, cambia el texto a "Ayuda"
        private void AyudaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                AyudaTextBox.Text = "Ayuda";
            else
                AyudaTextBox.Text = "";
        }



        //Listener común para los eventos de la ventana "MouseDown" y "MouseUp"
        private void ClicksRaton(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                BotonIzquierdoTextBox.Background = Brushes.Green;
            else
                BotonIzquierdoTextBox.Background = Brushes.White;

            if (e.RightButton == MouseButtonState.Pressed)
                BotonDerechoTextBox.Background = Brushes.Green;
            else
                BotonDerechoTextBox.Background = Brushes.White;
        }

        //Manejador de evento que controla cuando se el ratón pasa sobre el objeto, 
        //después llama al método para cambiar el nombre al TextBox correspondiente.
        private void MouseEnter_Todos(object sender, MouseEventArgs e)
        {
            CambiaTextoRatonSobreTextBox(sender);
        }

        //Manejador de evento que controla cuando se tiene foco sobre el objeto, 
        //después llama al método para cambiar el nombre al TextBox correspondiente.
        private void TextBoxes_GotFocus(object sender, RoutedEventArgs e)
        {
            CambiaTextoFocoTextBox(sender);
            
        }

        //Método que cambia el texto de 'FocoTextBox' según el objeto.
        private void CambiaTextoFocoTextBox(object sender)
        {

            if (sender.Equals(MayusculasTextBox))
            {
                FocoTextBox.Text = "TextBox 1";
                CambiaLetrasMayusculas();
            }
            else if (sender.Equals(AyudaTextBox))
                FocoTextBox.Text = "TextBox 2";
            else if (sender.Equals(SinVocalesTextBox))
            {
                FocoTextBox.Text = "TextBox 3";
            }
            else
                FocoTextBox.Text = "";
        }

        //Método que cambia el texto de 'RatonSobreTextBox' según el objeto.
        private void CambiaTextoRatonSobreTextBox(object sender)
        {

            if (sender.Equals(MayusculasTextBox))
                RatonSobreTextBox.Text = "TextBox 1";
            else if (sender.Equals(AyudaTextBox))
                RatonSobreTextBox.Text = "TextBox 2";
            else if (sender.Equals(SinVocalesTextBox))
                RatonSobreTextBox.Text = "TextBox 3";
        }

        //Limpia el TextBox 'RatonSobreTextBox'
        private void LimpiaFoco_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void SinVocalesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                    e.Handled = true;
                    break;

                case Key.E:
                    e.Handled = true;
                    break;

                case Key.I:
                    e.Handled = true;
                    break;

                case Key.O:
                    e.Handled = true;
                    break;

                case Key.U:
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }
    }
}
