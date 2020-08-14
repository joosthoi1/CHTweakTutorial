Hello fellow coder, hopefully this repo will help you start to make a clone hero tweak!

### Helpful resources:
* Clone hero modding discord: https://discord.me/cloneheromodding  
This discord has a bunch of people willing to help you get on your way with clone hero modding and know much more than me :P
* biendeo's tweak repo: https://github.com/Biendeo/My-Clone-Hero-Tweaks  
I suggest checking out at least some of his tweaks in code, especially if you want to access game variables. He has wrappers for some of the game code in common/wrappers.
* DnSpy: https://github.com/0xd4d/dnSpy  
If you want access to game variables and functions you'll need this to view the game code. (People on the discord can help https://discord.me/cloneheromodding)
* The Unity Scripting Refrence: https://docs.unity3d.com/ScriptReference/
Especially if your not a Unity expert this is your friend.
* My own tweak repo: https://github.com/joosthoi1/Joost-tweaks  
My tweaks basically use biendeo's tweaks as a template so not quite as useful as his lol  

### How to get started:
1. Install Clone Hero and CHLoader. (CHLoader can be found on the clone hero modding discord)
2. Patch Clone Hero with CHLoader. (Should be pretty straight forward, but for help, check the discord)
3. Create a .net framework 4.X (I use 4.7.2 but any for 4.X version should work) project and set the output type to class library. (I suggest using Visual Studio)
4. Refrence UnityEngine.dll (Can be found in your clone hero folders under "Clone Hero_Data\Managed") and any other UnityEngine DLL's your project needs. (This can be done later aswell)
5. Create your main tweak class which needs to inherit MonoBehaviour (I usually call it the same as the solution).
6. Create a Loader class with the template provided (make sure to replace YourTweak with whatever you called the class in the previous step). This is the code to load your tweak. (Usually this code doesn't need to be altered, only if you do or don't want to use Biendeo's code wrappers)
7. Now you are ready to create your tweak. You can use Unity methods just like you would in any other Unity script.
8. Build your solution and put the DLL of your tweak in the Clone Hero tweak folder.
