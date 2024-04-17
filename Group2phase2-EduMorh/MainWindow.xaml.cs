using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group2phase2_EduMorh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterCourse_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CourseRegistrationPage());
        }

        private void ViewCourses_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewCoursesPage());
        }

        private void ViewCart_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewCartPage());
        }

        private void TakeAssessment_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TakeAssessmentPage());
        }

        private void ViewCertifications_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewCertificationsPage());
        }
    }

    internal class ViewCertificationsPage : CourseRegistrationPage
    {
    }

    internal class TakeAssessmentPage : CourseRegistrationPage
    {
    }

    internal class ViewCartPage : CourseRegistrationPage
    {
    }

    internal class ViewCoursesPage : CourseRegistrationPage
    {
    }

    internal class CourseRegistrationPage
    {
        public CourseRegistrationPage()
        {
        }
    }
}
