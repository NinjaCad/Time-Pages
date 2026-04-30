using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    Vector3 position;

    [SerializeField] GameObject manager;
    ManagerScript managerScript;

    void Awake() {
        managerScript = manager.GetComponent<ManagerScript>();
    }

    void Start() {
        position = transform.position;
    }

    void Update() {
         if (managerScript.playerId == "0") {
            transform.position = position;
        }
    }
}
