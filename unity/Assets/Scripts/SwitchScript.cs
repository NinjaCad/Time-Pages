using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    bool status;

    [SerializeField] List<GameObject> doors;
    DoorScript doorScript;

    [SerializeField] GameObject manager;
    ManagerScript managerScript;

    void Awake() {
        managerScript = manager.GetComponent<ManagerScript>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        status = false;
    }

    void Update() {
        if (managerScript.playerId == "0") {
            status = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (status == false) {
            status = true;
            for (int i = 0; i < doors.Count; i++) {
                doorScript = doors[i].GetComponent<DoorScript>();
                doorScript.numPlayer += 1;
            }
        } else if (status == true) {
            status = false;
            for (int i = 0; i < doors.Count; i++) {
                doorScript = doors[i].GetComponent<DoorScript>();
                doorScript.numPlayer -= 1;
            }
        }
    }
}
