using UnityEngine;
using System.Collections;

public class character : MonoBehaviour
{
	public int hp;
	public int cooldown;
	public int damage;
	private float lastAttack;
	private bool hasEnemy;
	// Use this for initialization
	void Start ()
	{
		hasEnemy = false; //never has an enemy to start with;
	}
	
	// Update is called once per frame
	void Update ()
	{
			if (hasEnemy) {//TODO: Detect enemy
					if ((Time.time - lastAttack) >= 10000) {
							//TODO: attack
							lastAttack = Time.time; //if attack set time to now
					}
			}
	}
	//attack if there is an Enemy
	void Attack ()
	{
		
	}

}
