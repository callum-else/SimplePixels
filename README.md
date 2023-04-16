# SimplePixels
SimplePixels is a simplified and packaged version of the Pixelation Image Effect created by Dmitry Timofeev. The original asset can be found on the Unity Asset Store [here](https://assetstore.unity.com/packages/vfx/shaders/fullscreen-camera-effects/pixelation-65554).

I've been using and loving this asset for a long time, but the original file structure and namespace usage leaves a lot to be desired. That, along with the fact that it doesn't import as a package separate from your assets, led me to create this.

# What's Changed?
In this package, only the Pixelation effect has been included, as it was the only effect from the original that I found myself using. This includes removing all the test and demo scenes, leaving this package as a lightweight alternative.

Due to the removal of all other effects, the Pixelation component has been flattened to one script, no longer requiring it's inherited base class. 

Furthermore, there is now no longer a need to attach the Pixelation shader its corresponding component in the inspector, as it is found and assigned for you.

# Using this effect
1. Open the camera object you wish to pixelate and select "Add Component".
2. Search for "CameraPixelator", or alternatively select "Image Effects" -> "CameraPixelator" from the menu.
3. Once the script is added, you can adjust the number of pixel blocks by modifying the "Block Count" parameter in the script's settings. The higher the count, the smaller the pixels.

# Importing this package
1. Click on the green "Code" button above this readme.
2. In the dropdown menu, select "HTTPS" if it's not already selected.
3. Click on the "Copy" button to copy the URL to your clipboard.
4. Go back to Unity and open the Package Manager by going to "Window" -> "Package Manager".
5. Click on the "+" button in the top left corner and select "Add package from git URL".
6. Paste the URL you copied from GitHub into the "Git URL" field and click "Add".
7. Unity will download and import the package into your project.

Note that the specific steps may vary depending on the version of Unity you're using. You can refer to the Unity documentation for more information on importing packages.
