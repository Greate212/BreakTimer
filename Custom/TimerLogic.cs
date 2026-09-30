namespace BreakTimer.Custom;

public class TimerLogic
{
    private bool isRunning;
    private bool colorToggle;
    private int intMin;
    private int intSec;
    
    public void BreakCountdown(int intMinutes)
    {
        isRunning = true;
        intMin = intMinutes - 1;
        intSec = 59;
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (isRunning == true)
            {
                if (intMin == 0 && intSec < 30)
                {
                    if (colorToggle)
                    {
                        colorToggle = false;
                        
                    }
                }
                if (intSec > 0)
                {
                    intSec--;
                }
                else if (intMin > 0)
                {
                    intSec = 59;
                    intMin--;
                }
                else
                {
                    isRunning = false;
                }
            }
            
            return isRunning;
        });
    }
    
    
    public string GetFormattedString()
    {
        return intMin.ToString().PadLeft(2, '0') + "Minutes & " + intSec.ToString().PadLeft(2, '0') + " Seconds Left.";
    }
}