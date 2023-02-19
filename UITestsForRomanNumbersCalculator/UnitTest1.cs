using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void TestKhaki()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? c = "I";

            await Task.Delay(100);

            var buttonOne = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonOne");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonOne.Command.Execute(buttonOne.CommandParameter);

            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(textBoxText.Equals(c));
        }
    }
}