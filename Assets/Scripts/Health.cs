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

    public void doDamage(float n) {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0)
            Destroy(gameObject);
    }
	public int getType() {
		return pokeType;
		}
}