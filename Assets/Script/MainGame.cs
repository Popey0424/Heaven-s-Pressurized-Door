using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;
using System.Linq;

public class MainGame : MonoBehaviour
{

    public TMP_Text TextDialog;
    public TMP_Text TextCharacterName;
    public Image ImageCharacter;
    public DialogSequence[] Dialogs;
    public Image spriteBackground;
    public Image ImageCharacter2;
    public Button choiceButton1;
    public Button choiceButton2;
    public Button ButtonContinuer;

    public string[] lines;
    public float textSpeed;


    private int index;
    private int dialog = 0;

    int _sequenceNumber;

    #region BuildIn
    void Start()
    {
        choiceButton1.gameObject.SetActive(false);
        choiceButton2.gameObject.SetActive(false);
        ButtonContinuer.gameObject.SetActive(false);

        choiceButton1.onClick.AddListener(delegate { ClickOnChoiceButton(1); });
        choiceButton2.onClick.AddListener(delegate { ClickOnChoiceButton(2); });

        UpdateDialogSequence(Dialogs[0]);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            StopAllCoroutines();
            TextDialog.text = Dialogs[_sequenceNumber].TextDialog;

        }
    }
    #endregion


    #region MyMethods

    public void ClickOnChoiceButton(int number)
    {
        dialog += number;
        choiceButton1.gameObject.SetActive(false);
        choiceButton2.gameObject.SetActive(false);
    }

    IEnumerator TypeLine(string sequenceTextDialog)
    {
        TextDialog.text = string.Empty;
        foreach (char c in sequenceTextDialog.ToCharArray())
        {
            TextDialog.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

    }

    void UpdateDialogSequence(DialogSequence sequence)
    {
        if (sequence.HasChoice)
        {
            ShowChoices(sequence);

        }
        StartCoroutine(TypeLine(sequence.TextDialog));

        TextCharacterName.text = sequence.TextNameCharacter;

        spriteBackground.sprite = sequence.SpriteBackground;

        UpdateCharacter(ImageCharacter, sequence.SpriteCharacter);
        UpdateCharacter(ImageCharacter2, sequence.SpriteCharacter2);



    }

    private void UpdateCharacter(Image charImage, Sprite newSprite)
    {
        if (newSprite == null)
        {
            charImage.color = new Color(1, 1, 1, 0);
        }
        else
        {
            charImage.color = new Color(1, 1, 1, 1);
            if (charImage.sprite != newSprite)
            {
                charImage.sprite = newSprite;
            }
        }
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;
        if (_sequenceNumber >= Dialogs.Length)
        {
            ButtonContinuer.gameObject.SetActive(false);
        }

        if (_sequenceNumber < Dialogs.Length)
        {
            UpdateDialogSequence(Dialogs[_sequenceNumber]);
        }

        else
        {

            dialog++;
        }

        FindObjectOfType<AudioManager>().Play("NextDialog");

    }

    private void ShowChoices(DialogSequence sequence)
    {
        choiceButton1.gameObject.SetActive(true);
        choiceButton2.gameObject.SetActive(true);
        choiceButton1.GetComponentInChildren<TMP_Text>().text = sequence.TextChoice1;
        choiceButton2.GetComponentInChildren<TMP_Text>().text = sequence.TextChoice2;
    }
    #endregion
}

