using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public partial class GarrysClickerHUD : HudEntity<RootPanel>
{
	public GarrysClickerHUD()
	{
		RootPanel.AddChild<GarrysClickerMainPanels>();
		//RootPanel.AddChild<SpawnMenu>();
	}
}
