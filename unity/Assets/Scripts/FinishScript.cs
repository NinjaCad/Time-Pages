using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    /*void Start() {
        SceneManager.LoadScene("Level1");
    }*/

    void OnTriggerEnter2D(Collider2D col) {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1")) {
            SceneManager.LoadScene("Level2");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2")) {
            SceneManager.LoadScene("Level3");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3")) {
            SceneManager.LoadScene("Level4");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4")) {
            SceneManager.LoadScene("Level5");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5")) {
            SceneManager.LoadScene("Level6");
        }
    }
}
