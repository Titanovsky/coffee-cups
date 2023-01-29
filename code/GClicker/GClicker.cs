using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Sandbox.GClicker;

public partial class GClicker : GameManager
{
	public static int Count { get; set; }

	public GarrysClickerHUD HUD;

	public GClicker()
	{
		if ( Game.IsClient ) HUD = new GarrysClickerHUD();
	}

	[Event.Hotload]
	public void HotloadUpdate()
	{
		if ( !Game.IsClient ) return;

		HUD?.Delete();
		HUD = new GarrysClickerHUD();

		Log.Info( "[HUD] Update" );
	}

	public override void ClientJoined( IClient client )
	{
		base.ClientJoined( client );

		Log.Info( $"\"{client.Name}\" ({client.Id}) join in game!" );

		//// Create a pawn for this client to play with
		//var pawn = new Pawn();
		//client.Pawn = pawn;

		//// Get all of the spawnpoints
		//var spawnpoints = Entity.All.OfType<SpawnPoint>();

		//// chose a random one
		//var randomSpawnPoint = spawnpoints.OrderBy( x => Guid.NewGuid() ).FirstOrDefault();

		//// if it exists, place the pawn there
		//if ( randomSpawnPoint != null )
		//{
		//	var tx = randomSpawnPoint.Transform;
		//	tx.Position = tx.Position + Vector3.Up * 50.0f; // raise it up
		//	pawn.Transform = tx;
		//}
	}
}
