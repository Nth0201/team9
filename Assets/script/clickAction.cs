using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class clickAction : MonoBehaviour
{
    [SerializeField] private Button male;
    [SerializeField] private Button female;

    SceneManager sceneManger = new SceneManager();
    public static int characher = 0;
    // Start is called before the first frame update
    void Start()
    {
        male.Select();
    }

    // Update is called once per frame
    public void SelectMale()
    {
        if (characher == 1)
        {
            characher = 0;
        }
    }
    public void SelectFemale()
    {
        if (characher == 0)
        {
            characher = 1;
        }
    }

}
