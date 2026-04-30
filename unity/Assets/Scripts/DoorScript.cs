using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [HideInInspector] public float numPlayer;
    [SerializeField] float numButton;

    [SerializeField] GameObject manager;
    ManagerScript managerScript;

    void Awake() {
        managerScript = manager.GetComponent<ManagerScript>();
    }

    void Start() {
        numPlayer = 0f;
    }

    void Update() {
        if (numPlayer < numButton) {
            this.GetComponent<Renderer>().enabled = true;
            this.GetComponent<Collider2D>().enabled = true;
        }

        if (numPlayer >= numButton) {
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<Collider2D>().enabled = false;
        }

        if (managerScript.playerId == "0") {
            numPlayer = 0f;
        }
    }
}
