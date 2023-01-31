namespace Sandbox;

public partial class GClicker : GameManager
{
	public static int Clicks { get; set; }
	public GClickerUI UI;

	public GClicker()
	{
		Sound.FromScreen( "sboxnews" );
		Sound.FromScreen( "music" ).SetVolume( 0.4f );

		if ( Game.IsClient )
		{
			UI = new GClickerUI();
		}
	}

	[Event.Hotload]
	public void HotloadUpdate()
	{
		if ( !Game.IsClient ) return;

		UI?.Delete();
		UI = new GClickerUI();

		Log.Info( "[GClicker] UI updated!" );
	}

	public override void ClientJoined( IClient client )
	{
		base.ClientJoined( client );
	}

	public static void AddClicks( int add = 1 )
	{
		Clicks += add;

		using ( Prediction.Off() )
		{
			Sound.FromScreen( "click" );
		}
	}
}

public partial class Pawn : AnimatedEntity
{
	public override void Spawn()
	{
		base.Spawn();
	}

	public override void Simulate( IClient cl )
	{
		base.Simulate( cl );
	}

	public override void FrameSimulate( IClient cl )
	{
		base.FrameSimulate( cl );
	}
}
