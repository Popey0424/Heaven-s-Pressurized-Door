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



    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    

    private int index;
    private int dialog = 0;

    int _sequenceNumber;
    void UpdateDialogSequence(  DialogSequence sequence )
    {
        StartCoroutine(TypeLine(sequence.TextDialog));
        TextDialog.text = sequence.TextDialog;
        TextCharacterName.text = sequence.TextNameCharacter;
        ImageCharacter.sprite = sequence.SpriteCharacter;
        
       
    IEnumerator TypeLine(string sequenceTextDialog)
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

        if (sequence.SpriteCharacter == null)
        {
            ImageCharacter.color = new Color(1, 1, 1, 0);
        }
        else
        {
            ImageCharacter.color = new Color(1, 1, 1, 1);
        }
        spriteBackground.sprite = sequence.SpriteBackground;
        
        
        //bool isChoice = !(String.IsNullOrEmpty(sequence.ChoiceButton1.ToString()) || String.IsNullOrEmpty(sequence.ChoiceButton2.ToString()));
        //if (isChoice)
        //{
        //    ChoiceButton1 = sequence.Choice1;
        //    ChoiceButton1.gameObject.SetActive(true);
        //    ChoiceButton2.Button = sequence.Choice2;
        //}
        
        
        ImageCharacter2.sprite = sequence.SpriteCharacter2;
        if (sequence.SpriteCharacter2 == null)
        {
            ImageCharacter2.color = new Color(1, 1, 1, 0);
        }
    }



    void Start()
    {
        choiceButton1.gameObject.SetActive(false);
        choiceButton2.gameObject.SetActive(false);

        choiceButton1.onClick.AddListener(ChoiceButton1);
        choiceButton2.onClick.AddListener(ChoiceButton2);

        UpdateDialogSequence(Dialogs[0]);
       
        textComponent.text = string.Empty;
        StartDialogue();

        
        
    }

    public void ChoiceButton1()
    {
        dialog++;
        choiceButton1.gameObject.SetActive(false);
    }

    public void ChoiceButton2()
    {
        dialog += 2;
        choiceButton2.gameObject.SetActive(false);
    }

    
    void StartDialogue()
    {
       
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;

       // if (_sequenceNumber >= Dialogs.Count)
        //{
         //   ButtonContinuer.gameObject.SetActive(false);
       // }

        //if (_sequenceNumber < Dialogs.Count)
        //{
        UpdateDialogSequence(Dialogs[_sequenceNumber]);
        //}
        
        //else
       // {
            choiceButton1.gameObject.SetActive(true);
           // choiceButton2.gameObject.SetActive(true);

            dialog ++;
        //}

        FindObjectOfType<AudioManager>().Play("NextDialog");
    }
}

