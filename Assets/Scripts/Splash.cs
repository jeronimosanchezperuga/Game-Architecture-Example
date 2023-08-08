using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(StartGame),3);
    }

    // Update is called once per frame
    void StartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
