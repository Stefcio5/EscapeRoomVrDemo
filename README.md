# Magic Escape Room VR
## Magic Escape Room will move you to a virtual, magical Escape Room. You will have to solve all the puzzles to get out of it.
![Escape](https://media.giphy.com/media/pPeWqATWuI9DbWi3S3/giphy.gif)

### Movement
In the game, you can move with both real-world movements and teleportation.

![movement](https://media.giphy.com/media/XA86Eo9P90aYowSxzF/giphy.gif)

### Gramophone
An Interactable and an Interactable Event scripts which can be found in the [SteamVR](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647) plugin have been added to the gramophone needle. When a hand approaches the needle, an OnHoverBegin event is triggered, which starts the animation.

![gramophone](https://media.giphy.com/media/K47VBsYo6bPf8ANMxz/giphy.gif)


## Spells
Gesture detection comes from a plug-in from AssetStore ([MiVRy - 3D Gesture Recognition](https://assetstore.unity.com/packages/templates/systems/mivry-3d-gesture-recognition-143176)). When script detects a gesture, a specific spell found in the SpellManager script is activated.

A LaserPointer script is attached to the right hand. You point on the object you want to cast the spell on, and it passes which object is selected and spell works on that object.

### Levitation / Orbit
Using the levitation spell on a planet first reduces its size using the Vector3.Lerp function. It sets the initial and final scale of the object, as well as the shrinking speed.
When the planet finishes shrinking it starts moving in the direction of its orbit. Points are set on the scene for the planet to travel to one by one ( Vector3.MoveTowards). Upon reaching the final point, the planet begins to orbit the sun.

![levi](https://media.giphy.com/media/KdQBkDx5qnZjVMInrt/giphy.gif)

### Lights out

All the lights on the scene are located in one object. When you cast a spell, the game searches for this object and turns it off, so the lights go out. At the same time, the object with the potion recipe is activated.

![recipe](https://cdn.discordapp.com/attachments/690124485113937949/782741468435054612/unknown.png)

### Move spell
You'll have to use this spell on specific object to open a secret passage to another room.

![move](https://media.giphy.com/media/WAaJ32QEd0d9C4U2xB/giphy.gif)

### Potions
In order to find all the planets in the game, the player has to place the correct potions in specific slots as indicated in the recipe. A new potion will be created, that can be used in a secret room.

![closet](https://media.giphy.com/media/wqBS0AsLaWKMs42aFc/giphy.gif)


![potions](https://media.giphy.com/media/NrYJAwnygIjBKqUTnb/giphy.gif)

![bird](https://media.giphy.com/media/1rqtUtT5sH3QpXjojt/giphy.gif)

### Orbiting planets

When all the planets orbit the sun, the game ends. A door opens and a final screen is activated showing the time it took to complete the game.

![orbit](https://media.giphy.com/media/u0iMUHD90ROx5v48ld/giphy.gif)


![endgame](https://media.giphy.com/media/96mWT7292uSHSAwqxv/giphy.gif)

## To do
- Create a camera animation when the last planet is in orbit.
- Add more objects to interact with.
- Improve assets
