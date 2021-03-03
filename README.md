# Advikit-Plays
This project allows you to integrate Glimesh chat to interact with a game/process as part of the Advikit suite.


## Setting Up
This project hooks into Win32 APIs so running on a Windows machine is required.  
The project relies on this wrapper: https://github.com/jasonpang/Interceptor  
Follow these steps to set this up:  
1. Go to https://github.com/oblitum/interception/releases/tag/v1.0.1 and download the .zip
2. Extract the zip.
3. Run "command line installer/install-interception.exe" as admin
4. Place "library/x64/interception.dll" in the same directory as the Advikit-Plays binary.
5. You may need to restart your PC, not sure.

## Configuration
As this project only reads chat messages (and doesn't send), only a client_id is required. You can get one by creating a new application at https://glimesh.tv/users/settings/applications  
Create an application and copy the client_id into the "Settngs" tab of this project.  
Insert your channel ID (not username) into the "Settings" tab of this project. You can find your channel ID by:
1. Visit https://glimesh.tv/api
2. Insert the following query (replace USERNAME with your username):  
```
query {
user (username: "USERNAME"){
username,
id}
}
```
3. Run the query and it should return your channel ID.

## Adding Games
This project is somewhat modular so each game will be its own class in the /Games directory. I've included an example one named "Peggle.cs". I believe it's mostly self-explanatory but I'll go through a few of the key steps.  
Taking a look at constructor:  
```
public Peggle(ChatWebsocket cws, MainForm form) {
			this.cws = cws;
			this.form = form;
			if (FindTarget("popcapgame1")) { //Process name or window title
				chatCommands = new Dictionary<string, Action>
				{
					{ "left", () => MoveLeft() }, // Add chat command "left" to call the MoveLeft() function defined below
					{ "light left", () => MoveLittleLeft() },

					{ "right", () => MoveRight() },
					{ "light right", () => MoveLittleRight() },

					{ "up", () => MoveUp() },
					{ "down", () => MoveDown() },

					{ "shoot", () => Shoot() }
				};

				this.cws = cws;
				log("Loaded commands: " + String.Join(", ", chatCommands.Keys.ToArray()));
				for (int i = 5; i > 0; i--) {
					System.Threading.Thread.Sleep(1000);
					log("Starting in " + i.ToString() + " seconds.");
				}
				log("Chat commands are active.");
				this.cws.NewMessage += HandleMessage;
			}
		}
```
 ```if (FindTarget("popcapgame1")) {``` finds the Windows process with the name "popcapgame1". This can be found by looking in task manager. The "FindTarget" method also accepts a Windows title. 
 The chatCommands dictionary contains a mapping between commands and methods to execute. For example:  
 ```{ "left", () => MoveLeft() }``` means any time a chat message with the text "left" (case-insensitive) is sent, execute the MoveLeft() function defined lower in the class.  
 The MoveLeft() function is defined as:
 ```
  public void MoveLeft() {
		MoveMouse(-50, 0, true);
  }
 ```
 which calls the MoveMouse function from the super class (Controller.cs) to move the mouse left by 50 and is bounded by the process window (to ensure the mouse doesn't leave the game/process).  
 
 The Controller class offers three controls: MoveMouse(x, y, bounded), LeftClick(), and RightClick() which should cover the majority of uses. But you can implement your own as well.
 
 The "Games" tab of the project loads games based on their class name so name them appropriately.  
 
 ## Using the program
 1. Insert client ID and channel ID in the "Settings" tab (these will save after inputting).
 2. Click "Connect to Chat" on the "Chat" tab. This will create a websocket connection subscribing to messages of the channel ID you set in step 1. If successful, the button text will change to "Connected" and websocket responses will print out in the console log.
 3. In the "Games" tab, select the game you want to start from the dropdown and click "Activate".
 4. Things might break (or they might not!).
 
