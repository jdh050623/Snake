using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update

    public void Re()
    {
        SnakeController.move = true;
        gameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
