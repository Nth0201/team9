using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golbal : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scene = 0;
    public static int health = 100;
    public static bool notice = false;
    public static bool sleep = false;
    public static golbal instance;
    private void Start()
    {
        instance = this;
        if (instance != null) {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this);
    }
}
