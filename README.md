RiseOfThePharaohLevelEditor
===========================

Rise of the Pharaoh Level Editor

This is the level editor I created for Rise of the Pharaoh. It is a GUI coded in C#. 
When you first open the program, the first screen to pop up is the main screen. 
The main screen allows you to load a previously made file and add more to that file or you could make a new level. 
It also has a "Clear" button that clears the textbox on the screen. The "Quit" button quits the program.
By creating a new level, you are brought to the "New File" screen. This screen wants you to name this new file. 
You have the option of pressing cancel and going back to the main screen. 
After either successfully loading a file on the main screen or creating a new file on the "New File" screen, 
you are brought to the "Level Editor" screen. 
The main feature of this page is the picturebox that shows a .5 scale version of a game level. 
If load was chosen as the path to get to this screen, the picture box would have all the platforms 
and enemies on the screen. The player and end door are not able to be placed in the level editor. 
If one did not choose to load a level, the screen above is what they would see. 
There are buttons to place a new platform ("Make New Tile"), 
enemy ("Make New Enemy"), walking enemy ("Make New Walking Enemy") and a trap ("Make New Trap"). 
The buttons that are unclickable before choosing an item to place on the screen become clickable 
after placing an item to the screen. That new item then needs to be placed ("Place Tile") 
before the buttons revert to the state they began in. Before placing the tile and after putting it on the screen, 
you can move it with either the "Up", "Right", "Down", or "Left" buttons. 
Or you can choose to type in coordinates in the "Loc. X" and "Loc. Y" textboxes. 
When done, the "Save n Return to Menu" button writes out the file to a txt containing 
all the coordinates of the items on the screen. 

Written in C#. May 2012.

By, Natasha Martinez
