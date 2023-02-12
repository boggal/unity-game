using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Start2 : MonoBehaviour
{

    private bool isFaded = false;
    
    private int fadeInAmount = 0;
    private int fadeOutAmount = 1;

    private bool testvalue = true;

    [SerializeField] private float fadeInDuration = 2;
    [SerializeField] private float fadeOutDuration = 2;

    [SerializeField] private Animator busanimator;

    [SerializeField] private string busmove = "bus";

    [SerializeField] private CanvasGroup myFadingGroup;

    void Start()
    {

        isFaded = !isFaded;
         myFadingGroup.DOFade(fadeInAmount, 0);
         myFadingGroup.DOFade(fadeOutAmount, 1);
        
       
        Debug.Log("Hello, World!");
    }

private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Invis"))
        {
        myFadingGroup.DOFade(fadeInAmount, 3);
        if(testvalue = true)
        {
        busanimator.Play(busmove, 0, 0.0f);
        testvalue = false;
        }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
