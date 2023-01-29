using Sandbox.GClicker;
using Sandbox.UI;
using Sandbox.UI.Construct;

public partial class GarrysClickerMainPanels : Panel
{
	private Panel Box;
	private Panel ButtonClickPanel;
	private Button ButtonClicker;
	private Label Count;
	
	public GarrysClickerMainPanels()
	{
		//StyleSheet.Load( "/ui/GarrysClickerMainPanels.scss" );
		
		//Box = Add.Panel( "box" );
		
		//ButtonClickPanel = Box.Add.Panel( "button_click_panel" );
		
		//ButtonClicker = ButtonClickPanel.Add.Button( "" );
		//ButtonClicker.SetClass( ".button_click", true );

		//Count = Box.Add.Label( $"Count: {MyGame.Count}" ) ;

		//ButtonClicker.AddEventListener( "onclick", () =>
		//{
		//	MyGame.Count++;

		//	Count.Text = $"Count: {MyGame.Count}";
		//} );

		//ToSleep = Box.Add.Button( ".to_sleep" );
		//ToSleep.Text = "da";
		//ToSleep.Style.Dirty();
		//ToSleep.Focus();
	}

	public override void Tick()
	{
		base.Tick();

		ButtonClicker.SetClass( "button_click", true );
	}
}
