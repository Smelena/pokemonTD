using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour {
    // Sun Image
    public Texture sunImage;
	public Texture emptyBoxTexture;



    // Plant Prefabs
    public BuildInfo[] plants;

    // Currently building plant
    public static BuildInfo cur;

	public int numberOfTicks = 0;

	void Start() {

		InvokeRepeating("AddTick", 10, 10);
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

        // Draw the Sun
        //GUILayout.Box(new GUIContent(SunCollect.score.ToString(), sunImage));
		GUILayout.Box(new GUIContent(SunCollect.score.ToString(), sunImage));
		GUILayout.Box(new GUIContent(emptyBoxTexture));
		int iter = -2;
        // Draw each Plant's BuildInfo
        foreach (BuildInfo bi in plants) {
			//GUI.enabled = (numberOfTicks >= (12 + (iter * 12)) && SunCollect.score >= bi.price);
			GUI.enabled = true;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
                cur = bi;
			iter = iter + 1;
        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}