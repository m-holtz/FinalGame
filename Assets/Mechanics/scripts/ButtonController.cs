using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR; 

    public Sprite defaultImage; //Add default image for colored button
    public Sprite pressedImage; //Add pressed image for button

    public KeyCode keyToPress; //Add the desired key to be pressed

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>(); //defining the Sprite renderer

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage; //If Key is pressed -> change sprite
            //GetComponent<ParticleSystem>().Play();
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage; //Key is not pressed -> default sprite
        }
    }
}
