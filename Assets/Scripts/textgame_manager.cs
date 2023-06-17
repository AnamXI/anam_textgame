using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textgame_manager : MonoBehaviour
{

    public int hp_value;
    public int snt_value;
    public TextMeshProUGUI hptxt_value, snttxt_value, storytxt_value;
    public string startOfstory, storytext;
    public GameObject menu, stats, lvl1_choices, lvl2_choices;

    // Start is called before the first frame update
    void Start()
    {
        hp_value = 10;
        snt_value = 10;
        startOfstory = "";
        lvl1_choices.SetActive(false);
        lvl2_choices.SetActive(false);
        stats.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        hptxt_value.text = hp_value.ToString();
        snttxt_value.text = snt_value.ToString();
        storytxt_value.text = startOfstory;
    }

 

    public void exit()
    {
        Application.Quit();
    }

    public void start()
    {
        lvl1_choices.SetActive(true);
        menu.SetActive(false);
        stats.SetActive(true);
    }

    //Scene 1 Buttons
    public void go_down()
    {
        snt_value -= 10;
        startOfstory = "You went down the stairs. But there was no downstairs... where are you?";
        lvl1_choices.SetActive(false);
    }

    public void go_up()
    {
        hp_value -= 0;
        startOfstory = "You went upstairs. There's 2 rooms: to your left is a library, and to the right is a cafe.";
        lvl1_choices.SetActive(false);
        lvl1_choices.SetActive(true);
    }

    public void go_punch()
    {
        snt_value -= 5;
        startOfstory = "You punch the aircon unit and now everyone is looking at you like a lunatic. Nice job idiot.";
        lvl1_choices.SetActive(false);
        lvl2_choices.SetActive(true);
    }

    //Scene 2 Buttons
}
