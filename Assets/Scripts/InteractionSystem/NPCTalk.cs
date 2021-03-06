﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : Interactable
{
    private InteractionUI interactionUI;
    private QuestController questController;

    void Awake()
    {
        type = InteractionTypes.Talk;
    }

    private void Start()
    {
        interactionUI = InteractionUI.Instance;
        questController = QuestController.Instance;
    }

    public override void Interact()
    {
        var characterProps = GetComponent<CharacterProps>();

        interactionUI.Talk(characterProps.lines);
        questController.SendProgressForQuest(characterProps.name);
    }
}
