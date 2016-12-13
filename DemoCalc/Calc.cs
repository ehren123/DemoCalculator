using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalc
{
    class Calc
    {

        // Constructor
        public Calc()
        {
            Clear();
        }

        // Event triggers label update.
        public event EventHandler<CalcEventArgs> OnCurrentChange;

        // Next action to perform
        public string NextAction { get; set; }


        // Last value typed
        public double Num { get; set; }

        // Final result
        public double Result { get; set; }


        // Txtbox will get current.
        private string _current;
        public string Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
                OnCurrentChange?.Invoke(this, new CalcEventArgs(_current));
            }
        }
        

        // Clear stats
        public void Clear()
        {
            Result = 0;
            Current = "";
            NextAction = "Blank";
            Num = 0;
        }


        // Manage memory
        public double Mem { get; set; }


        // Async factorial
        public async Task<long> FactorialAsync(long n)
        {
            return await Task.Run(() => Factorial(n));
        }


        // Recursive factorials
        public long Factorial(long n)
        {
            checked
            {
                if (n == 1)
                    return 1;

                return Factorial(n - 1) * n;
            }

        }


        // Execute when symbol is pressed
        public void Enter()
        {
            switch (NextAction)
            {

                case "Blank":
                    Result += Num;
                    Current = "";
                    Num = 0;
                    break;
                case "Add":
                    Result += Num;
                    Current = "";
                    Num = 0;
                    break;
                case "Sub":
                    Result = Result - Num;
                    Current = "";
                    Num = 0;
                    break;
                case "Mul":
                    Result = Result * Num;
                    Current = "";
                    Num = 0;
                    break;
                case "Div":
                    Result = Result / Num;
                    Current = "";
                    Num = 0;
                    break;
                case "Sqr":
                    Result = Math.Sqrt(Num);
                    Current = Result.ToString();
                    Num = 0;
                    break;
                default:
                    break;                                     
            }     
        }


        // Equals logic
        public void Equals()
        {
            switch (NextAction)
            {
                
                case "Add":
                    Result += Num;
                    Current = Result.ToString();
                    break;
                case "Sub":
                    Result -= Num;
                    Current = Result.ToString();                    
                    break;
                case "Mul":
                    Result *= Num;
                    Current = Result.ToString();                    
                    break;
                case "Div":
                    Result = Result / Num;
                    Current = Result.ToString();
                    break;          
                default:
                    break;
            }


            // Clear everything.
            NextAction = "Blank";
            Num = 0;
            Result = 0;
        }
    }
}
