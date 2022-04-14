using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class styleSelector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] stylelist;
    [SerializeField] private GameObject okBtn;
    GameObject style;
    GameObject button;
    GameObject tmp;

    public void Awake()
    {
        style = GameObject.Find("style");
        button = GameObject.Find("nextBtn");
    }
    public void hair_color() {
        
        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[0];
        stylelist[0].SetActive(true);
        okBtn.SetActive(true);
    }

    public void clothes_color()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[1];
        stylelist[1].SetActive(true);
        okBtn.SetActive(true);
    }

    public void shoes_color()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[2];
        stylelist[2].SetActive(true);
        okBtn.SetActive(true);
    }

    public void skin_color()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[3];
        stylelist[3].SetActive(true);
        okBtn.SetActive(true);
    }

    public void browsSelection()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[4];
        stylelist[4].SetActive(true);
        okBtn.SetActive(true);
    }

    public void blushesSelection()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[5];
        stylelist[5].SetActive(true);
        okBtn.SetActive(true);
    }

    public void OtherSelection()
    {

        button.SetActive(false);
        style.SetActive(false);
        tmp = stylelist[6];
        stylelist[6].SetActive(true);
        okBtn.SetActive(true);
    }

    public void Okbtn() {
        okBtn.SetActive(false);
        tmp.SetActive(false);

        button.SetActive(true);
        style.SetActive(true);
    }
}
