using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBNormalScript : MonoBehaviour
{
    
    Rigidbody2D rigidbody2d;

    [SerializeField] GameObject playerA;
    PlayerANormalScript playerANormalScript;
    
    [HideInInspector] public Vector3 position;

    bool rewinding;

    void Awake() {
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerANormalScript = playerA.GetComponent<PlayerANormalScript>();
    }
    
    void Start() {
        transform.position = playerA.transform.position;
        position = transform.position;
        rewinding = false;
    }

    void FixedUpdate() {

    }

    void Update() {
        if (playerANormalScript.managerScript.playerId != playerANormalScript.id && playerANormalScript.managerScript.playerId != "0" && rewinding == false && playerANormalScript.record.Count > 0) {
            rewinding = true;
            StartCoroutine("Rewind");
        }

        if (playerANormalScript.managerScript.playerId == "0") {
            rewinding = false;
            transform.position = position;
        }
    }

    IEnumerator Rewind () {
        for (int i = 0; i < playerANormalScript.record.Count; i += 2) {
            rigidbody2d.velocity = new Vector2(playerANormalScript.record[i], playerANormalScript.record[i + 1]);
            yield return new WaitForFixedUpdate();
        }
    }
}
