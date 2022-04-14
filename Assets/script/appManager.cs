using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class appManager : MonoBehaviour
{
    
    [SerializeField] private Sprite[] backgroundDiffHand;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject[] girlfirstblackbox;
    [SerializeField] private GameObject[] boyfirstblackbox;
    [SerializeField] private GameObject gender;
    [SerializeField] private Sprite[] genders;
    double timable = 0;
    // Start is called before the first frame update
    void Start()
    {
        int skincode = playerContoller.skincode;
        if(skincode == 1){
            background.GetComponent<Image>().sprite = backgroundDiffHand[0];
        }else if(skincode == 2){
            background.GetComponent<Image>().sprite = backgroundDiffHand[1];
        }else if(skincode == 3){
            background.GetComponent<Image>().sprite = backgroundDiffHand[2];
        }   

        if( clickAction.characher == 1){
             gender.GetComponent<Image>().sprite = genders[0];
        }else{
            gender.GetComponent<Image>().sprite = genders[1];
        }
                                   
    }

    // Update is called once per frame
    void Update()
    {
        timable += Time.deltaTime;

        if (golbal.scene == 1)
        {
            if (clickAction.characher == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (timable == 5)
                    {
                        girlfirstblackbox[i].SetActive(false);
                    }
                }
                callback();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    boyfirstblackbox[i].SetActive(false);
                }
            }
            callback();

        }
        else if(golbal.scene == 2){
            if (clickAction.characher == 1)
            {
                for (int i = 4; i < 8; i++)
                {
                    if (timable == 5)
                    {
                        girlfirstblackbox[i].SetActive(false);
                    }
                }
            }
            else
            {
                for (int i = 3; i < 6; i++)
                {
                    boyfirstblackbox[i].SetActive(false);
                }
            }
            callback();
        }
        else if(golbal.scene == 3){
            if (clickAction.characher == 1)
            {
                for (int i = 8; i < 10; i++)
                {
                    if (timable == 5)
                    {
                        girlfirstblackbox[i].SetActive(false);
                    }
                }
            }
            else
            {
                for (int i = 6; i < 13; i++)
                {
                    boyfirstblackbox[i].SetActive(false);
                }
            }
            callback();
        }
        else if(golbal.scene == 4){
            for (int i = 13; i < 4; i++)
            {
                boyfirstblackbox[i].SetActive(false);
            }
            callback();
        }
        else if(golbal.scene == 5){
            callback();
        }
    }


    public void callback(){
        golbal.scene++; // need to see girl or boy to do adjustment
        golbal.health = -50; // see if they have hurt during the conversion
          SceneManager.LoadScene("play_scene", LoadSceneMode.Additive);
        }
}
