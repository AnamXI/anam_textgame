using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using System.Reflection;
using TMPro.Examples;

public class textgame_manager : MonoBehaviour
{

    public int hp_value;
    public int snt_value;
    public TextMeshProUGUI hptxt_value, snttxt_value, storytxt_value, titletxt_value, endtxt_value, endtitle_value;
    public string startOfstory, storytext, temptxt, titletxt, endtext, endtitle;
    public GameObject menu, stats, levels, scene1, scene2, scene3, scene4, scene5,
                                   q1_choices, q2_choices, q3_choices, q4_choices, q1v,
                                   conts, cont_1, cont_2,cont_3, cont_4, cont_5, cont_6, endings,
                                   sceneimg, end1, end2, end3, end4, end5;


    // lvl1_choices, lvl2_choices, lvl3_choices, lvl4_choices, lvl5_choices,
    // Start is called before the first frame update
    void Start()
    {
        hp_value = 10;
        snt_value = 10;
        startOfstory = "";
        endtext = "";
        endtitle = "";
        cont_1.SetActive(false);
        levels.SetActive(false);
        conts.SetActive(false);
        stats.SetActive(false);
        menu.SetActive(true);
        sceneimg.SetActive(false);
        //endings.SetActive(false);
        titletxt = "";
        
        
    }

    // Update is called once per frame
    void Update()
    {
        hptxt_value.text = hp_value.ToString();
        snttxt_value.text = snt_value.ToString();
        storytxt_value.text = startOfstory;
        titletxt_value.text = titletxt;
        endtxt_value.text = endtext;
        endtitle_value.text = endtitle;

        if (hp_value > 10)
        {
            hp_value = 10;
        }
        
        if (snt_value > 10)
        {
            snt_value = 10;
        }

        if (hp_value <= 0)
        {
            //endings.SetActive(true);
            end5.SetActive(true);
        }

        if (snt_value <= 0)
        {
            end4.SetActive(true);
        }
    }

 

    public void exit()
    {
        Application.Quit();
    }

    public void start()
    {
        levels.SetActive(true);
        conts.SetActive(true);
        scene1.SetActive(true);
        sceneimg.SetActive(true);


        menu.SetActive(false);
        stats.SetActive(true);
        titletxt = "The Lobby";
        startOfstory = "You enter the glass doors of the colorful high rise. The the heat from the asphalt quickly drowned out" +
                       "by the sudden gust of cold embracing your body. You feel an looming prescence just out of sight " +
                       "You look at the ground to see a tall dark shadow, its owner's cold breath tickling your neck. The stairs are mere inches away. ";
    }

    //Scene 1 Buttons
    public void go_down()
    {
        hp_value -= 0;
        snt_value -= 10;
        startOfstory = "";
        scene1.SetActive(false);
        end4    .SetActive(true);
    }

    public void go_up()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "You went upstairs. There's 2 rooms: to your left is a library, and to the right is a cafe.";
        titletxt = "2nd Floor";
        scene1.SetActive(false);
        scene2.SetActive(true);
    }

    public void go_punch()
    {
        hp_value -= 2;
        snt_value -= 5;
        startOfstory = "You throw a jab at the creature and make a run for it. It was just the aircon unit." +
                       " Your fist begins to ache and now everyone is looking at you like an idiot. You realize you have eyes right?" +
                       " You go upstairs. " +
                       "There's 2 rooms: to your left is a library, and to the right is a cafe.";
        titletxt = "2nd Floor";
        scene1.SetActive(false);
        scene2.SetActive(true);
    }

    //Scene 2 Buttons

    public void go_lib()
    {
        hp_value -= 2;
        snt_value += 2;
        startOfstory = "WHAT. Okay, there seems to be a pile of corpses wooden stairs leading to god knows where" +
                       " but you slap yourself and realize they're sleeping students. Having no sense of urgency nor respect for other's time, you admire the" +
                       " admittedly appealing layout of the room and take a nap yourself. You wake up feeling mentally relieved." +
                       " You fall flat on your face on your way out. You continue upstairs.";
        scene2.SetActive(false);
        cont_1.SetActive(true);
        temptxt = "As you reach the halfway point of the steps, you hear a disturbing chattering noise getting louder and louder from above you. A colorful mass" +
                  " emerges into your peripheral as it makes its way down the stairs, making a rapid clattering sound with each step. You feel your forehead moisten" +
                  " with sweat as the figures grow nearer and nearer.";
    }

    public void go_cafe()
    {
        hp_value += 3;
        snt_value -= 1;
        startOfstory = "The far end of the room eminates with a bright orange hue and a fresh toasty heat. You can feel sweat drip down your skin, but the aroma of" +
            " pastries proved too strong to resist, even making you forget that you're on schedule and there are people waiting for you. You help yourself to some" +
            " sustenance. You feel invigorated, though the heat got to your head. You continue upstairs.";
        sceneimg.SetActive(false);
        scene2.SetActive(false);
        cont_1.SetActive(true);
        temptxt = "As you reach the halfway point of the steps, you hear a disturbing chattering noise getting louder and louder from above you. A colorful mass" +
                  " emerges into your peripheral as it makes its way down the stairs, making a rapid clattering sound with each step. You feel your forehead moisten" +
                  " with sweat as the figures grow nearer and nearer.";
    }

    public void cont_up()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "As you reach the halfway point of the steps, you hear a disturbing chattering noise getting louder and louder from above you. A colorful mass" +
                  " emerges into your peripheral as it makes its way down the stairs, making a rapid clattering sound with each step. You feel your forehead moisten" +
                  " with sweat as the figures grow nearer and nearer.";
        titletxt = "The Stairwell";
        scene2.SetActive(false);
        scene3.SetActive(true);
    }

    public void s2_cont()
    {
        titletxt = "The Stairwell";
        startOfstory = temptxt;
        cont_1.SetActive(false);
        scene3.SetActive(true);

    }

    //Scene 3 Buttons

    public void s3_cont()
    {
        titletxt = "Admissions Office";
        startOfstory = temptxt;
        cont_2.SetActive(false);
        scene4.SetActive(true);

    }

    public void s3_endcont()
    {
        end4.SetActive(true);
        endtext = "";
        cont_4.SetActive(false);
    }

    public void look_at()
    {
        hp_value -= 0;
        snt_value -= 5;
        startOfstory = "You raise your head and look at the mass. A rush of vibrant and blinding colors assault your eyes as the appendages of the amalgamation slowly" +
                       " clatter on the steps toward you. You scream as the mass touches you, diving in the middle before finally passing you. You run up toward the next" +
                       " floor. You hear one of the students say 'What the hell's their problem?'";
        scene3.SetActive(false);
        cont_2.SetActive(true);
        temptxt = "You stand in front of a cold office with the twomad bababoi tits are looking at you funny";
    }

    public void ignore_it()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "You close your eyes and keep your head down, leaning down the railing as the clattering mass approaches. You can feel its presence stop right beside" +
            " you, examining. 'Are they okay?' one of the students inquired. 'They're prolly just burnt out, lets go we'll be late.' another chirped. What a cowardly waste" +
            " of a social opportunity. You open your eyes and continue up the stairs unscathed. Was it really worth it?";
        scene3.SetActive(false);
        cont_2.SetActive(true);
        temptxt = "You stand in front of a cold office with the twomad bababoi tits are looking at you funny";
    }

    public void interact_with()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "";
        endtext = "You interact with the mass. Your eyes are filled with blindly bright colors as cacophony of chattering sounds enter your ears and echo " +
            "around your brain like wave of pirhannas chewing their way through. You find yourself moving along with the mass going down, and down, and down the long" +
            "stairway until the noise suddenly stops...";
        titletxt = " ";
        endtitle = "Hello";
        sceneimg.SetActive(false);
        scene3.SetActive(false);
        cont_4.SetActive(true);
    }

    //Scene 4 Buttons
    public void s4_cont()
    {
        titletxt = "";
        endtext = "Watch and analyze the following video then answer the question afterwards";
        endtitle = "Question 1";
        startOfstory = "";
        sceneimg.SetActive(false);
        cont_3.SetActive(false);
        cont_6.SetActive(true);
        scene4.SetActive(false);

    }

    public void s4_q1cont()
    {
        endtext = "";
        scene5.SetActive(true);
        q1v.SetActive(true);
        cont_6.SetActive(false);
        StartCoroutine(q1cour());

       
    }

    IEnumerator q1cour()
    {
        yield return new WaitForSecondsRealtime(3f);
        q1v.SetActive(false);
        q1_choices.SetActive(true);
        endtxt_value.fontSize = 72;
        endtext = "What color were her shoes hm?";
        q1_choices.SetActive(true);

    }

    public void s4_endcont()
    {
        
        cont_3.SetActive(false);
        end3.SetActive(true);
        
    }
   

    public void take_test()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "";
        endtext = "Very well. There will be 4 questions, each with 3 choices. Pick the right ones to pass, pick the wrong ones and...";
        titletxt = "";
        endtitle = "Test Room";
        sceneimg.SetActive(false);
        scene4.SetActive(false);
        cont_3.SetActive(true);
    }

    public void dont_test()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = " ";
        endtext = ".... Get out";
        scene4.SetActive(false);
        scene5.SetActive(true);
    }

    public void finesse_test()
    {
        hp_value -= 0;
        snt_value -= 0;
        startOfstory = "";
        endtext = "A mixture of smirks and grimaces flood the faces of the entities in the room. A few amused (and not so amused) whispers" +
            " can be heard from among the council. The dean approaches you with a contract...";
        endtitle = "Admissions Office";
        titletxt = "";
        sceneimg.SetActive(false);
        scene4.SetActive(false);
        cont_5.SetActive(true);
    }

    //Scene 5 Buttons (Test Questions)

    //q1
    public void blue()
    {
        hp_value -= 2;
        snt_value -= 0;
        endtitle = "Question 2";
        endtxt_value.fontSize = 50;
        endtext = "String theory is a physics theory that suggests that the universe is made up of tiny, vibrating strings of energy. This theory attempts to reconcile the theories " +
            "of general relativity and quantum mechanics, and could provide a more comprehensive description of the universe and its basic components. Who lives in a Pineapple under the Sea?";
        q1_choices.SetActive(false);
        q2_choices.SetActive(true);
    }

    public void red()
    {
        hp_value -= 0;
        snt_value -= 2;
        endtitle = "Question 2";
        endtxt_value.fontSize = 50;
        endtext = "String theory is a physics theory that suggests that the universe is made up of tiny, vibrating strings of energy. This theory attempts to reconcile the theories " +
            "of general relativity and quantum mechanics, and could provide a more comprehensive description of the universe and its basic components. Who lives in a Pineapple under the Sea?";
        q1_choices.SetActive(false);
        q2_choices.SetActive(true);
    }

    public void yellow()
    {
        hp_value -= 0;
        snt_value -= 0;
        endtitle = "Question 2";
        endtxt_value.fontSize = 50;
        endtext = "String theory is a physics theory that suggests that the universe is made up of tiny, vibrating strings of energy. This theory attempts to reconcile the theories " +
            "of general relativity and quantum mechanics, and could provide a more comprehensive description of the universe and its basic components. Who lives in a Pineapple under the Sea?";
        q1_choices.SetActive(false);
        q2_choices.SetActive(true);
    }

    //q2

    public void mickey()
    {
        hp_value -= 2;
        snt_value -= 0;
        endtitle = "Question 3";
        endtxt_value.fontSize = 50;
        endtext = "";
        q2_choices.SetActive(false);
        q3_choices.SetActive(true);
    }

    public void spongebob()
    {
        hp_value -= 0;
        snt_value -= 0;
        endtitle = "Question 3";
        endtxt_value.fontSize = 50;
        endtext = "";
        q2_choices.SetActive(false);
        q3_choices.SetActive(true);
    }

    public void juan()
    {
        hp_value -= 0;
        snt_value -= 2;
        endtitle = "Question 3";
        endtxt_value.fontSize = 50;
        endtext = "";
        q2_choices.SetActive(false);
        q3_choices.SetActive(true);
    }

    //q3

    public void answer()
    {
        q3_choices.SetActive(false);
        q4_choices.SetActive(true);
    }

    public void decline()
    {
        q3_choices.SetActive(false);
        end4.SetActive(true);
    }

    //q4



    //======================================================================

    public void resetbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
