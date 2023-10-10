using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject MenuPause;
    [SerializeField] private Image ImageFade;

    public void OnClickPause()
    {
        MenuPause.SetActive(true);
    }

    public void OnClickResume()
    {
        MenuPause.SetActive(false);
    }

    public void OnClickLeave()
    {
        ImageFade.DOFade(1, 2.9f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Menu");
    }
}
