namespace BreakTimer;
using BreakTimer.Custom;

public partial class MainPage : ContentPage
{
    private TimerLogic oTimer = new TimerLogic();
    
    
    public MainPage()
    {
        InitializeComponent();
        this.Title = "BREAK TIME";
    }
    
    private void BtnTakeFive_OnClicked(object sender, EventArgs e)
    {
        lblDisplayBreakSelected.Text = "Relax!";

        oTimer.BreakCountdown(5);
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            lblDisplayBreakTime.Text = oTimer.GetFormattedString();
            
            return true;
        });
        
    }

    private void BtnTakeTen_OnClicked(object sender, EventArgs e)
    {
        lblDisplayBreakSelected.Text = "Take It Easy!!";

        oTimer.BreakCountdown(10);
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            lblDisplayBreakTime.Text = oTimer.GetFormattedString();
            
            return true;
        });

    }

    private void BtnTakeFifteen_OnClicked(object sender, EventArgs e)
    {
        lblDisplayBreakSelected.Text = "Rest A while!";

        oTimer.BreakCountdown(15);
        
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            lblDisplayBreakTime.Text = oTimer.GetFormattedString();
            
            return true;
        });

    }
}