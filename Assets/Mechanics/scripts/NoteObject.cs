using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed; //if you can interact with arrows

    public KeyCode keyToPress;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    ParticleSystem ps;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                this.gameObject.SetActive(false);
                ps.Play();

                GameManager.instance.NoteHit(); // tells game manager that we hit a note
            }

        }
    }

   private void OnTriggerEnter2D(Collider2D other) //Arrow is on top of button
    {
        if(other.tag == "Activator")
        {
            ps = other.gameObject.GetComponent<ParticleSystem>();
            canBePressed = true; //Go ahead you can press the button
            
        }
    }
    private void OnTriggerExit2D(Collider2D other) //Arrow is NOT on top of button
    {
        if (other.tag == "Activator")
        {
            canBePressed = false; //Nop u cant press the button nothing is gonna happen

            GameManager.instance.NoteMissed();
        }
    }

}
