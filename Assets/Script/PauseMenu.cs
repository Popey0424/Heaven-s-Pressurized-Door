using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject MenuPause;

    public void OnClickPause()
    {
        MenuPause.SetActive(true);
    }

    public void OnClickResume()
    {
        MenuPause.SetActive(false);
    }

}
