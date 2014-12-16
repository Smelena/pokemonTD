using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour {
    // pokeball Image
    public Texture pokeballImage;
	public Texture emptyBoxTexture;



    // playerpoke Prefabs
    public BuildInfo[] playerpokes;

    // Currently building playerpoke
    public static BuildInfo cur;

	public int numberOfTicks = 0;

	void Start() {

		InvokeRepeating("AddTick", 1, 1);
		print (numberOfTicks);

	}


	public void AddTick() {

		numberOfTicks = numberOfTicks + 1;
		print (numberOfTicks);

	}


    void OnGUI() {
		//print (numberOfTicks);
        // Begin Gui
        GUILayout.BeginArea(new Rect(Screen.width/2 - 350, -7, 700, 200));
        GUILayout.BeginHorizontal("box");

        // Draw the pokeball
        //GUILayout.Box(new GUIContent(pokeballCollect.score.ToString(), pokeballImage));
		GUILayout.Box(new GUIContent(SunCollect.score.ToString(), pokeballImage));
		GUILayout.Box(new GUIContent(emptyBoxTexture));
		int iter = -2;
        // Draw each playerpoke's BuildInfo
        foreach (BuildInfo bi in playerpokes) {
			GUI.enabled = (numberOfTicks >= (105 + (iter * 105)) && SunCollect.score >= bi.price);
			//GUI.enabled = true;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
                cur = bi;
			iter = iter + 1;
        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}