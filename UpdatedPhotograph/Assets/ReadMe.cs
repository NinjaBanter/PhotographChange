using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadMe : MonoBehaviour
{
/* This outlines any additional things that will need done once you put these scripts/object into the game.
 * 
 * 1. Variables.
 * 
 * Most of the variables will be assigned via tags, here are the tags that correspond to each Gameobject needing them.
 * -----------------------------------------
 * GameObject - Tag
 * 
 * Player - Player
 * FirstPersonCharacter - MainCamera
 * 
 * Gameobject that starts photograph sequence - PSequence
 * 
 * Wall to vanish - Pwall

 * 
 * The rest of the tags are set up prior, either due to being Prefabs, or children of the object with the script attatched.
 * 
 * This includes the 2 dissolve materials for the photograph and photoframe. The Dissolve Shader which is in this project is also
 * pre assigned.
 * 
 * Dissolve Audio is also pre assigned.
 * ------------------------------------------
 * 
 * 
 * 2. Animation
 * -------------------------------------------
 * The animation for the photograph switch is bespoke, so it will have to be done again for whichever environment we are going to be doing it in.
 * The "PSequence" gameobject will be where the player is centered on when the photograph switch begins. To get an accurate photograph, make the 
 * FPSController a child of the PSequence Gameobject, and center it's location. Then take a screenshot in fullscreen mode, and apply the texture
 * to the photograph Material.
 * -------------------------------------------
 *
 * 3. Buttons
 * ---------------------------------------
 * Add a input button called "Action", with the positive key "e"
 * 
 * 
 * 
 */


}
