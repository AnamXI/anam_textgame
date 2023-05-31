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
    public string startOfstory;
    public GameObject lvl1_choices;

    // Start is called before the first frame update
    void Start()
    {
        hp_value = 10;
        snt_value = 10;
        startOfstory = "You enter the CIIT Interweave building. Immediately the atmosphere gets hit by a gust of bone chilling wind. You feel a cold presence grasp the very fibers of your body." +
                       "A big looming shadow comes into view as you slowly turn your head from the door to the reception desk. This being is easily twice your size and thrice your girth. Shakily, you look" +
                       "up to see your assailant, sweat dripping down your eyelids. The hairs on your body start to rise as you slowly take in its form and- Oh, it's just the aircon.";
    }

    // Update is called once per frame
    void Update()
    {
        hptxt_value.text = hp_value.ToString();
        snttxt_value.text = snt_value.ToString();
        storytxt_value.text = startOfstory;
    }

    public void go_down()
    {
        hp_value -= 10;
        startOfstory = "You went down the stairs. But there was no downstairs... where are you?";
        lvl1_choices.SetActive(false);
    }

    public void go_up()
    {
        hp_value -= 0;
        startOfstory = "You went upstairs, the security guard welcomes you and points to two doors: the registrar and the finance office";
        lvl1_choices.SetActive(false);
    }

    public void go_punch()
    {
        snt_value -= 5;
        startOfstory = "You punch the aircon unit and now everyone is looking at you like a lunatic. Nice job idiot.";
        lvl1_choices.SetActive(false);
    }
}
