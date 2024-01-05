using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  public Dialogue dialogue;

  public bool doHangBear = false;

  public void OnMouseDown ()
  {
    DialogueManager mngr = FindObjectOfType<DialogueManager>();
    if (mngr != null) {
      mngr.StartDialogue(dialogue);
      mngr.addHB(doHangBear);
    }
  }
}
