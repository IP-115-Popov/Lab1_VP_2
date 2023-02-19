using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez1 = "I";

            await Task.Delay(100);

            var buttonOne = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonOne");
            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;

            buttonOne.Command.Execute(buttonOne.CommandParameter);
            await Task.Delay(50);

            var textBoxText = textBox.Text as string;
            Assert.True(rez1 == textBoxText);
        }
        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez2 = null;

            await Task.Delay(100);

            var buttonClin = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClin");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonClin.Command.Execute(buttonClin.CommandParameter);

            await Task.Delay(50);

            var textBoxText = textBox.Text as string;

            Assert.True(rez2 == textBoxText);
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez3 = "C+C";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonPlas = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonPlas");
            //var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Button");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);
            buttonPlas.Command.Execute(buttonPlas.CommandParameter);
            await Task.Delay(500);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);

            var textBoxText = textBox.Text as string;

            Assert.True(rez3 == textBoxText);

        }
        [Fact]
        public async void TestSum()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez4 = "200";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonPlas = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonPlas");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);
            buttonPlas.Command.Execute(buttonPlas.CommandParameter);
            await Task.Delay(500);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(500);

            var textBoxText = textBox.Text as string;

            Assert.True(rez4 == textBoxText);

        }
        [Fact]
        public async void TestMinus()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            string? rez5 = "0";

            await Task.Delay(100);

            var buttonHandred = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonHandred");
            var buttonMinus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonMinus");
            var buttonEquals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonEquals");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();
            textBox.Text = null;

            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);
            buttonMinus.Command.Execute(buttonMinus.CommandParameter);
            await Task.Delay(500);
            buttonHandred.Command.Execute(buttonHandred.CommandParameter);
            await Task.Delay(500);
            buttonEquals.Command.Execute(buttonEquals.CommandParameter);
            await Task.Delay(500);

            var textBoxText = textBox.Text as string;

            Assert.True(rez5 == textBoxText);

        }
    }
}