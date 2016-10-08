﻿using System.ComponentModel;
using LunaCommon.Enums;
using LunaServer.Log;

namespace LunaServer.Settings
{
    public class SettingsStore
    {
        [Description("Set to false if you don't want to appear on the server list. LAN networks for example")]
        public bool RegisterWithMasterServer = true;

        [Description("Specify in miliseconds how often we will register with masterserver.")]
        public int MasterServerRegistrationMsInterval = 10000;

        [Description("Specify in minutes how often /dekessler automatically runs. 0 = Disabled")]
        public int AutoDekessler = 30;

        [Description("Specify in minutes how often /nukeksc automatically runs. 0 = Disabled")]
        public int AutoNuke = 0;

        [Description("Enable use of Cheats in-game.")]
        public bool Cheats = true;

        [Description("Specify the Name that will appear when you send a message using the server's console.")]
        public string ConsoleIdentifier = "Server";

        [Description("Specify the amount of days a log file should be considered as expired and deleted. 0 = Disabled")]
        public double ExpireLogs = 0;

        [Description("Specify the gameplay difficulty of the server.")]
        public GameDifficulty GameDifficulty = GameDifficulty.NORMAL;

        [Description("Specify the game Type.")]
        public GameMode GameMode = GameMode.SANDBOX;
        
        [Description("Minimum log level.")]
        public LogLevels LogLevel = LogLevels.Debug;

        [Description("Main thread polling in ms")]
        public int MainTimeTick = 30;

        [Description("Maximum amount of Players that can join the server.")]
        public int MaxPlayers = 20;

        [Description("Enable mod control.\n# WARNING: Only consider turning off mod control for private servers.\n# " +
                     "The game will constantly complain about missing parts if there are missing mods.")]
        public ModControlMode ModControl = ModControlMode.ENABLED_STOP_INVALID_PART_SYNC;

        [Description("How many untracked asteroids to spawn into the universe. 0 = Disabled")]
        public int NumberOfAsteroids = 30;

        [Description("The Port the server listens on.")]
        public int Port = 6702;

        [Description("Specify the minimum distance in which vessels can interact with eachother at the launch pad and runway")]
        public float SafetyBubbleDistance = 100.0f;

        [Description("If true, sends the player to the latest Subspace upon connecting. If false, sends the player to the " +
                     "previous Subspace they were in.\n# NOTE: This may cause time-paradoxes, and will not work across server restarts.")]
        public bool SendPlayerToLatestSubspace = true;

        [Description("Specify the server's MOTD (message of the day). 255 chars max")]
        public string ServerMotd = "Welcome, %Name%!";

        [Description("Name of the server.")]
        public string ServerName = "Luna Server";

        [Description("Description of the server.")]
        public string Description = "Luna Server Description";

        [Description("Use UTC instead of system time in the log.")]
        public bool UseUtcTimeInLog = false;

        [Description("Specify the warp Type.")]
        public WarpMode WarpMode = WarpMode.SUBSPACE;

        [Description("Enable white-listing.")]
        public bool Whitelisted = false;

        [Description("Compress a message or not")]
        public bool CompressionEnabled { get; set; } = true;

        [Description("Heartbeat interval in Ms")]
        public int HearbeatMsInterval = 2000;

#if DEBUG
        [Description("Connection timeout in Ms")]
        public int ConnectionMsTimeout = 120000;
#else
        [Description("Connection timeout in Ms")]
        public int ConnectionMsTimeout = 20000;
#endif

        [Description("Interval in Ms at wich the client will send updates for his vessels.\n" +
                     "#Decrease it if your clients have good network connection and you plan to do dogfights")]
        public int VesselUpdatesSendMsInterval = 30;

        [Description("If this is set to true, vessels can be taken by anyone after a player switch to another vessel.")]
        public bool DropControlOnVesselSwitching = true;

        [Description("If this is set to true, vessels can be taken by anyone after a player switch to track station, space center or VAB/SPH.")]
        public bool DropControlOnExitFlight = true;

        [Description("If this is set to true, vessels can be taken by anyone after a player disconnects.")]
        public bool DropControlOnExit = true;

        [Description("Interval in seconds at wich players will check and send scenario changes to the server.")]
        public int SendScenarioDataSecInterval = 60;
        
        [Description("Username of the player who control the warp if WarpMode is set to MASTER")]
        public string WarpMaster = "";

        [Description("Interval at wich users will check the vessels that are in other subspaces so they have to be removed")]
        public int VesselKillCheckMsInterval = 1000;

        [Description("Interval in ms at wich users will sync time with the server")]
        public int ClockSetMsInterval = 100;

        [Description("Interval in ms at wich users will check for vessels in empty subspaces and move them to the server subspace")]
        public int StrandedVesselsCheckMsInterval = 100;

        public int FarDistanceUpdateIntervalMs { get; set; } = 500; // 2FPS
        public int MediumDistanceUpdateIntervalMs { get; set; } = 250; //4 FPS
        public int CloseDistanceUpdateIntervalMs { get; set; } = 33; //30 FPS
        public int CloseDistanceInMeters { get; set; } = 25000;
        public int SendReceiveThreadTickMs { get; set; } = 10;
    }
}