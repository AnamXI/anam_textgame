using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTimer{

    private Action action;
    private float timer;

    // Start is called before the first frame update
    public FunctionTimer(Action action, float timer)
    {
        this.action = action;
        this.timer = timer;
    }

    // Update is called once per frame
    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            action();
        }
    }
}
