namespace TareaOperacionesMath
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        public async void Button_suma(Object sender, EventArgs e)
        {
            var num1 = double.Parse(numero1.Text);
            var num2 = double.Parse(numero2.Text);
            var resul = num1 + num2;
            await Navigation.PushAsync(new ModalPage(resul.ToString()));


        }
        public async void Button_resta(Object sender, EventArgs e)
        {
            var num1 = double.Parse(numero1.Text);
            var num2 = double.Parse(numero2.Text);
            var resul = num1 - num2;
            await Navigation.PushAsync(new ModalPage(resul.ToString()));
        }
        public async void Button_multiplicacion(Object sender, EventArgs e)
        {
            var num1 = double.Parse(numero1.Text);
            var num2 = double.Parse(numero2.Text);
            var resul = num1 * num2;
            await Navigation.PushAsync(new ModalPage(resul.ToString()));
        }



        public async void Button_divicion(Object sender, EventArgs e)
        {
            var num1 = double.Parse(numero1.Text);
            var num2 = double.Parse(numero2.Text);
            var resul = num1 / num2;
            await Navigation.PushAsync(new ModalPage(resul.ToString()));
        }
    }
}