using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour {
    // Sun Image
    public Texture sunImage;

    // Plant Prefabs
    public BuildInfo[] plants;

    // Currently building plant
    public static BuildInfo cur;

    void OnGUI() {
        // Begin Gui
        GUILayout.BeginArea(new Rect(Screen.width/2 - 100, -7, 200, 100));
        GUILayout.BeginHorizontal("box");

        // Draw the Sun
        GUILayout.Box(new GUIContent(SunCollect.score.ToString(), sunImage));

        // Draw each Plant's BuildInfo
        foreach (BuildInfo bi in plants) {
            GUI.enabled = SunCollect.score >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
                cur = bi;
        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}