﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the purpose of this script is to take values and apply them to the managable resources in the game
public class EventController : MonoBehaviour
{
    public float MoraleEdit;
    public float ResourcesEdit;
    public MoraleController Moraleo;
    public ResourceController Resourceo;

    // Start is called before the first frame update
    void Start()
    {
        Moraleo = this.transform.parent.GetComponentInChildren<MoraleController>();
        Resourceo = this.transform.parent.GetComponentInChildren<ResourceController>();

        Moraleo.UpdateValue(MoraleEdit);
        Resourceo.UpdateValue(ResourcesEdit);
    }

}