using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public static void LoadScene() {
        SceneManager.LoadScene("characterDesign");
    }

    public static void LoadPlayScene()
    {
        SceneManager.LoadScene("play_scene");
    }
}
