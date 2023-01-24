using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public Button p0,p1, p2, p3, p4, p5, p6, p7, p8, p9,task1Button,task2Button,task3Button,task4Button,task5Button,goVoteButton;
    public Text infotv, info2tv,mainInfotv, taskButton1tv, taskButton2tv, taskButton3tv,taskButton4tv, taskButton5tv;
    public Text t0,t1, t2, t3, t4, t5, t6, t7, t8, t9;
    public GameObject b6, b7, b8, b9, b10,votingLayout, ClosingButtonObject;

    Color offColor = new Color(255f, 255f, 255f, 1f), onColor = new Color(0.28125f,0.90625f,0.8046875f,1f);// new Color(72f, 232f, 206f, 1f);
    bool[] playerSelected = new bool[10];
    bool doubleFail = false;
    int personSelected = 0, PersonNeed, runda, votingNumber;
    
    
    
    // Use this for initialization
    void Start () {
        runda = Variables.runda;
        votingNumber = Variables.votingNumber;
        goVoteButton.interactable = false;
        int i = 0;
        while (i < 10) { playerSelected[i] = false;i++; }
        t0.text = Variables.playerName[0];
        t1.text = Variables.playerName[1];
        t2.text = Variables.playerName[2];
        t3.text = Variables.playerName[3];
        t4.text = Variables.playerName[4];
        i = Variables.amountofPlayers;
        if (i >= 6) { t5.text = Variables.playerName[5]; } else { b6.active = false; }
        if (i >= 7) { t6.text = Variables.playerName[6]; } else { b7.active = false; }
        if (i >= 8) { t7.text = Variables.playerName[7]; } else { b8.active = false; }
        if (i >= 9) { t8.text = Variables.playerName[8]; } else { b9.active = false; }
        if (i == 10) { t9.text = Variables.playerName[9]; } else { b10.active = false; }
        if (i == 5) { Variables.personNeed[0] = 2; Variables.personNeed[1] = 3; Variables.personNeed[2] = 2; Variables.personNeed[3] = 3; Variables.personNeed[4] = 3; }
        if (i == 6) { Variables.personNeed[0] = 2; Variables.personNeed[1] = 3; Variables.personNeed[2] = 4; Variables.personNeed[3] = 3; Variables.personNeed[4] = 4; }
        if (i == 7) { Variables.personNeed[0] = 2; Variables.personNeed[1] = 3; Variables.personNeed[2] = 3; Variables.personNeed[3] = 4; Variables.personNeed[4] = 4; doubleFail = true; }
        if (i >= 8) { Variables.personNeed[0] = 3; Variables.personNeed[1] = 4; Variables.personNeed[2] = 4; Variables.personNeed[3] = 5; Variables.personNeed[4] = 5; doubleFail = true; }
        Variables.PersonNeed = Variables.personNeed[0];
        //PersonNeed = personNeed[0];
        taskButton1tv.text = Variables.personNeed[0] + "";
        taskButton2tv.text = Variables.personNeed[1] + "";
        taskButton3tv.text = Variables.personNeed[2] + "";
        taskButton4tv.text = Variables.personNeed[3] + "";
        taskButton5tv.text = Variables.personNeed[4] + "";
        if (doubleFail) { taskButton4tv.text += "''"; }
        Variables.doubleFail = doubleFail;

        i = 0;//ZMIANA WARTOSCI I!!!
        while (i < 5) {
            Variables.taskInfo[i] = "Misja " + (i + 1) + "\n" +"Do wykonania misji potrzeba: "+Variables.personNeed[i]+" osób";
            if (i == 3 && doubleFail) { Variables.taskInfo[i] += "\nW tej misji potrzeba 2 porażek"; }
            i++;
        }
        info2tv.text = Variables.playerName[(Variables.beginnerplayer)] +" wybiera załoge:";
        updateMainInfotv(0);
        onTask1Click();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void updateMainInfotv(int i) {
        mainInfotv.text ="misja : " + Variables.runda + "     " + "nieudane głosowania : " + Variables.votingNumber;
    }


    public void onTask1Click() { infotv.text = Variables.taskInfo[0]; }
    public void onTask2Click() { infotv.text = Variables.taskInfo[1]; }
    public void onTask3Click() { infotv.text = Variables.taskInfo[2]; }
    public void onTask4Click() { infotv.text = Variables.taskInfo[3]; }
    public void onTask5Click() { infotv.text = Variables.taskInfo[4]; }

    public void onPlayerButton0Click() {
        int i = 0;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p0.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p0.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton1Click() {
        int i = 1;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p1.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p1.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton2Click() {
        int i = 2;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p2.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p2.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton3Click() {
        int i = 3;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p3.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p3.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton4Click() {
        int i = 4;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p4.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p4.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton5Click() {
        int i = 5;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p5.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p5.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton6Click() {
        int i = 6;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p6.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p6.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton7Click() {
        int i = 7;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p7.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p7.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton8Click() {
        int i = 8;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p8.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p8.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }
    public void onPlayerButton9Click() {
        int i = 9;
        if (playerSelected[i] == false) {
            if (personSelected < Variables.PersonNeed) { 
            playerSelected[i] = true;
            p9.image.color = onColor;
            personSelected++;
            }
        }
        else {
            playerSelected[i] = false;
            p9.image.color = offColor;
            personSelected--;
        }
        if (personSelected == Variables.PersonNeed) { goVoteButton.interactable = true; } else goVoteButton.interactable = false;
    }

    public void onVoteButtonClick() {
        string s = "Misja "+Variables.runda+":\n";
        int z = 0, counter = 0; ;
        while (z < 10) { 
        if (playerSelected[z]){ playerSelected[z] = false; s += Variables.playerName[z];counter++; if (counter < Variables.PersonNeed) { s += ", "; } }
            z++;
        }
        infotv.text = s;
        p0.image.color = offColor;
        p1.image.color = offColor;
        p2.image.color = offColor;
        p3.image.color = offColor;
        p4.image.color = offColor;
        p5.image.color = offColor;
        p6.image.color = offColor;
        p7.image.color = offColor;
        p8.image.color = offColor;
        p9.image.color = offColor;
        personSelected = 0;
        //infotv.text = Variables.taskInfo[(Variables.runda-1)];
        votingLayout.active = true;
        goVoteButton.interactable = false;
        //ClosingButtonObject.active = false;

    }

    public void nieudanyVoting() {

    }
    public void evilWin() {

    }
    public void goodWin() {

    }
}
