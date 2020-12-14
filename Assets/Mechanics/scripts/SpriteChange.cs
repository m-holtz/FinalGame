using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public GameManager gm;

    private Animator theAnim;

    int scoreState = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        theAnim = GetComponent<Animator>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.currentScore >= 1 && scoreState == 0)
        {
            theAnim.SetTrigger("playCurious");
            scoreState = 1;
        }

        if (gm.currentScore >= 20 && scoreState == 1)
        {
            theAnim.SetTrigger("playDance1");
            scoreState = 2;
        }

        if (gm.currentScore >= 40 && scoreState == 2)
        {
            theAnim.SetTrigger("playDance2");
            scoreState = 3;
        }



    }
}
