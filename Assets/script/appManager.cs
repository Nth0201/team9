using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scenemanager;

public class appManager : MonoBehaviour
{
    
    [SerializeField] private Sprite[] backgroundDiffHand;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject[] girlfirstblackbox;
    [SerializeField] private GameObject[] boyfirstblackbox;
    [SerializeField] private GameObject girl,boy;
    [SerializeField] private GameObject girl,boy;
    [SerializeField] private Sprite[] genders;
    int timable = 0;
    // Start is called before the first frame update
    void Start()
    {
        int skincode = PlayerPrefs.setInt("skincode", 1);
        if(skincode == 1){
            background.GetComponent<Image>().sprite = backgroundDiffHand[0];
        }elseif(skincode == 2){
            background.GetComponent<Image>().sprite = backgroundDiffHand[1];
        }elseif(skincode == 3){
            background.GetComponent<Image>().sprite = backgroundDiffHand[2];
        }   

        if( clickaction.character == 1){
           girl.SetActive(true);
           boy.SetActive(false);
        }else{
           boy.SetActive(true);
           boy.SetActive(false);
        }
        
        if(scene == 1){
            if(clickaction.character == 1){
              for (int i = 0; i < 4;i++){
                if(timable = 5){
                     girlfirstblackbox[i].SetActive(false);
                }
               }
                callback();
            }else{
               for (int i = 0; i < 3;i++){
                boyfirstblackbox[i].SetActive(false);
               } 
            }
            callback();
           
        }elseif(scene  == 2){
            if(clickaction.character == 1){
                for (int i = 4; i < 8;i++){
                   if(timable = 5){
                    girlfirstblackbox[i].SetActive(false);
                    }
                } 
            }else{
                for (int i = 3; i < 6;i++){
                   boyfirstblackbox[i].SetActive(false);
                } 
            }
            callback();
        }elseif(scene  == 3){
            if(clickaction.character == 1){
                for (int i = 8; i < 10;i++){
                    if(timable = 5){
                     girlfirstblackbox[i].SetActive(false);
                }
                } 
            }else{
                for (int i = 6; i < 13;i++){
                    boyfirstblackbox[i].SetActive(false);
                } 
            }
            callback();
        }elseif(scene == 4){
            for (int i = 13; i < 4;i++){
                    boyfirstblackbox[i].SetActive(false);
                } 
            callback();
        }elseif(scene == 5){

                callback();
        }
 
       




                                   
    }

    // Update is called once per frame
    void Update()
    {
        timable += Time.delltTime;
    }


    public void callback(){
        golbal.scene++; // need to see girl or boy to do adjustment
        //golbal.health = -50; // see if they have hurt during the conversion
          SceneManager.LoadScene("play_scene", LoadSceneMode.Additive);
        }

    public void buttonclickedone(){
        if(clickaction.character == 1){
           
        }else{
           
        }
    }

    public void buttonclickedtwo(){
        if(clickaction.character == 1){
           
        }else{
           
        }
    }

}
