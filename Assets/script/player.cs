using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField] private Vector3 endPos;
    private Animator play_animation;

    static float t = 0.0f;

    // Start is called before the first frame update
    public void Awake()
    {
        play_animation = playerContoller.instance.gameObject.GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        if (playerContoller.instance.gameObject.transform.position == endPos)
            play_animation.SetBool("walk", false);
        else
            play_animation.SetBool("walk", true);


        t += 0.3f * Time.deltaTime;

        playerContoller.instance.gameObject.transform.position = new Vector3(Mathf.Lerp(startPos.x, endPos.x, t), (Mathf.Lerp(startPos.y, endPos.y, t)),0);
        


        if (t > 2.0f)
        {
            Vector3 temp = endPos;
            endPos = startPos;
            startPos = temp;
            t = 0.0f;
        }

    }
}
