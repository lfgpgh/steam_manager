Dependent tools:
	SteamCMD
	Steam
	Steam Api

Used Languages, frameworks and technologies
	C#
	MVC
	Entity w/ Code First Approach
	MS Sql Server
	JQuery
	Bootstrap
	Respond
	JSON Objects
	CLAP Interface 
	MVC web api
	OWIN Self hosted Web Api
	Winform
	NLog

ShortCut scripts/executable : TBD
	Sends a command to the client to play a game

Steam Client Api : OWIN Self hosted Web Api
	Need to create a ping test controller for testing purposes
	Create a unique key to use for communication with the server(we will use the local computer name hashed into a hex value)
	Needs to be aware of where Steam's exe is installed(configurable)
	Needs to be aware of where the SteamCMD tool is located(configurable)
	Needs basic error logging output to a configurable location. Also needs to auto archive and clean up after itself(we'll use NLog for this)
	Should be able to accept login credentials from the server
	Can kill the steam process
	Can install games(using the steamCMD tool)
	Accepts input from Desktop Shortcut to play a game and logs into the steam profile that has the game bought and installs it if its not already installed

Steam Server Api : MVC Web Api
	Houses all of the Username and password for steam(CANNOT BE PLAIN TEXT! needs to be encrypted at rest)
	In charge of knowing what accounts are currently being used
	In charge of knowing what games are associated with what account
	Needs basic error logging output to a configurable location. Also needs to auto archive and clean up after itself(we'll use NLog for this)

Steam Server UI : MVC.net website
	Need a grid to manage client data(all of the computers comminicating to the server)
	Need to manually be able to invoke the ApiDataService and commands to the client(log in, logout, kill process,etc)
	Needs basic error logging output to a configurable location. Also needs to auto archive and clean up after itself(we'll use NLog for this)
	Authentication system so only users with an account can log in

ApiDataService : CLAP Interface tool
	Behind the scenes tool to pull data from steams api(Console application that runs as a scheduled task)
	The service will take data from the api and put it into the database for the Steam server to read from
	Pulls Steam User's list for games
	Pulls Game information
	Needs basic error logging output to a configurable location. Also needs to auto archive and clean up after itself(we'll use NLog for this)

Persistence Model: MS Sql Server w/ Entity Code first approach
	Device: 				Table
		Id:					GUID
		DisplayName: 		string
		ComputerName: 		string
		IP: 				string(possbily an IP data type, depends on whether entity can handle it)
		CreatedOn: 			DateTimeOffset
		UpdatedOn: 			DateTimeOffset

	SteamAccount: 			Table
		Id: 				GUID
		SteamId: 			string
		Username: 			string
		Password: 			string(Encrypted)
		CreatedOn: 			DateTimeOffset
		UpdatedOn: 			DateTimeOffset
		Games: 				virtual List<SteamAccountGame>

	SteamAccountGame: 		Table
		Id: 				GUID
		SteamAccount_Id: 	virtual SteamAccount
		Game_Id: 			virtual Game

	Game: 					Table
		Id: 				GUID
		SteamId: 			string
		Name: 				string
		SteamAccounts: 		virtual List<SteamAccountGames>

Project Decriptions

SteamManager.ApiDataService
	A CLAP Interface tool to run as a scheduled task to import data from the steam api
SteamManager.Client
	Self hosted web api in charge of interacting with steam. Lives on each individual gaming pc as a windows service
SteamManager.Core
	A lightweight library usually used for helpers and static classes(can be used for other stuff, just try to keep it light weight is the important piece)
SteamManager.Core.Test
	UnitTest Project where we test all of our helper classes
SteamManager.Data
	The library used for creating, modifing and deleting data from the database using Entity Framework.
SteamManager.Domain
	A service layer to house your business logic.
SteamManager.Domain.Test
	Unit test project where we test all of our services
SteamManager.Server
	This lives on the webserver and acts as the brains of the system. Has 2 parts, the web api for the clients to communicate to and the UI for admins to manage data.

