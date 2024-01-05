using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;
    private Queue<string> sentences;
    
    private bool doHB = false;
    [SerializeField] private GameObject roomToToggle;
    [SerializeField] private GameObject hbToToggle;
    [SerializeField] private HangmanController hang_mngr;


    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        nameText.color = Color.white;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        dialogueText.color = Color.white;
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        if (doHB == true) {
            Debug.Log("do hang bear");
            roomToToggle.SetActive(false);
            hbToToggle.SetActive(true);
            doHB = false;
        }
    }

    public void addHB(bool x, string y) {
        doHB = x;
        hang_mngr.src = y;
    }
}
