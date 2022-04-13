using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class modelSelector : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObject;
    // Start is called before the first frame update
    [SerializeField] private Sprite[] girls_style;
    [SerializeField] private Sprite[] boys_style;

    void Awake()
    {

        if (clickAction.characher == 0)
        {
            //show boy

            //load character asset
            for (int i = 0; i < 8; i++) {

                gameObject[i].GetComponent<Image>().sprite = boys_style[i];

            }
        }
        else {
            //show girl

            //load character asset
            for (int i = 0; i < 8; i++)
            {

                gameObject[i].GetComponent<Image>().sprite = girls_style[i];

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
