using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class MainGame : MonoBehaviour
{
 
    public TMP_Text TextDialog;
    public TMP_Text TextCharacterName;
    public Image ImageCharacter;
    public DialogSequence[] Dialogs;
    public Image spriteBackground;
    public TMP_Text choice1;
    public TMP_Text choice2;
    public Image ImageCharacter2;


    int _sequenceNumber;

    void UpdateDialogSequence(  DialogSequence sequence )
    {

        TextDialog.text = sequence.TextDialog;
        TextCharacterName.text = sequence.TextNameCharacter;
        ImageCharacter.sprite = sequence.SpriteCharacter;
        spriteBackground.sprite = sequence.SpriteBackground;
        bool isChoice = !(String.IsNullOrEmpty(sequence.Choice1) || String.IsNullOrEmpty(sequence.Choice2));
        if (isChoice)
        {
            choice1.text = sequence.Choice1;
            choice2.text = sequence.Choice2;
        }
        ImageCharacter2.sprite = sequence.SpriteCharacter;
    }

    void Start()
    {
        UpdateDialogSequence(Dialogs[0]);
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;
        UpdateDialogSequence(Dialogs[_sequenceNumber]);

    }
}
