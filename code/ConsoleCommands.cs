using System.Linq;
using System.Collections.Generic;

namespace Sandbox;

public partial class ConsoleCommands : GClicker
{
	[ConCmd.Server( "garrys_clicker_players" )]
	static void garrys_clicker_players()
	{
		var target = ConsoleSystem.Caller;
		if ( target == null ) return;

		IReadOnlyList<IClient> All = new List<IClient>();

		Log.Info( "\nPlayers:" );

		foreach ( var ply in All )
		{
			Log.Info( $"{ply.Name} | {ply.SteamId} | {ply.NetworkIdent}" );
		}
	}
}
