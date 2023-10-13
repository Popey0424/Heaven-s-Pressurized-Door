using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private Image ImageFade3;
    public void OnClickMenu()
    {
        ImageFade3.DOFade(1, 2.9f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Menu");
    }
}
