Basically emulates the "Play From Here" functionality of the Unreal Engine Editor. But for Unity!
What the editor script does is when we hit Play, first we save the position of the SceneView camera.
Then the GameDataScript gets that position and sets the player's position to it on Start.

Effectively, wherever you leave the scene camera is where you will drop into the map with your player.


*** Just make sure you drop the UpdatePlayerStartPosition script into a "Editor" folder just inside your Assets folder. ***
*** You can also toggle the public boolean if you want to turn off this feature at anytime. ***
