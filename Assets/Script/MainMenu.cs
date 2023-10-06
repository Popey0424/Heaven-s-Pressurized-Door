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
    
    public void OnClickPlay()
    {
        ImageFade.DOFade(1, 0.8f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Gameplay");
    }

}
