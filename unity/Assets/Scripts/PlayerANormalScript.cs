using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerANormalScript : MonoBehaviour
{
    public string id;
    float moveSpeed;
    float velocityX;
    float velocityY;
    bool clear;

    [HideInInspector] public List<float> record;

    Vector3 position;

    Rigidbody2D rigidbody2d;

    public GameObject manager;
    [HideInInspector] public ManagerScript managerScript;

    void Awake() {
        rigidbody2d = GetComponent<Rigidbody2D>();
        managerScript = manager.GetComponent<ManagerScript>();
    }

    void Start() {
        moveSpeed = 7.5f;
        position = transform.position;
        record = new List<float>();
        clear = true;
    }

    void Update() {
        if (id == managerScript.playerId) {
            velocityX = Input.GetAxis("Horizontal") * moveSpeed;
            velocityY = Input.GetAxis("Vertical") * moveSpeed;
        }

        if (managerScript.playerId == "0") {
            velocityX = velocityY = 0f;
            transform.position = position;
            clear = true;
        }

        if (id == managerScript.playerId && record.Count > 0 && clear == true) {
            record.Clear();
            clear = false;
        }
    }

    void FixedUpdate() {
        if (record.Count <= 6000) {
            if (id == managerScript.playerId) {
                record.Add(velocityX);
                record.Add(velocityY);
            }
        }
        if (id == managerScript.playerId && record.Count >= 6000 && clear == false) {
            managerScript.playerId = "0";
        }

        rigidbody2d.velocity = new Vector2(velocityX, velocityY);
        
    }
}
