using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PageScript : MonoBehaviour
{
    public enum BookStates {Button, PageFlipper}
    public BookStates currentstate;
    public GameObject Button;
    public GameObject PageFlipper;

    private void Awake()
    {
        currentstate = BookStates.Button;
    }

    private void Update()
    {
        switch (currentstate)
        {
            case BookStates.Button:

                Button.SetActive(true);
                PageFlipper.SetActive(false);

                break;
            case BookStates.PageFlipper:

                Button.SetActive(true);
                PageFlipper.SetActive(true);

                break;
        }
    }
    public void OnButton()
    {
        
    }

    public void OnPageFlipper()
    {

    }
}
