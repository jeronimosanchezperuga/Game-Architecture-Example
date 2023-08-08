using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum SceneNames
    {
        Game,
        Splash,
        Menu,
        Results,
        Credits
    }

    public static void Load(string name)
    {
        SceneManager.LoadScene(name);
    }
}
