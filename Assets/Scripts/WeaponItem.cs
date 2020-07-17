using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponItem : MonoBehaviour
{
    [SerializeField] Inventar inventar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inventar.GetComponent<Text>().text += "\nPicked a: " + gameObject.name;
        Destroy(gameObject);
    }
   

}
