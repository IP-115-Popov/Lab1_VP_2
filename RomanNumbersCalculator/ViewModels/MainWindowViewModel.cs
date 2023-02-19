using Avalonia.Data;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool fladZapretMainos = false;
        private int? pa = null;
        private int? a = null;

        Stack<int?> ch = new Stack<int?>();
        Stack<string?> op = new Stack<string?>();


        public string? equation;
        public string? Equation
        {
            get => equation; 
            set 
            { 
                equation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Equation)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void f(int? ab)
        {
            if (pa != null)
            {
                if (pa < ab)
                {
                    if (fladZapretMainos) return;
                    fladZapretMainos = true;
                    ab -= pa;
                }
                else
                {
                    ab += pa;
                    fladZapretMainos = false;
                }
            }
            pa = ab;
        }
        private void f2(int? aF2, string? opF2)
        {
            ch.Push(aF2);
            if (op.Count != 0 && ch.Count >= 2)
            {
                if (op.Peek() == "*" || op.Peek() == "/" || op.Peek() == "+" || op.Peek() == "-")
                {
                    int? a1 = ch.Pop();
                    int? a2 = ch.Pop();
                    switch (op.Peek())
                    {
                        case "+":
                            aF2 = a1 + a2;
                            ch.Push(aF2);
                            break;
                        case "-":
                            aF2 = a2 - a1;
                            ch.Push(aF2);
                            break;
                        case "*":
                            aF2 = a1 * a2;
                            ch.Push(aF2);
                            break;
                        case "/":
                            aF2 = a2 / a1;
                            ch.Push(aF2);
                            break;
                        default:
                            break;
                    }
                }
            }
            op.Push(opF2);
        }
        public void ClickButton(string? argument)
        {
            switch (argument)
            {
                case "I":
                    Equation += argument;
                    f(1);
                    break;
                case "C":
                    Equation += argument;
                    f(100);
                    break;
                case "+":
                    Equation += argument;
                    a = pa;
                    pa = null;

                    f2(a, "+");
                    break;
                case "V":
                    Equation += argument;
                    f(5);
                    break;
                case "D":
                    Equation += argument;
                    f(500);
                    break;
                case "-":
                    Equation += argument;
                    a = pa;
                    pa = null;

                    f2(a, "-");
                    break;
                case "X":
                    Equation += argument;
                    f(10);
                    break;
                case "M":
                    Equation += argument;
                    f(1000);
                    break;
                case "*":
                    Equation += argument;
                    a = pa;
                    pa = null;

                    f2(a, "*");
                    break;
                case "L":
                    Equation += argument;
                    f(50);
                    break;
                case "/":
                    Equation += argument;
                    a = pa;
                    pa = null;

                    f2(a, "/");
                    break;
                case "CE":
                    Equation = null;
                    break;
                case "=":
                    a = pa;
                    pa = null;
                    f2(a, "/");
                    f(50);

                    Equation = Convert.ToString(ch.Pop());
                    ch.Clear();
                    op.Clear();
                    a = null;
                    pa = null;
                    fladZapretMainos = false;
                    break;
                default:
                    return;
            }
        }
    }
}
