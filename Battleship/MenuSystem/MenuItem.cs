using System;
using GameLogic;
namespace MenuSystem
{
    public class MenuItem
    {
        public virtual string OptionLabelToChoose { get; set; }
        public virtual string OptionValue { get; set; }
        public virtual Action OptionToExecute { get; set; }
        public virtual Func<Cell> OptionFuncToExecute { get; set; }     
        public FuncToExecute FunctionToExectue;
        public delegate void FuncToExecute(Cell[][] cell);
        public MenuItem(string optionLabelToChoose, string optionValue, Action optionToExecute)
        {
            OptionLabelToChoose = optionLabelToChoose.Trim();
            OptionValue = optionValue.Trim();
            OptionToExecute = optionToExecute;
        }
        public MenuItem(string optionLabelToChoose, string optionValue, FuncToExecute func)
        {
            OptionLabelToChoose = optionLabelToChoose.Trim();
            OptionValue = optionValue.Trim();
            FunctionToExectue = func;
        }
        
        public override string ToString()
        {
            return OptionLabelToChoose + ") " + OptionValue;
        }
    }
}