using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pages : MonoBehaviour
{
    public int currentPage = 0;

    public GameObject NextButton, NextScene;

    public GameObject[] pages;

    public void AdvancePage(int direction)
    {
        //this turns off the page were currently on
        pages[currentPage].SetActive(false);
        //increase the page by one
        currentPage = currentPage + direction;


        if (currentPage == pages.Length - 1) //if we're on the last page
        {
            NextButton.SetActive(false);
            //TODO: turn on the next scene button
            NextScene.SetActive(true);

        }
        else
        {
            NextButton.SetActive(true);
        }

        //this is for moving backwards:
        if (currentPage == 0)
        {
         //   PrevButton.SetActive(false);
        }
        else
        {
        //    PrevButton.SetActive(true);
        }

        //turn on the current page
        pages[currentPage].SetActive(true);

    }
}
