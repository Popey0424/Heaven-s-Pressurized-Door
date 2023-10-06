using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text DialogText;

    public void ChangeDialog(string newDialog)
    {
        DialogText.text = newDialog;
    }
}
