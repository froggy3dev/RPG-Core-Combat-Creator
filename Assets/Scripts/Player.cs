﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float maxHealthPoint = 100f;

    float currentHealthPoint = 100f;

    public float healthAsPercentage
    {
        get
        {
            return currentHealthPoint / maxHealthPoint;
        }
    }
}
