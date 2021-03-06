﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Soldier : MonoBehaviour
{
    [SerializeField]
    private Animator soldierAnimator;
    
    // Use this for initialization
	void Start ()
    {
        soldierAnimator = GetComponentInChildren<Animator>();
	}

    public void SetWalkingSpeed(float currentVelocity)
    {
        soldierAnimator.SetFloat("MoveBlend", currentVelocity);
    }

    public void SetWalking()
    {
        if (!soldierAnimator.GetBool("isMoving"))
        {
            soldierAnimator.SetBool("isMoving", true);
        }
    }

    public void SetShooting()
    {
        if (!soldierAnimator.GetBool("isAttacking"))
        {
            soldierAnimator.SetBool("isAttacking", true);
        }
    }

    public void SetIdle()
    {
        if (soldierAnimator.GetBool("isMoving"))
        {
            soldierAnimator.SetBool("isMoving", false);
        }
    }
}
