using OverwatchAPI.Internal;
using System;
using System.Collections.Generic;

//-- A U T O   G E N E R A T E D --//

namespace OverwatchAPI.Data
{
	public class Symmetra : IStatGroup
	{
		public HeroSpecificStats HeroSpecific { get; private set; }
		public CombatStats Combat { get; private set; }
		public BestStats Best { get; private set; }
		public AverageStats Average { get; private set; }
		public DeathsStats Deaths { get; private set; }
		public MatchAwardsStats MatchAwards { get; private set; }
		public GameStats Game { get; private set; }

		public void SendPage(IEnumerable<OverwatchDataTable> tableCollection)
		{
			foreach(var item in tableCollection)
			{
				var prop = GetType().GetProperty(item.Name.Replace(" ", ""));
				if (typeof(IStatModule).IsAssignableFrom(prop.PropertyType))
				{
					IStatModule statModule = (IStatModule)Activator.CreateInstance(prop.PropertyType);
					statModule.SendTable(item);
					prop.SetValue(this, statModule);
				}
			}
		}

		public class HeroSpecificStats : IStatModule
		{
			public int SentryTurretKills { get; private set; }
			public int SentryTurretKillsMostinGame { get; private set; }
			public int PlayersTeleported { get; private set; }
			public int PlayersTeleportedMostinGame { get; private set; }
			public int ShieldsProvided { get; private set; }
			public int ShieldsProvidedMostinGame { get; private set; }
			public int TeleporterUptime { get; private set; }
			public int TeleporterUptimeBestinGame { get; private set; }
			public float ShieldsProvidedAverage { get; private set; }
			public float SentryTurretKillsAverage { get; private set; }
			public float PlayersTeleportedAverage { get; private set; }
			public float TeleporterUptimeAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				SentryTurretKills = table.Stats["Sentry Turret Kills"].OWValToInt();
				SentryTurretKillsMostinGame = table.Stats["Sentry Turret Kills - Most in Game"].OWValToInt();
				PlayersTeleported = table.Stats["Players Teleported"].OWValToInt();
				PlayersTeleportedMostinGame = table.Stats["Players Teleported - Most in Game"].OWValToInt();
				ShieldsProvided = table.Stats["Shields Provided"].OWValToInt();
				ShieldsProvidedMostinGame = table.Stats["Shields Provided - Most in Game"].OWValToInt();
				TeleporterUptime = table.Stats["Teleporter Uptime"].OWValToInt();
				TeleporterUptimeBestinGame = table.Stats["Teleporter Uptime - Best in Game"].OWValToInt();
				ShieldsProvidedAverage = table.Stats["Shields Provided - Average"].OWValToFloat();
				SentryTurretKillsAverage = table.Stats["Sentry Turret Kills - Average"].OWValToFloat();
				PlayersTeleportedAverage = table.Stats["Players Teleported - Average"].OWValToFloat();
				TeleporterUptimeAverage = table.Stats["Teleporter Uptime - Average"].OWValToFloat();
			}
		}

		public class CombatStats : IStatModule
		{
			public int Eliminations { get; private set; }
			public int FinalBlows { get; private set; }
			public int SoloKills { get; private set; }
			public int DamageDone { get; private set; }
			public int ObjectiveKills { get; private set; }
			public float EliminationsperLife { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Eliminations = table.Stats["Eliminations"].OWValToInt();
				FinalBlows = table.Stats["Final Blows"].OWValToInt();
				SoloKills = table.Stats["Solo Kills"].OWValToInt();
				DamageDone = table.Stats["Damage Done"].OWValToInt();
				ObjectiveKills = table.Stats["Objective Kills"].OWValToInt();
				EliminationsperLife = table.Stats["Eliminations per Life"].OWValToFloat();
			}
		}

		public class BestStats : IStatModule
		{
			public int EliminationsMostinLife { get; private set; }
			public int MostScorewithinoneLife { get; private set; }
			public int DamageDoneMostinLife { get; private set; }
			public int KillStreakBest { get; private set; }
			public int DamageDoneMostinGame { get; private set; }
			public int EliminationsMostinGame { get; private set; }
			public int FinalBlowsMostinGame { get; private set; }
			public int ObjectiveKillsMostinGame { get; private set; }
			public int ObjectiveTimeMostinGame { get; private set; }
			public int SoloKillsMostinGame { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				EliminationsMostinLife = table.Stats["Eliminations - Most in Life"].OWValToInt();
				MostScorewithinoneLife = table.Stats["Most Score within one Life"].OWValToInt();
				DamageDoneMostinLife = table.Stats["Damage Done - Most in Life"].OWValToInt();
				KillStreakBest = table.Stats["Kill Streak - Best"].OWValToInt();
				DamageDoneMostinGame = table.Stats["Damage Done - Most in Game"].OWValToInt();
				EliminationsMostinGame = table.Stats["Eliminations - Most in Game"].OWValToInt();
				FinalBlowsMostinGame = table.Stats["Final Blows - Most in Game"].OWValToInt();
				ObjectiveKillsMostinGame = table.Stats["Objective Kills - Most in Game"].OWValToInt();
				ObjectiveTimeMostinGame = table.Stats["Objective Time - Most in Game"].OWValToInt();
				SoloKillsMostinGame = table.Stats["Solo Kills - Most in Game"].OWValToInt();
			}
		}

		public class AverageStats : IStatModule
		{
			public float DeathsAverage { get; private set; }
			public float SoloKillsAverage { get; private set; }
			public float ObjectiveTimeAverage { get; private set; }
			public float ObjectiveKillsAverage { get; private set; }
			public float FinalBlowsAverage { get; private set; }
			public float EliminationsAverage { get; private set; }
			public float DamageDoneAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				DeathsAverage = table.Stats["Deaths - Average"].OWValToFloat();
				SoloKillsAverage = table.Stats["Solo Kills - Average"].OWValToFloat();
				ObjectiveTimeAverage = table.Stats["Objective Time - Average"].OWValToFloat();
				ObjectiveKillsAverage = table.Stats["Objective Kills - Average"].OWValToFloat();
				FinalBlowsAverage = table.Stats["Final Blows - Average"].OWValToFloat();
				EliminationsAverage = table.Stats["Eliminations - Average"].OWValToFloat();
				DamageDoneAverage = table.Stats["Damage Done - Average"].OWValToFloat();
			}
		}

		public class DeathsStats : IStatModule
		{
			public int Deaths { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Deaths = table.Stats["Deaths"].OWValToInt();
			}
		}

		public class MatchAwardsStats : IStatModule
		{
			public int MedalsBronze { get; private set; }
			public int MedalsSilver { get; private set; }
			public int MedalsGold { get; private set; }
			public int Medals { get; private set; }
			public int Cards { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				MedalsBronze = table.Stats["Medals - Bronze"].OWValToInt();
				MedalsSilver = table.Stats["Medals - Silver"].OWValToInt();
				MedalsGold = table.Stats["Medals - Gold"].OWValToInt();
				Medals = table.Stats["Medals"].OWValToInt();
				Cards = table.Stats["Cards"].OWValToInt();
			}
		}

		public class GameStats : IStatModule
		{
			public TimeSpan TimePlayed { get; private set; }
			public int GamesPlayed { get; private set; }
			public int GamesWon { get; private set; }
			public int Score { get; private set; }
			public int ObjectiveTime { get; private set; }
			public int TimeSpentonFire { get; private set; }
			public int WinPercentage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				TimePlayed = table.Stats["Time Played"].OWValToTimeSpan();
				GamesPlayed = table.Stats["Games Played"].OWValToInt();
				GamesWon = table.Stats["Games Won"].OWValToInt();
				Score = table.Stats["Score"].OWValToInt();
				ObjectiveTime = table.Stats["Objective Time"].OWValToInt();
				TimeSpentonFire = table.Stats["Time Spent on Fire"].OWValToInt();
				WinPercentage = table.Stats["Win Percentage"].OWValToInt();
			}
		}
	}
}