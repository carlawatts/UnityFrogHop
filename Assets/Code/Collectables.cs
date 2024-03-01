using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
	[SerializeField] string itemName;
    void OnTriggerEnter(Collider other) {
		Managers.Inventory.AddItem(itemName);
		Destroy(this.gameObject);
	}
}

