using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] private Color ColorInitial;
    [SerializeField] private Color ColorSelected;
    [SerializeField] private TextMeshProUGUI Text;

    public void OnPointerEnter()
    {
        Text.DOKill();
        Text.DOColor(ColorSelected, 0.2f);
    }

    public void OnPointerExit()
    {
        Text.DOKill();
        Text.DOColor(ColorInitial, 0.2f);   
    }

    

}
