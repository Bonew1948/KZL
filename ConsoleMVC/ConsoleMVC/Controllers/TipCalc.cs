namespace ConsoleMVC
{
    internal class TipCalc
    {
        private Tip tip;
        private Display display;

        public TipCalc()
        { 
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalcTip();
            display.Total= tip.CalcTotal();
            display.ShowTipAndTotal();
        }
    }
}