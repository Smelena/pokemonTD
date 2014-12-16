using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    // Current Health
    [SerializeField]
    float cur = 5;
	[SerializeField]
	int pokeType = 1;
	/**
	 * 1 Normal
	 * 2 Fight
	 * 3 Flying
	 * 4 Poison
	 * 5 Ground
	 * 6 Rock
	 * 7 Bug
	 * 8 Ghost
	 * 9 Steel
	 * 10 Fire
	 * 11 Water
	 * 12 Grass
	 * 13 Electric
	 * 14 Psychic
	 * 15 Ice
	 * 16 Dragon
	 * 17 Dark
	 * 18 Faerie
	**/
	ArrayList positions;

	void OnGUI(){

		string text =cur.ToString() + " hp";
		//GUIDamage.text = text;
		//Instantiate(GUIDamage, Camera.main.WorldToViewportPoint(gameObject.transform.position), Quaternion.identity);
		Vector3 getPixelPos = Camera.main.WorldToScreenPoint( gameObject.transform.position );
		getPixelPos.y = Screen.height - getPixelPos.y - 50f;
		GUIStyle style = new GUIStyle ();
		style.normal.textColor = Color.black;
		GUI.Label( new Rect(getPixelPos.x,getPixelPos.y,100f,100f) , text, style);
		}

    public void doDamage(float n) {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
		if (cur <= 0) {
			if(gameObject.tag == "Plant") {
				//Grass.isFilled = false;
				//grass.setIsFilled(false);
				
				Vector3 position = gameObject.transform.position;
				if(GrassCellFill.getPostionList().Contains(position)) {
					GrassCellFill.rem(position);
				}
				
				Destroy (gameObject);
			}
			else {
				Destroy (gameObject);
			}
		}
    }
	public int getType() {
		return pokeType;
		}
}