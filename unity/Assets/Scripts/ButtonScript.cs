using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] List<GameObject> doors;
    DoorScript doorScript;
    
    void OnTriggerEnter2D(Collider2D col) {
        for (int i = 0; i < doors.Count; i++) {
            doorScript = doors[i].GetComponent<DoorScript>();
            doorScript.numPlayer += 1;
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        for (int i = 0; i < doors.Count; i++) {
            doorScript = doors[i].GetComponent<DoorScript>();
            doorScript.numPlayer -= 1;
        }
    }
}
