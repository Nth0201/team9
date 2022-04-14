using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class eventController : MonoBehaviour
{
    [SerializeField] private Sprite phone_up;
    [SerializeField] private Sprite phone_back;
    [SerializeField] private Sprite bed_up;
    [SerializeField] private Sprite bed_back;

    [SerializeField] private GameObject phone;
    [SerializeField] private GameObject bed;
    [SerializeField] private GameObject[] dayScene;

    public static double timer = 0;
    // Start is called before the first frame update
    private void Start()
    {
        golbal.notice = true;
        dayScene[golbal.scene].SetActive(true);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (golbal.notice)
        {
            timer += 0.5 * Time.deltaTime;
            if (timer > 1f)
            {
                timer = 0;
                if (phone.GetComponent<Image>().sprite == phone_up)
                    phone.GetComponent<Image>().sprite = phone_back;
                else
                    phone.GetComponent<Image>().sprite = phone_up;
            }
        }
        if (golbal.sleep) {
            timer += 0.5 * Time.deltaTime;
            if (timer > 1f)
            {
                timer = 0;
                if (bed.GetComponent<Image>().sprite == bed_up)
                    bed.GetComponent<Image>().sprite = bed_back;
                else
                    bed.GetComponent<Image>().sprite = bed_up;
            }
        }
    }
}
