using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private Image ImageFade;
    [SerializeField] private GameObject MenuOptions;
    [SerializeField] private GameObject CreditsMenu;

    public void Start()
    {
        
    }


    public void OnClickPlay()
    {
        ImageFade.DOFade(1, 2.9f).OnComplete(FadeComplete);
    }
   
    private void FadeComplete()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OnClickOptions()
    {
        MenuOptions.SetActive(true);
    }

    public void OnClickExit()
    {
        MenuOptions.SetActive(false);
        CreditsMenu.SetActive(false);
    }

    public void OnClickCredits()
    {
        CreditsMenu.SetActive(true);
    }
    public void OnClickQuit()
    {
        Application.Quit();
    }
}
