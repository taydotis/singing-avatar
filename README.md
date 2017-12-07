# Singing Avatar

**Video Walkthrough** - https://www.youtube.com/watch?v=aONY4vpco0I

## User Overview:

**Interface** - There is no interface for the users to set options for the program itself. As per the request of the mentors and for ease of finding the correct versions of the program, each version of the avatar has its own build, or program executable, organized into labeled folders. All that needs to be done to play the program is to click on the executable to run it.

**Purpose** - The purpose of this project is to give a standard research stimulus to be shown to participants with minimal user interaction. The experimenter will be able to choose options for the specific stimulus shown, but during the stimulus, the avatar singing, the background should have minimal distraction and the user should have minimal interaction and navigation to maintain experimental control.

## Read Me:

**Installation** - In order to open the project or run a specific build, you will need to download the files in the repository linked above. You should be able to open the “Unity” subfolder as a project in Unity, or click through the “Builds” subfolders until you find the appropriate build for your experiment. If the build does not want to run on the Oculus Rift, you may need to download their latest software here: https://www.oculus.com/setup/

**Development Environment** - The development environments used are Unity and Blender. Blender was used to create the singing avatar asset. No imported models were used to create the avatar. Unity was used to animate the avatar and add sound and a background.

**Hardware/Software Specifications** -  Unity version/Oculus, talk about controllers, graphics card

**Warnings** - 

## Future Developer:

**Build** - The project should have one build for each experiment type. Currently there are eight builds corresponding to the combinations of hair type (long/short), song tempo (Temporally Regular / Irregular) and song melody (Familiar/Unfamiliar). To set the experiment variables before building, simply change the audio source component, the hair shape key values, and the animator transition state to the correct values. To build the project, you should first enable VR in the Unity player settings, and then build for the appropriate platform (Windows, Mac, etc).

**Scenes** - The project contains a single simple scene to house the singing avatar. The environment in the scene should be as neutral as possible.

**Assets** - The assets in this project consist of a background environment and the avatar. The background was imported from the Unity asset store. The avatar was created using Blender. The avatar is a combination of meshes for the head, eyes, arms and torso, and legs. In order to animate the avatar, shape keys were created for the different movements in Blender, such as blinking and opening it’s mouth. Only the syllable “la” was animated based on the original needs of the mentors. Different shape keys can be created to add more syllables to what the avatar can appear to say. Coloring and texturing of the avatar is saved in the .jpg files included in the project folder. Modifications should be saved there.

**Scripts** - The Songscript file controls the playing of avatar singing audio. It contains the function playAudio() which can be triggered via animation events (like the beginning of a singing animation).

## Mentor Section:

We created an avatar, made with Blender, that is synced to the song files you gave us. Upon running our build, you will be able to choose different options for the avatar and run, such as avatar gender, song that it will sing, and whether it has eyebrow movements. This avatar can be presented for participants to sing along with instead of having a person do so during the experiment, allowing for more experimental control in the design of the research and reducing the confound of experimenter bias.

**Video Walkthrough** - https://www.youtube.com/watch?v=aONY4vpco0I
