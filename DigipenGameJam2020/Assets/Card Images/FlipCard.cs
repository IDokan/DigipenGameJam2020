using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
    public int fps = 60;
    public int rotatePerDegreeSecond = 180;
    public bool isFaceUp { get; set; } = false;

    const float FLIP_LIMIT_DEGREE = 180.0f;

    float waitTime;
    bool isAnimationProcessing = false;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = 1.0f / fps;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if(isAnimationProcessing)
        {
            return;
        }
        StartCoroutine(flip());

    }

    IEnumerator flip()
    {
        isAnimationProcessing = true;

        bool done = false;
        while(!done)
        {
            float degree = rotatePerDegreeSecond * Time.deltaTime;
            if (isFaceUp)
            {
                degree = -degree;
            }

            transform.Rotate(new Vector3(0, degree, 0));
            if(FLIP_LIMIT_DEGREE < transform.eulerAngles.y)
            {
                transform.Rotate(new Vector3(0, -degree, 0));
                done = true;
            }

            yield return new WaitForSeconds(waitTime);
        }

        isFaceUp = !isFaceUp;
        isAnimationProcessing = false;
    }
}
