﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBookshelf : MonoBehaviour
{
    public GameObject bookshelf;
    bool is_click;
    bool is_ing;
    public float a;

    // Start is called before the first frame update
    void Start()
    {
        is_click = false;
        is_ing = false;
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (is_click == false)
            {
                a += 0.00005f;
                bookshelf.transform.Translate(0, 0, a);
                if (a > 0.025)
                {
                    is_click = true;
                    a = 0f;
                }
            }
        }
        
    }
}
