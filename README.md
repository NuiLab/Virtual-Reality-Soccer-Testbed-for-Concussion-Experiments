# Soccer_Kinect
A Virtual environment to test task performance capabilities of athletes suffering from Sports Related Concussion.

### Project creation log.

1. Understanding the virtual reality mode of unreal engine and creating GitHub repository. 
  * Watched some videos on YouTube \[[1](https://www.youtube.com/watch?v=1PTTuZ_F8Nk)\] \[[2](https://www.youtube.com/watch?v=htwW_Xf0hDM)\]
  * \[[2](https://www.youtube.com/watch?v=htwW_Xf0hDM)\] video explained a new feature which I did not know, VR editor. This thing is cool! The whole editor is given in VR headset and you can use the VR controllers to interact and edit the environment similar to how you would do in a normal editor. Plus point is you can move around in 3D world and see how it would look in real life. But video didn't specify if we can access blueprints there.
  * Created GitHub repository to keep track of progress. First created the repository online. After committing the log pulled the repository on the computer.

2. Adding soccer assets
 * Added all the necessary assets of soccer.
 * Understood all the pre-loaded components of the Unreal editor.
 * Adapted the components for the soccer field.
 * Added soccer ball as a VR object.

3. Creating **Full Body** avatar
 * \[[3](https://www.youtube.com/watch?v=EKR8ogonD68&feature=youtu.be)\] gave an amazing demo about how to create touchpad controls on motion controller and fix camera to the head so that we can have a full body avatar.
 * **Note:** Simulator sickness is a real thing and way worse than what I imagined.

4. Adding Kick ability
 * Created animation for kick by editing walking animation.
 * Force applied on the ball channel using line-trace.
 * Adjusted the start and end points of the force so that it starts from the feet and end 1 meters in front (necessary right now without proper body mapping).
 * Added Teleportation ability so that necessity for touchpad movement is low (spawning two hands each because teleportation ability is not coded for motion controller component).
 * **Note:** Simulator sickness didn't effect as much as last time. Maybe I'm getting used to it or addition of teleportation has helped.
 * Quick update: Added sound to the kick when line-trace hits the ball.

### Continued from previous [project](https://github.com/adirar/CTE_Soccer)

5. Removed all controller movement
 * With the approach change the controllers are no longer needed.
 * I might add them later just to add extended player movement.

6. Understanding Kinect4Unreal
 * \[[4](https://www.opaque.media/kinect-4-unreal)\] have given an api for connecting Microsoft Kinect with Unreal Engine 4.
 * They have a [YouTube Page](https://www.youtube.com/user/OpaqueMultimedia/featured) which has videos on how to setup the project.
 * The videos are little outdated so you will have to figure out some changes on your own.
 * They have a whole project that you can download. In that they have added 3 types of pawns which communicate with the Kinect in different ways.

7. Creating a character
 * Added the same functionality to a character so that we can posses the body and port real world movements to the virtual world.
 * Fixing the camera to head to make it First Person View.

8. Adding VR capabilities
 * Tried connecting the VR hedset with Kinect presented with a new set of problems.
 * The camera always sticks to the chest and looking up. This is the origin point of the mesh.
 * No matter what I tried I could not change it.

9. Spawning ball
 * Holding off on VR I created 3 Donut shaped Blueprint pawns which can spawn a ball.
 * The balls are spawn in certain intervals (can be changed).
 * A projected prjectile line is drawn 0.5 seconds before the ball is fired. To divert the attention of the player to that Donut.
 * Finally the ball is shot towards the player which make one bounce before reaching them.
 * Cannot kick the ball as the collision mesh is a capsule.

10. Changing character to actor
 * Changing to actor removed the capsule collision mesh.
 * This way the ball passed right through me. Although this is problematic it solved one problem that when I lifted my legs it didn't stop like before.

11. Adding custom collision mesh
 * With all the collision mesh removed I added small capsule and box collision on individual parts of the body like different collision bounds on thigh bones, calf bones and all other bones.
 * Set the collision to "block all"
 * Because of this now I can kick the ball.
 * The collisons are still in primary stage and with very few vertices. More vertices with give more accurate collision bounds which will make kicking more realistic.

12. VR + Kinect and Movement
 * Changed the VR headset from HTC Vive Pro to Oculus Rift due to IR interference issues.
 * Made the character map exactly to my body (specifically height)
 * Added movement capability, problem: can't look down as the movement is being maped to the headset.
 * Learned about moving the origin(can only be done in level design not mesh design) and will be useful in future.
 
13. Levels, proper body movements, save to file
 * Created 3 levels
  1. Evade incoming player: In this task opponents will spawn and start running at the subject. The subject has to move out of the way so as to not crash into the opponent players. There will be a player a soccer ball and the subject has to tackle that player. This is important for Level 2 and 3 where there may be a follow-up task.
  2. Pass to player: In this task players will spawn periodically, and subject’s task is to pass the ball (which will spawn close to his/her leg) to the player. The position of the player is able to change. The condition to change the section is either through timeout of a set time or attempt at the target.
  3. Shoot at goal: In this task subject will have a soccer ball spawn near his/her leg. There will be a goal with 4 sections. Initially all sections will be red tinted. Periodically each one will turn transparent. This is the section person is supposed to shoot the ball. The condition to change the section is either through timeout of a set time or attempting a shot at the target.
 * Separated head and body. Head is tracked by HMD, body is tracked by position of one of the controller. This fixed the own body occlusion problem.
 * Added functionality to read from and write to file. Gives problem with Kinect 4 Unreal plugin. Temporarily removing the plugin and adding it after compiling C++ code fixes the problem.

14. Soccer player avatar and Demo ready project
 * Added Soccer player avatar. Movements are better than Mannequin.
 * Fixed minor issues. One of them was while running the program the axis will shift slightly which gave terrible cyber sickness since the XY mapping was all wrong. Solution is to restart the program.
 * Cloned the repo to store for Demos.

15. 2 new levels added
 * Evade + Pass: Evade incoming players and tackle the player with the ball. After successful tackle pass to player
 * Evade + Pass: Evade incoming players and tackle the player with the ball. After successful tackle Shoot at goal
 
16. Opponent Avatar and Progress bar
 * Changed opponent players avatar from Mannequin to humans. Male working for everything. Problem with still Female.
 * Added score tracking for 1 task levels.

17. Height and avatar selection
 * Height is selected automatically on the start level.
 * Left and Right on controller joystick will switch between male and female players.

18. New scoreboards added and practice levels created
 * 3 new scoreboards added for practice levels with fewer trials and existing scoreboards changed to handle more attempts.
 * 3 practice levels added for training the participants to get used to the environment and controls.
 
 ### Notes:
 1. All the files are present except the content that can be downloaded from the web. 
 2. Different levels are stored in "Levels" folder. Different levels are described in point 13.
 3. The Character pawns are in "Character_BP" folder. Their Skeleton Meshes are in "Mannequin/Skeleton_Mesh" folder.
 4. Other Blueprint classes needed are in "Blueprints" folder.
 5. To start the demo
  * Connect Oculus Rift/Rift S and microsoft Kinect 2 (Assuming all drivers and SDK are present).
  * Start Oculus app.
  * Open any level.
  * Select VR preview mode.
  * Place the headset on the ground facing kinect. 
  * Press 'R' key to reset the orientation.
  * Put on the headset and enjoy
  * Evade and Pass levels need 'T' key press to start spawning the players.
