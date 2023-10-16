//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class Dialog : MonoBehaviour
//{
//    public string TextDialog;
//    public string TextNameCharacter;
//    public Sprite SpriteCharacter;
//    public Sprite SpriteBackground;
//    public string Choice1;
//    public string Choice2;
//    public Sprite SpriteCharacter2;

//    public TextMeshProUGUI textComponent;
//    public string[] lines;
//    public float textSpeed;

//    private int index;

//    void Start()
//    {
//        textComponent.text = string.Empty;
//        StartDialogue();
//    }

//    void Update()
//    {

//    }


//    void StartDialogue()
//    {
//        index = 0;
//        StartCoroutine(TypeLine());
//    }

//    IEnumerator TypeLine()
//    {
//        foreach (char c in lines[index].ToCharArray())
//        {
//            textComponent.text += c;
//            yield return new WaitForSeconds(textSpeed);
//        }
//    }
//}
