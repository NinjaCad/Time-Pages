using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBDashScript : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    [SerializeField] GameObject playerA;
    PlayerADashScript playerADashScript;

    [HideInInspector] public Vector3 position;

    bool rewinding;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerADashScript = playerA.GetComponent<PlayerADashScript>();
    }

    void Start()
    {
        transform.position = playerA.transform.position;
        position = transform.position;
        rewinding = false;
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        if (playerADashScript.managerScript.playerId != playerADashScript.id && playerADashScript.managerScript.playerId != "0" && rewinding == false && playerADashScript.record.Count > 0)
        {
            rewinding = true;
            StartCoroutine("Rewind");
        }

        if (playerADashScript.managerScript.playerId == "0")
        {
            rewinding = false;
            transform.position = position;
        }
    }

    IEnumerator Rewind()
    {
        for (int i = 0; i < playerADashScript.record.Count; i += 2)
        {
            rigidbody2d.velocity = new Vector2(playerADashScript.record[i], playerADashScript.record[i + 1]);

            if (playerADashScript.ignoreCollision[i/2] == 1)
            {
                for (int j = 0; j < playerADashScript.managerScript.ignoreDash.Count; j++)
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), playerADashScript.managerScript.ignoreDash[j].GetComponent<Collider2D>(), true);
                }
                for (int j = 0; j < playerADashScript.managerScript.dashObjects.Count; j++)
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), playerADashScript.managerScript.dashObjects[j].GetComponent<Collider2D>(), true);
                }
            } else
            {
                for(int j = 0; j < playerADashScript.managerScript.ignoreDash.Count; j++)
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), playerADashScript.managerScript.ignoreDash[j].GetComponent<Collider2D>(), false);
                }
                for (int j = 0; j < playerADashScript.managerScript.dashObjects.Count; j++)
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), playerADashScript.managerScript.dashObjects[j].GetComponent<Collider2D>(), false);
                }
            }
            yield return new WaitForFixedUpdate();
        }
    }
}
