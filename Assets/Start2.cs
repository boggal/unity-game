using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Start2 : MonoBehaviour
{

    private bool isFaded = false;
    
    private int fadeInAmount = 0;
    private int fadeOutAmount = 1;



    [SerializeField] private float fadeInDuration = 2;
    [SerializeField] private float fadeOutDuration = 2;

    [SerializeField] private Animator busanimator;

    [SerializeField] private string busmove = "bus";


    [SerializeField] private Animator cutsceneanimator;

    [SerializeField] private string cutscenemove = "CutsceneFirst";


    [SerializeField] private CanvasGroup myFadingGroup;

    private IEnumerator Start()
    {
        int testvalue = 0;
        isFaded = !isFaded;
        myFadingGroup.DOFade(fadeInAmount, 0);
        
        busanimator.Play(busmove, 0, 0.0f);
        cutsceneanimator.Play(cutscenemove, 0, 0.0f);
        yield return new WaitForSeconds(5);
        cutsceneanimator.enabled = false;
        myFadingGroup.DOFade(fadeOutAmount, 3);
    }

private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Invis"))
        {
            SceneManager.LoadScene("School");
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
