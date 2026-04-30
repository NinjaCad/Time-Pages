using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerADashScript : MonoBehaviour
{
    public string id;
    float moveSpeed;
    float velocityX;
    float velocityY;
    bool clear;
    float dashTimer;

    [HideInInspector] public List<float> record;
    [HideInInspector] public List<float> ignoreCollision;

    Vector3 position;

    Rigidbody2D rigidbody2d;

    public GameObject manager;
    [HideInInspector] public ManagerScript managerScript;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        managerScript = manager.GetComponent<ManagerScript>();
    }

    void Start()
    {
        moveSpeed = 7.5f;
        position = transform.position;
        record = new List<float>();
        clear = true;
        dashTimer = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown("left shift") && (velocityX != 0 || velocityY != 0)) {
            dashTimer = 0.15f;
        }

        if (id == managerScript.playerId && dashTimer <= 0f)
        {
            moveSpeed = 7.5f;
            velocityX = Input.GetAxis("Horizontal");
            velocityY = Input.GetAxis("Vertical");
        }

        if (managerScript.playerId == "0")
        {
            velocityX = velocityY = 0f;
            transform.position = position;
            clear = true;
        }

        if (id == managerScript.playerId && record.Count > 0 && clear == true)
        {
            record.Clear();
            clear = false;
        }

        if (id == managerScript.playerId && record.Count >= 6000 && clear == false)
        {
            managerScript.playerId = "0";
        }
    }

    void FixedUpdate()
    {
        if (record.Count <= 6000)
        {
            if (id == managerScript.playerId)
            {
                record.Add(velocityX * moveSpeed);
                record.Add(velocityY * moveSpeed);

                if (dashTimer > 0)
                {
                    dashTimer -= Time.deltaTime;
                    moveSpeed = 30f;

                    for (int i = 0; i < managerScript.ignoreDash.Count; i++)
                    {
                        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), managerScript.ignoreDash[i].GetComponent<Collider2D>(), true);
                        ignoreCollision.Add(1);
                    }
                    for (int i = 0; i < managerScript.dashObjects.Count; i++)
                    {
                        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), managerScript.dashObjects[i].GetComponent<Collider2D>(), true);
                    }

                    if (velocityX > 0)
                    {
                        velocityX = Mathf.Ceil(velocityX);
                    }
                    else
                    {
                        velocityX = Mathf.Floor(velocityX);
                    }
                    if (velocityY > 0)
                    {
                        velocityY = Mathf.Ceil(velocityY);
                    }
                    else
                    {
                        velocityY = Mathf.Floor(velocityY);
                    }
                }
                else
                {
                    for (int i = 0; i < managerScript.ignoreDash.Count; i++)
                    {
                        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), managerScript.ignoreDash[i].GetComponent<Collider2D>(), false);
                        ignoreCollision.Add(0);
                    }
                    for (int i = 0; i < managerScript.dashObjects.Count; i++)
                    {
                        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), managerScript.dashObjects[i].GetComponent<Collider2D>(), false);
                    }
                }
            }
        }

        rigidbody2d.velocity = new Vector2(velocityX * moveSpeed, velocityY * moveSpeed);
    }
}
