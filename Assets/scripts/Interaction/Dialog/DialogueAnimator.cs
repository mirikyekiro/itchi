using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator dialogueAnim;
    public Animator startAnim;
    public DialogueManager dm;


    public void OnTriggerEnter2d(Collider2D other)
    {
        dialogueAnim.SetBool("Dialog_open", true);
        startAnim.SetBool("Dialog_open", true);
    }
    public void OnTriggerExit2d(Collider2D other)
    {
        dialogueAnim.SetBool("Dialog_open", false);
        startAnim.SetBool("Dialog_open", false);
        dm.EndDialogue();
    }
}
