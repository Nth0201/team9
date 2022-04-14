using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D.Animation;

public class playerContoller : MonoBehaviour
{
    [SerializeField] private Button[] button;
    [SerializeField] SpriteResolver[] spriteResolver;
    [SerializeField] string[] labels;
    [SerializeField] private GameObject[] hair;
    public static playerContoller instance;
    public static int skincode;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
        if (clickAction.characher == 1) { 
            hair[0].SetActive(false);
            hair[1].SetActive(true);
        }
       
    }
    private void Awake()
    {
        
        button[0].onClick.AddListener(delegate {
            spriteResolver[0].SetCategoryAndLabel(spriteResolver[0].GetCategory(), "Head 1");
            spriteResolver[1].SetCategoryAndLabel("Hand", "Layer 45");
            spriteResolver[2].SetCategoryAndLabel("Hand", "Layer 45");
            spriteResolver[3].SetCategoryAndLabel("Leg", "Layer 36");
            spriteResolver[4].SetCategoryAndLabel("Leg", "Layer 42");
            skincode = 1;
        });
        button[1].onClick.AddListener(delegate {
            spriteResolver[0].SetCategoryAndLabel(spriteResolver[0].GetCategory(), "Head 2");
            spriteResolver[1].SetCategoryAndLabel("Hand", "Layer 44");
            spriteResolver[2].SetCategoryAndLabel("Hand", "Layer 44");
            spriteResolver[3].SetCategoryAndLabel("Leg", "Layer 35");
            spriteResolver[4].SetCategoryAndLabel("Leg", "Layer 41");
            skincode = 2;
        });
        button[2].onClick.AddListener(delegate {
            spriteResolver[0].SetCategoryAndLabel(spriteResolver[0].GetCategory(), "Head 3");
            spriteResolver[1].SetCategoryAndLabel(spriteResolver[1].GetCategory(), "Layer 43");
            spriteResolver[2].SetCategoryAndLabel("Hand", "Layer 43");
            spriteResolver[3].SetCategoryAndLabel(spriteResolver[3].GetCategory(), "Layer 34");
            spriteResolver[4].SetCategoryAndLabel(spriteResolver[4].GetCategory(), "Layer 40");
            skincode = 3;
        });

        button[3].onClick.AddListener(delegate {
            spriteResolver[5].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 22");
            spriteResolver[6].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 23");


        });
        button[4].onClick.AddListener(delegate {
            spriteResolver[5].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 24");
            spriteResolver[6].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 25");
            
        });
        button[5].onClick.AddListener(delegate {
            spriteResolver[5].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 26");
            spriteResolver[6].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 27");
        });
        button[6].onClick.AddListener(delegate {
            spriteResolver[5].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 28");
            spriteResolver[6].SetCategoryAndLabel(spriteResolver[5].GetCategory(), "Layer 29");
        });

        button[16].onClick.AddListener(delegate {
            spriteResolver[10].SetCategoryAndLabel(spriteResolver[10].GetCategory(), "Brows 1");
            Debug.Log("asdasd");
        });
        button[17].onClick.AddListener(delegate {
            spriteResolver[10].SetCategoryAndLabel(spriteResolver[10].GetCategory(), "Brows 2");
        });
        button[18].onClick.AddListener(delegate {
            spriteResolver[10].SetCategoryAndLabel(spriteResolver[10].GetCategory(), "Brows 3");
        });
        button[19].onClick.AddListener(delegate {
            spriteResolver[10].SetCategoryAndLabel(spriteResolver[10].GetCategory(), "Brows 4");
        });
        button[20].onClick.AddListener(delegate {
            spriteResolver[10].SetCategoryAndLabel(spriteResolver[10].GetCategory(), "Brows 5");
        });

        button[21].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 1");
        });
        button[22].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 2");
        });
        button[23].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 3");
        });
        button[24].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 4");
        });
        button[25].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 5");
        });
        button[26].onClick.AddListener(delegate {
            spriteResolver[11].SetCategoryAndLabel(spriteResolver[11].GetCategory(), "Blushes 6");
        });

        button[27].onClick.AddListener(delegate {
            if(spriteResolver[12].GetLabel() == "Layer 75")
                spriteResolver[12].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "empty");
            else
                spriteResolver[12].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "Layer 75");

        });
        button[28].onClick.AddListener(delegate {
            if (spriteResolver[13].GetLabel() == "Entry")
                spriteResolver[13].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "empty");
            else
                spriteResolver[13].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "Entry");
        });
        button[29].onClick.AddListener(delegate {
            if (spriteResolver[14].GetLabel() == "Layer 77")
                spriteResolver[14].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "empty");
            else
                spriteResolver[14].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "Layer 77");
        });
        button[30].onClick.AddListener(delegate {
            if (spriteResolver[15].GetLabel() == "Layer 78")
                spriteResolver[15].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "empty");
            else
                spriteResolver[15].SetCategoryAndLabel(spriteResolver[12].GetCategory(), "Layer 78");
        });
        if (clickAction.characher == 0)
        {
            //boy
            button[7].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 62");
            });
            button[8].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 60");
            });
            button[9].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 58");
            });
            button[10].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 56");
            });
            button[11].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 54");
            });
            button[12].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Boy", "Layer 52");
            });
            button[13].onClick.AddListener(delegate {
                spriteResolver[8].SetCategoryAndLabel(spriteResolver[8].GetCategory(), "Layer 66");
            });
            button[14].onClick.AddListener(delegate {
                spriteResolver[8].SetCategoryAndLabel(spriteResolver[8].GetCategory(), "Layer 64");
            });
            button[15].onClick.AddListener(delegate {
                spriteResolver[8].SetCategoryAndLabel(spriteResolver[8].GetCategory(), "Layer 65");
            });

        }
        else {
            spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 63");
            button[7].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 63");
            });
            button[8].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 61");
            });
            button[9].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 59");
            });
            button[10].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 57");
            });
            button[11].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 55");
            });
            button[12].onClick.AddListener(delegate {
                spriteResolver[7].SetCategoryAndLabel("Clothes_Girl", "Layer 53");
            });
            button[13].onClick.AddListener(delegate {
                spriteResolver[9].SetCategoryAndLabel(spriteResolver[9].GetCategory(), "Layer 69");
            });
            button[14].onClick.AddListener(delegate {
                spriteResolver[9].SetCategoryAndLabel(spriteResolver[9].GetCategory(), "Layer 68");
            });
            button[15].onClick.AddListener(delegate {
                spriteResolver[9].SetCategoryAndLabel(spriteResolver[9].GetCategory(), "Layer 67");
            });
            
        }

    
    
    }

}
