using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DialogueSystem))]
public class ReconDialogue : ReconBase
{
    private DialogueSystem dialogueSystem;
    public override void Enter()
    {
        isCompleted = false;
        SafePanelActive(true);

        dialogueSystem = GetComponent<DialogueSystem>();
        dialogueSystem.Setup();
    }

    public override void Execute(ReconManager manager)
    {
        isCompleted = dialogueSystem.UpdateDialogue();

        if (isCompleted)
        {
            manager.SetNextTutorial();
        }
    }

    public override void Exit()
    {
        SafePanelActive(false);
    }
}
