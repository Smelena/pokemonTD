using UnityEngine;
using System.Collections;

public class ElectricityBulletDamage : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
        // enemypoke?

		int damage = 1;

		if (co.tag == "Zombie") {
            // Deal Damage, destroy Bullet
			//WATER

			switch(co.GetComponent<Health>().getType())
			{
				case 1:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 2:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 3:
				co.GetComponent<Health>().doDamage(damage*2);
				break;
				case 4:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 5:
				co.GetComponent<Health>().doDamage(0);
				break;
				case 6:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 7:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 8:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 9:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 10:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 11:
				co.GetComponent<Health>().doDamage(damage*2);
				break;
				case 12:
				co.GetComponent<Health>().doDamage(damage*0.5f);
				break;
				case 13:
				co.GetComponent<Health>().doDamage(damage*0.5f);
				break;
				case 14:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 15:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 16:
				co.GetComponent<Health>().doDamage(damage*0.5f);
				break;
				case 17:
				co.GetComponent<Health>().doDamage(damage);
				break;
				case 18:
				co.GetComponent<Health>().doDamage(damage);
				break;
			}

			Destroy(gameObject);
		}
	}
}