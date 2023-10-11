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
    [SerializeField] private Button Choice1Button;
    

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;


    int _sequenceNumber;
    void UpdateDialogSequence(  DialogSequence sequence )
    {
        
        TextDialog.text = sequence.TextDialog;
        TextCharacterName.text = sequence.TextNameCharacter;
        ImageCharacter.sprite = sequence.SpriteCharacter;

         if (sequence.SpriteCharacter == null)
        {
            ImageCharacter.color = new Color(1, 1, 1, 0);
        }
        else
        {
            ImageCharacter.color = new Color(1, 1, 1, 1);
        }
        spriteBackground.sprite = sequence.SpriteBackground;
        
        
        bool isChoice = !(String.IsNullOrEmpty(sequence.Choice1) || String.IsNullOrEmpty(sequence.Choice2));
        if (isChoice)
        {
            choice1.text = sequence.Choice1;
           // Choice1Button.SetActive(true);
            choice2.text = sequence.Choice2;
        }
        
        
        ImageCharacter2.sprite = sequence.SpriteCharacter2;
        if (sequence.SpriteCharacter2 == null)
        {
            ImageCharacter2.color = new Color(1, 1, 1, 0);
        }
    }

    void Start()
    {
        UpdateDialogSequence(Dialogs[0]);
       
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;
        UpdateDialogSequence(Dialogs[_sequenceNumber]);

        FindObjectOfType<AudioManager>().Play("NextDialog");
    }
}
