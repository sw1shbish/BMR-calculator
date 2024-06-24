using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            
            if (BoxWeight.Text == "" || BoxWeight.Text == "" || BoxWeight.Text == "" || BoxWeight.Text == "" || BoxWeight.Text == "")
            {
                MessageBox.Show("прекратите, мы тут не шутки шутим!");
            }
            else
            {
                double bmr;
                double weight = Convert.ToDouble(BoxWeight.Text);
                double height = Convert.ToDouble(BoxHeight.Text);
                double age = Convert.ToDouble(BoxAge.Text);
                
                if (RbFormMafDj.IsChecked == true)
                {
                    if (RbGenderM.IsChecked == true)
                    {
                        if (RbWeightKg.IsChecked == true)
                        {
                            bmr = 10 * weight + 6.25 * height - 5 * age + 5;
                        }
                        else
                        {
                            bmr = 10 * weight / 2.2 + 6.25 * height - 5 * age + 5;
                        }
                    }
                    else
                    {
                        if (RbWeightKg.IsChecked == true)
                        {
                            bmr = 10 * weight + 6.25 * height - 5 * age - 161;
                        }
                        else
                        {
                            bmr = 10 * weight / 2.2 + 6.25 * height - 5 * age - 161;
                        }
                    }
                }
                else
                {
                    if (RbGenderM.IsChecked == true)
                    {
                        if (RbWeightKg.IsChecked == true)
                        {
                            bmr = 66.5 + 13.75 * weight + 5.003 * height - 6.775 * age;
                        }
                        else
                        {
                            bmr = 66.5 + 13.75 * weight / 2.2 + 5.003 * height - 6.775 * age;
                        }
                    }
                    else
                    {
                        if (RbWeightKg.IsChecked == true)
                        {
                            bmr = 65.51 + 9.563 * weight + 1.85 * height - 4.676 * age;
                        }
                        else
                        {
                            bmr = 65.51 + 9.563 * weight / 2.2 + 1.85 * height - 4.676 * age;
                        }
                    }
                }
                int d =CbEnergy.SelectedIndex;
                switch(d)
                {
                    case 0:
                        bmr = bmr * 1;
                        break;
                    case 1:
                        bmr = bmr * 1.2;
                        break;
                    case 2:
                        bmr = bmr * 1.375;
                        break;
                    case 3:
                        bmr = bmr * 1.4625;
                        break;
                    case 4:
                        bmr = bmr * 1.550;
                        break;
                    case 5:
                        bmr = bmr * 1.6375;
                        break;
                    case 6:
                        bmr = bmr * 1.725;
                        break;
                    case 7:
                        bmr = bmr * 1.9;
                        break;
                }
                if(RbVarKal.IsChecked == true)
                {
                    MessageBox.Show("Для поддержания веса необходимо "+bmr+" ккалорий\n"+"Для похудения необходимо "+bmr*0.8+ " ккалорий"+"Белки "+bmr*0.8+" грамм"+"Жиры "+bmr*0.3+" грамм"+"Углеводы "+bmr*0.5+" грамм");
                }
                else
                {
                    bmr = bmr * 4.1868;
                    MessageBox.Show("Для поддержания веса необходимо " + bmr + " килоджоулей\n" + "Для похудения необходимо " + bmr * 0.8 + " килоджоулей");
                }
            }
        }
        private void boxText_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "возраст" || textBox.Text == "сантиметров" )
            {
                textBox.Text = "";
            }
        }

        private void boxText_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == "boxAge" && textBox.Text == "")
            {
                BoxAge.Text = "возраст";
            }
            if (textBox.Name == "boxHeight" && textBox.Text == "")
            {
                BoxHeight.Text = "сантиметров";
            }
        }
        
    }
}