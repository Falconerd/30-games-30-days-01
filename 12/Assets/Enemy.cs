﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    internal void Die()
    {
        Destroy(gameObject);
    }
}