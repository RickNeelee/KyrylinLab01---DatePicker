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

namespace KyrylinDateLab01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DateChoice_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var ageInYears = GetAge(DateChoice.SelectedDate.Value, DateTime.Today);
            if ((ageInYears < 0) || (ageInYears > 135))
            {
                MessageBox.Show("Error! Wrong B-Day!");
            }
            else if ((DateChoice.SelectedDate.Value.Day == DateTime.Today.Day) && (DateChoice.SelectedDate.Value.Month == DateTime.Today.Month))
            {
                AgeOutput.Text = "Happy birthday! You're turning " + ageInYears.ToString() + " today!";

                ZodiacOutput.Text = "Your zodiac sign is " + GetZodiac(DateChoice.SelectedDate.Value);

                ChineseZodiacOutput.Text = "Your Chinese zodiac is " + GetChineseZodiac(DateChoice.SelectedDate.Value);
            }
            else
            {
                AgeOutput.Text = "Your age is " + ageInYears.ToString() + " full years.";

                ZodiacOutput.Text = "Your zodiac sign is " + GetZodiac(DateChoice.SelectedDate.Value);

                ChineseZodiacOutput.Text = "Your Chinese zodiac is " + GetChineseZodiac(DateChoice.SelectedDate.Value);
            }

        }

        int GetAge(DateTime startDate, DateTime endDate)
        {
            return (endDate.Year - startDate.Year - 1) +
                (((endDate.Month > startDate.Month) ||
                ((endDate.Month == startDate.Month) && (endDate.Day >= startDate.Day))) ? 1 : 0);
        }
        
        public string GetZodiac(DateTime birthDate)
        {
            switch (birthDate.Month)
            {
                case 1:
                    {
                        if (birthDate.Day < 21) return "Capricorn";
                        else return "Aquarius";
                    }
                case 2:
                    {
                        if (birthDate.Day < 20) return "Aquarius";
                        else return "Pisces";
                    }
                case 3:
                    {
                        if (birthDate.Day < 21) return "Pisces";
                        else return "Aries";
                    }
                case 4:
                    {
                        if (birthDate.Day < 21) return "Aries";
                        else return "Taurus";
                    }
                case 5:
                    {
                        if (birthDate.Day < 22) return "Taurus";
                        else return "Gemini";
                    }
                case 6:
                    {
                        if (birthDate.Day < 22) return "Gemini";
                        else return "Cancer";
                    }
                case 7:
                    {
                        if (birthDate.Day < 23) return "Cancer";
                        else return "Leo";
                    }
                case 8:
                    {
                        if (birthDate.Day < 22) return "Leo";
                        else return "Virgo";
                    }
                case 9:
                    {
                        if (birthDate.Day < 24) return "Virgo";
                        else return "Libra";
                    }
                case 10:
                    {
                        if (birthDate.Day < 24) return "Libra";
                        else return "Scorpio";
                    }
                case 11:
                    {
                        if (birthDate.Day < 24) return "Scorpio";
                        else return "Saggitarius";
                    }
                case 12:
                    {
                        if (birthDate.Day < 23) return "Saggitarius";
                        else return "Capricorn";
                    }
                default: return "Ophiuchus"; 
            }
        }

        public string GetChineseZodiac(DateTime birthDate)
        {
            switch ((birthDate.Year - 4 ) % 12)
            {
                case 0:
                    {
                        return "Rat";
                    }
                case 1:
                    {
                        return "Ox";
                    }
                case 2:
                    {
                        return "Tiger";
                    }
                case 3:
                    {
                        return "Rabbit";
                    }
                case 4:
                    {
                        return "Dragon";
                    }
                case 5:
                    {
                        return "Snake";
                    }
                case 6:
                    {
                        return "Horse";
                    }
                case 7:
                    {
                        return "Goat";
                    }
                case 8:
                    {
                        return "Monkey";
                    }
                case 9:
                    {
                        return "Rooster";
                    }
                case 10:
                    {
                        return "Dog";
                    }
                case 11:
                    {
                        return "Pig";
                    }
                default: return "Unknown"; 
            }
        }
        
        private void ExitChecker_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
