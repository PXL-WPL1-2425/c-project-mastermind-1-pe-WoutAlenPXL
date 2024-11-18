 public partial class MainWindow : Window

    {
    int attempts;

    private DispatcherTimer timer = new DispatherTimer();

    public MainWindow()
    {
        IntializeComponent;
    
        timer.Tick += Timer_Tick;
        timer.Interval = new TimeSpan(0,0,10);
        timer.Start;
    }
    
    private void Timer_Tick(object sender, EventArgs e)
    {
        timeLabel.Content = $"DateTime.Now.ToLongTimeString()}";
    }
    
    
  
    
    private void toggledebug{object sender, KeyEventArgs e)
    {
      if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && Key.F12)
      {
        Show.TextBox
    }
    
  