using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  private Dialogue dialogue;
  [SerializeField] private DialogueSet currentSet;

  public void OnMouseDown ()
  {
    dialogue = currentSet.dialogueSet[currentSet.whichSet];
    FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
  }
}
