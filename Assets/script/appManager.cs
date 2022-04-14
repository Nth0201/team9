using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appManager : MonoBehaviour
{
    
    [SerializeField] private Sprite[] backgroundDiffHand;
    [SerializeField] private GameObject background;
    
    
    // Start is called before the first frame update
    void Start()
    {
        int skincode = PlayerPrefs.setInt("skincode", 1);
        if(skincode == 1){
            background.GetComponent<Image>().sprite = backgroundDiffHand[i];
        }elseif(skincode == 2){
            background.GetComponent<Image>().sprite = backgroundDiffHand[i];
        }elseif(skincode == 3){
            background.GetComponent<Image>().sprite = backgroundDiffHand[i];
        }   

        if(){
            
        }

        




                                   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
