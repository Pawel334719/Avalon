using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VotingManagement : MonoBehaviour {

    public Text t, mainInfotv, info1tv,info2tv;
    int maxVotes;
    Color offColor = new Color(255f, 255f, 255f, 0.27f), onColor = new Color(255f, 255f, 255f, 1f);
    public Button ZgodaButton, SprzeciwButton, VoteButton,task1Button, task2Button, task3Button, task4Button, task5Button;
    public GameObject VoteGameObject, CloseButtonObject, voteLayoutObject;
    bool ismission = false;

    bool myVote = false;
    // Use this for initialization
    void Start() {
        Variables.zgoda = 0;
        Variables.sprzeciw = 0;
        maxVotes = Variables.amountofPlayers;
        ZgodaButton.image.sprite = Resources.Load<Sprite>("zgoda");
        SprzeciwButton.image.sprite = Resources.Load<Sprite>("sprzeciw");
    }

    // Update is called once per frame
    void Update() {

    }

    public void onVoteClick() {
        VoteGameObject.SetActive(false);
        SprzeciwButton.image.color = offColor;
        ZgodaButton.image.color = offColor;
        if (myVote) { Variables.zgoda++; } else Variables.sprzeciw++;
        t.text = "Zagłosowało: " + (Variables.zgoda + Variables.sprzeciw) + " osób z " + maxVotes;
        if ((Variables.zgoda + Variables.sprzeciw) == maxVotes) {
            t.text = "Zgody: " + Variables.zgoda + "\nSprzeciwy: " + Variables.sprzeciw;
            if (ismission) { t.text = "Sukcesów: " + Variables.zgoda + "\nPorażek: " + Variables.sprzeciw; }

            if (ismission && Variables.sprzeciw == 0) {
                setScoreEvli(false);
                CloseButtonObject.active = true;
                return;
            }

            if (ismission && Variables.sprzeciw != 0) {
                bool bool4runda = true;
                if (Variables.runda == 4 && Variables.doubleFail&& Variables.sprzeciw == 1) { bool4runda = false; }
                setScoreEvli(bool4runda);
                CloseButtonObject.active = true;
                return;
            }
            if (Variables.sprzeciw >= Variables.zgoda&&!ismission) {
                t.text += "\n STOP, NIGDZIE NIE IDZIECIE!";
                Variables.votingNumber++;
                updateMainInfotv();
                CloseButtonObject.active = true;
                if (Variables.votingNumber == 5) { endGame(); }
                changeChooser();
                int i = Variables.runda - 1;
                info1tv.text= "Misja " + (i + 1) + "\n" + "Do wykonania misji potrzeba: " + Variables.personNeed[i] + " osób";
                if (i == 3 && Variables.doubleFail) { Variables.taskInfo[i] += "\nW tej misji potrzeba 2 porażek"; }
                return;
            }
            if (Variables.zgoda > Variables.sprzeciw&&!ismission) {
                Variables.zgoda = 0;
                Variables.sprzeciw = 0;
                ZgodaButton.image.sprite = Resources.Load<Sprite>("sukces");
                SprzeciwButton.image.sprite = Resources.Load<Sprite>("przegrana");
                maxVotes = Variables.PersonNeed;
                ismission = true;
                t.text += "\nIdziecie na misje! Powodzenia!";
                return;
            }

        }
    }
    void updateMainInfotv() {
        mainInfotv.text = "misja : " + Variables.runda + "     " + "nieudane głosowania : " + Variables.votingNumber;
    }
    void changeChooser (){
        Variables.beginnerplayer++;
        if (Variables.beginnerplayer > Variables.amountofPlayers) { Variables.beginnerplayer = 0; }
        info2tv.text = Variables.playerName[(Variables.beginnerplayer)] + " wybiera załoge:";
    }
    void setScoreEvli(bool b) {
        if (Variables.runda == 1) { task1Button.image.sprite = Resources.Load<Sprite>("UISprite"); task2Button.image.sprite = Resources.Load<Sprite>("tourmarker"); }
        if (Variables.runda == 2) { task2Button.image.sprite = Resources.Load<Sprite>("UISprite"); task3Button.image.sprite = Resources.Load<Sprite>("tourmarker"); }
        if (Variables.runda == 3) { task3Button.image.sprite = Resources.Load<Sprite>("UISprite"); task4Button.image.sprite = Resources.Load<Sprite>("tourmarker"); }
        if (Variables.runda == 4) { task4Button.image.sprite = Resources.Load<Sprite>("UISprite"); task5Button.image.sprite = Resources.Load<Sprite>("tourmarker"); }
        if (Variables.runda == 1) { task5Button.image.sprite = Resources.Load<Sprite>("UISprite"); }

        Color red = new Color(1f, 0f, 0f, 1f), blue = new Color(0f, 1f, 0f, 1f);
        if (Variables.runda == 1 && b) { task1Button.image.color = red; } else if (Variables.runda == 1 && !b) { task1Button.image.color = blue; }
        if (Variables.runda == 2 && b) { task2Button.image.color = red; } else if (Variables.runda == 2 && !b) { task2Button.image.color = blue; }
        if (Variables.runda == 3 && b) { task3Button.image.color = red; } else if (Variables.runda == 3 && !b) { task3Button.image.color = blue;}
        if (Variables.runda == 4 && b) { task4Button.image.color = red; } else if (Variables.runda == 4 && !b) { task4Button.image.color = blue;}
        if (Variables.runda == 5 && b) { task5Button.image.color = red; } else if (Variables.runda == 5 && !b) { task5Button.image.color = blue;}

        
        Variables.taskInfo[Variables.runda-1]="Misja "+Variables.runda+"\nSukces: " + Variables.zgoda + " Porażka: " + Variables.sprzeciw;
        if (b) { Variables.evilScore++; }else Variables.goodScore++;
        Variables.votingNumber = 0;
        Variables.runda++;
        Variables.PersonNeed = Variables.personNeed[Variables.runda - 1];
        changeChooser();
        updateMainInfotv();
        ismission = false;
    }
    void endGame(){

    }

    public void onCloseButtonClick() {
        Variables.zgoda = 0;
        Variables.sprzeciw = 0;
        maxVotes = Variables.amountofPlayers;
        ZgodaButton.image.sprite = Resources.Load<Sprite>("zgoda");
        SprzeciwButton.image.sprite = Resources.Load<Sprite>("sprzeciw");

        t.text = "Jeszcze nikt nie zagłosował";
        VoteGameObject.SetActive(false);
        SprzeciwButton.image.color = offColor;
        ZgodaButton.image.color = offColor;

        CloseButtonObject.active = false;
        voteLayoutObject.active = false;
    }
    public void onZgodaClick(){
        ZgodaButton.image.color = onColor;
        SprzeciwButton.image.color = offColor;
        VoteGameObject.SetActive(true);
        myVote = true;
    }

    public void onSprzeciwClick(){
        ZgodaButton.image.color = offColor;
        SprzeciwButton.image.color = onColor;
        VoteGameObject.SetActive(true);
        myVote = false;
    }
    
  
}
