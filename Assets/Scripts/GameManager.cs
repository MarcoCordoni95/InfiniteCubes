using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    private bool gameHasEnded = false;

    public void EndGame() {

        if (!gameHasEnded) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
}
