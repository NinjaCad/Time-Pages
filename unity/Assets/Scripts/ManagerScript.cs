using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    [HideInInspector] public string playerId;
    [HideInInspector] public float globalPlayerButton;

    [SerializeField] List<GameObject> playerA;
    [SerializeField] List<GameObject> playerB;
    public List<GameObject> ignoreDash;
    public List<GameObject> dashObjects;

    void Start() {
        playerId = "0";
        globalPlayerButton = 0f;

        if (playerA.Count >= 1 && playerA.Count == playerB.Count && playerA.Count >= 1) {
            playerA[0].GetComponent<Renderer>().enabled = true;
            playerA[0].GetComponent<Collider2D>().enabled = true;
            playerB[0].GetComponent<Renderer>().enabled = false;
            playerB[0].GetComponent<Collider2D>().enabled = false;
            
            if (playerA.Count >= 2) {
                playerA[1].GetComponent<Renderer>().enabled = true;
                playerA[1].GetComponent<Collider2D>().enabled = true;
                playerB[1].GetComponent<Renderer>().enabled = false;
                playerB[1].GetComponent<Collider2D>().enabled = false;

                Physics2D.IgnoreCollision(playerA[1].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                Physics2D.IgnoreCollision(playerB[1].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);

                Physics2D.IgnoreCollision(playerA[1].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                Physics2D.IgnoreCollision(playerB[1].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);

                if (playerA.Count >= 3) {
                    playerA[2].GetComponent<Renderer>().enabled = true;
                    playerA[2].GetComponent<Collider2D>().enabled = true;
                    playerB[2].GetComponent<Renderer>().enabled = false;
                    playerB[2].GetComponent<Collider2D>().enabled = false;

                    Physics2D.IgnoreCollision(playerA[2].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerA[2].GetComponent<Collider2D>(), playerB[1].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerB[2].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerB[2].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                    
                    Physics2D.IgnoreCollision(playerA[2].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerA[2].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerB[2].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                    Physics2D.IgnoreCollision(playerB[2].GetComponent<Collider2D>(), playerB[1].GetComponent<Collider2D>(), true);

                    if (playerA.Count >= 4) {
                        playerA[3].GetComponent<Renderer>().enabled = true;
                        playerA[3].GetComponent<Collider2D>().enabled = true;
                        playerB[3].GetComponent<Renderer>().enabled = false;
                        playerB[3].GetComponent<Collider2D>().enabled = false;

                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerB[1].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerB[2].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[2].GetComponent<Collider2D>(), true);

                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerA[3].GetComponent<Collider2D>(), playerA[2].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                        Physics2D.IgnoreCollision(playerB[3].GetComponent<Collider2D>(), playerA[2].GetComponent<Collider2D>(), true);

                        if (playerA.Count >= 5) {
                            playerA[4].GetComponent<Renderer>().enabled = true;
                            playerA[4].GetComponent<Collider2D>().enabled = true;
                            playerB[4].GetComponent<Renderer>().enabled = false;
                            playerB[4].GetComponent<Collider2D>().enabled = false;

                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerB[1].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerB[2].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerB[3].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerA[2].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerA[3].GetComponent<Collider2D>(), true);

                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerA[0].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerA[1].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerA[2].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerA[4].GetComponent<Collider2D>(), playerA[3].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerB[0].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerB[1].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerB[2].GetComponent<Collider2D>(), true);
                            Physics2D.IgnoreCollision(playerB[4].GetComponent<Collider2D>(), playerB[3].GetComponent<Collider2D>(), true);
                        }
                    }
                }
            }
        }
    }

    void Update() {
        if (playerId == "0" && playerA.Count == playerB.Count && playerA.Count >= 1) {
            if (Input.GetKeyDown("1") && playerA.Count >= 1) {
                playerId = "1";

                if (playerA.Count >= 1) {
                    playerA[0].GetComponent<Renderer>().enabled = true;
                    playerA[0].GetComponent<Collider2D>().enabled = true;
                    playerB[0].GetComponent<Renderer>().enabled = false;
                    playerB[0].GetComponent<Collider2D>().enabled = false;

                    if (playerA.Count >= 2) {
                        playerA[1].GetComponent<Renderer>().enabled = false;
                        playerA[1].GetComponent<Collider2D>().enabled = false;
                        playerB[1].GetComponent<Renderer>().enabled = true;
                        playerB[1].GetComponent<Collider2D>().enabled = true;

                        if (playerA.Count >= 3) {
                            playerA[2].GetComponent<Renderer>().enabled = false;
                            playerA[2].GetComponent<Collider2D>().enabled = false;
                            playerB[2].GetComponent<Renderer>().enabled = true;
                            playerB[2].GetComponent<Collider2D>().enabled = true;

                            if (playerA.Count >= 4) {
                                playerA[3].GetComponent<Renderer>().enabled = false;
                                playerA[3].GetComponent<Collider2D>().enabled = false;
                                playerB[3].GetComponent<Renderer>().enabled = true;
                                playerB[3].GetComponent<Collider2D>().enabled = true;

                                if (playerA.Count >= 5) {
                                    playerA[4].GetComponent<Renderer>().enabled = false;
                                    playerA[4].GetComponent<Collider2D>().enabled = false;
                                    playerB[4].GetComponent<Renderer>().enabled = true;
                                    playerB[4].GetComponent<Collider2D>().enabled = true;
                                }
                            }
                        }
                    } 
                }
            }
            if (Input.GetKeyDown("2") && playerA.Count >= 2) {
                playerId = "2";

                if (playerA.Count >= 1) {
                    playerA[0].GetComponent<Renderer>().enabled = false;
                    playerA[0].GetComponent<Collider2D>().enabled = false;
                    playerB[0].GetComponent<Renderer>().enabled = true;
                    playerB[0].GetComponent<Collider2D>().enabled = true;

                    if (playerA.Count >= 2) {
                        playerA[1].GetComponent<Renderer>().enabled = true;
                        playerA[1].GetComponent<Collider2D>().enabled = true;
                        playerB[1].GetComponent<Renderer>().enabled = false;
                        playerB[1].GetComponent<Collider2D>().enabled = false;

                        if (playerA.Count >= 3) {
                            playerA[2].GetComponent<Renderer>().enabled = false;
                            playerA[2].GetComponent<Collider2D>().enabled = false;
                            playerB[2].GetComponent<Renderer>().enabled = true;
                            playerB[2].GetComponent<Collider2D>().enabled = true;

                            if (playerA.Count >= 4) {
                                playerA[3].GetComponent<Renderer>().enabled = false;
                                playerA[3].GetComponent<Collider2D>().enabled = false;
                                playerB[3].GetComponent<Renderer>().enabled = true;
                                playerB[3].GetComponent<Collider2D>().enabled = true;

                                if (playerA.Count >= 5) {
                                    playerA[4].GetComponent<Renderer>().enabled = false;
                                    playerA[4].GetComponent<Collider2D>().enabled = false;
                                    playerB[4].GetComponent<Renderer>().enabled = true;
                                    playerB[4].GetComponent<Collider2D>().enabled = true;
                                }
                            }
                        }
                    } 
                }
            }
            if (Input.GetKeyDown("3") && playerA.Count >= 3) {
                playerId = "3";

                if (playerA.Count >= 1) {
                    playerA[0].GetComponent<Renderer>().enabled = false;
                    playerA[0].GetComponent<Collider2D>().enabled = false;
                    playerB[0].GetComponent<Renderer>().enabled = true;
                    playerB[0].GetComponent<Collider2D>().enabled = true;

                    if (playerA.Count >= 2) {
                        playerA[1].GetComponent<Renderer>().enabled = false;
                        playerA[1].GetComponent<Collider2D>().enabled = false;
                        playerB[1].GetComponent<Renderer>().enabled = true;
                        playerB[1].GetComponent<Collider2D>().enabled = true;

                        if (playerA.Count >= 3) {
                            playerA[2].GetComponent<Renderer>().enabled = true;
                            playerA[2].GetComponent<Collider2D>().enabled = true;
                            playerB[2].GetComponent<Renderer>().enabled = false;
                            playerB[2].GetComponent<Collider2D>().enabled = false;

                            if (playerA.Count >= 4) {
                                playerA[3].GetComponent<Renderer>().enabled = false;
                                playerA[3].GetComponent<Collider2D>().enabled = false;
                                playerB[3].GetComponent<Renderer>().enabled = true;
                                playerB[3].GetComponent<Collider2D>().enabled = true;

                                if (playerA.Count >= 5) {
                                    playerA[4].GetComponent<Renderer>().enabled = false;
                                    playerA[4].GetComponent<Collider2D>().enabled = false;
                                    playerB[4].GetComponent<Renderer>().enabled = true;
                                    playerB[4].GetComponent<Collider2D>().enabled = true;
                                }
                            }
                        }
                    } 
                }
            }
            if (Input.GetKeyDown("4") && playerA.Count >= 4) {
                playerId = "4";

                if (playerA.Count >= 1) {
                    playerA[0].GetComponent<Renderer>().enabled = false;
                    playerA[0].GetComponent<Collider2D>().enabled = false;
                    playerB[0].GetComponent<Renderer>().enabled = true;
                    playerB[0].GetComponent<Collider2D>().enabled = true;

                    if (playerA.Count >= 2) {
                        playerA[1].GetComponent<Renderer>().enabled = false;
                        playerA[1].GetComponent<Collider2D>().enabled = false;
                        playerB[1].GetComponent<Renderer>().enabled = true;
                        playerB[1].GetComponent<Collider2D>().enabled = true;

                        if (playerA.Count >= 3) {
                            playerA[2].GetComponent<Renderer>().enabled = false;
                            playerA[2].GetComponent<Collider2D>().enabled = false;
                            playerB[2].GetComponent<Renderer>().enabled = true;
                            playerB[2].GetComponent<Collider2D>().enabled = true;

                            if (playerA.Count >= 4) {
                                playerA[3].GetComponent<Renderer>().enabled = true;
                                playerA[3].GetComponent<Collider2D>().enabled = true;
                                playerB[3].GetComponent<Renderer>().enabled = false;
                                playerB[3].GetComponent<Collider2D>().enabled = false;

                                if (playerA.Count >= 5) {
                                    playerA[4].GetComponent<Renderer>().enabled = false;
                                    playerA[4].GetComponent<Collider2D>().enabled = false;
                                    playerB[4].GetComponent<Renderer>().enabled = true;
                                    playerB[4].GetComponent<Collider2D>().enabled = true;
                                }
                            }
                        }
                    } 
                }
            }
            if (Input.GetKeyDown("4") && playerA.Count >= 4) {
                playerId = "4";

                if (playerA.Count >= 1) {
                    playerA[0].GetComponent<Renderer>().enabled = false;
                    playerA[0].GetComponent<Collider2D>().enabled = false;
                    playerB[0].GetComponent<Renderer>().enabled = true;
                    playerB[0].GetComponent<Collider2D>().enabled = true;

                    if (playerA.Count >= 2) {
                        playerA[1].GetComponent<Renderer>().enabled = false;
                        playerA[1].GetComponent<Collider2D>().enabled = false;
                        playerB[1].GetComponent<Renderer>().enabled = true;
                        playerB[1].GetComponent<Collider2D>().enabled = true;

                        if (playerA.Count >= 3) {
                            playerA[2].GetComponent<Renderer>().enabled = false;
                            playerA[2].GetComponent<Collider2D>().enabled = false;
                            playerB[2].GetComponent<Renderer>().enabled = true;
                            playerB[2].GetComponent<Collider2D>().enabled = true;

                            if (playerA.Count >= 4) {
                                playerA[3].GetComponent<Renderer>().enabled = false;
                                playerA[3].GetComponent<Collider2D>().enabled = false;
                                playerB[3].GetComponent<Renderer>().enabled = true;
                                playerB[3].GetComponent<Collider2D>().enabled = true;

                                if (playerA.Count >= 5) {
                                    playerA[4].GetComponent<Renderer>().enabled = true;
                                    playerA[4].GetComponent<Collider2D>().enabled = true;
                                    playerB[4].GetComponent<Renderer>().enabled = false;
                                    playerB[4].GetComponent<Collider2D>().enabled = false;
                                }
                            }
                        }
                    } 
                }
            }
        }
        
        if (Input.GetKeyDown("space")) {
            playerId = "0";
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
