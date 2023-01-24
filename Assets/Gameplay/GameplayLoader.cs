using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayLoader : MonoBehaviour {

    bool[] isCharacterBool = new bool[10];
    int merlinPlayer=11, assasinPlayer=11, persiwalPlayer=11, morganaPlayer=11, oberonPlayer=11, mordredPlayer=11,enemyPlayer1=33,enemyPlayer2=33,enemyPlayer3=33;
    int maxenemy = 2, currentEnemy = 0,counterPlayerShowed=0,buttononClicks=2;
    public Button showButton;
    public Text infotv,showButtontv;
    public Image cardImage;
    public GameObject Meeting;
    bool publicInfo = true;
    // Use this for initialization
    
    void Start () {
        if (Variables.amountofPlayers >= 7) { maxenemy = 3; }
        if (Variables.amountofPlayers == 10) { maxenemy = 4; }
        int x = 0;
        while (x < 10) {
            isCharacterBool[x] = false;
            x++;
        }
        merlinPlayer = randomNumber(); Debug.Log("Merlin ");
        assasinPlayer = randomNumber();currentEnemy++; Debug.Log(" assasin");
        if (Variables.morganabool) { morganaPlayer = randomNumber(); currentEnemy++; Debug.Log(" morgana"); }
        if (Variables.persiwalbool) { persiwalPlayer = randomNumber(); Debug.Log(" persiwal"); }
        if (Variables.oberonbool) { oberonPlayer = randomNumber(); currentEnemy++; Debug.Log(" oberon"); }
        if (Variables.mordredbool) { mordredPlayer = randomNumber(); currentEnemy++; Debug.Log("mordred "); }
        if (currentEnemy < maxenemy) { enemyPlayer1 = randomNumber(); currentEnemy++; Debug.Log(" evil1"); }
        if (currentEnemy < maxenemy) { enemyPlayer2 = randomNumber(); currentEnemy++; Debug.Log(" evil2"); }
        if (currentEnemy < maxenemy) { enemyPlayer3 = randomNumber(); currentEnemy++; Debug.Log(" evil3"); }
        whichPlayer();

    }

    // Update is called once per frame
    void Update () {
		
	}

    int randomNumber() {
        int i = Variables.amountofPlayers-1;
        int a, b, z;
        while (true) { 
            a = Random.Range(0, 16);
            b = Random.Range(1, 15);
            z = a + b;
        while (z >= i) { z -= i; }
            Debug.Log("int player: "+z);
        if (z == 0) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 1) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 2) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 3) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 4) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 5) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 6) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 7) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 8) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        if (z == 9) { if (!isCharacterBool[z]) { isCharacterBool[z] = true; return z; } }
        }

    }

    void whichPlayer() {
        string s;
        s = Variables.playerName[counterPlayerShowed] + "\nPoznaj swoją tożsamość poprzez kliknięcie 2 razy przycisku poniżej";
        infotv.text = s;
        cardImage.sprite = Resources.Load<Sprite>("rewerskarty");
    }

    void showCharacter() {
        string s,merlinName="",assasinName="",morganaName="",oberonName="",mordredName="",evil1Name="",evil2Name="",evil3Name="";
        merlinName = Variables.playerName[merlinPlayer] + "\n";
        assasinName = Variables.playerName[assasinPlayer] + "\n";
        if (Variables.morganabool) { morganaName= Variables.playerName[morganaPlayer] + "\n"; }
        if (Variables.oberonbool) {oberonName = Variables.playerName[oberonPlayer] + "\n"; }
        if (Variables.mordredbool) { mordredName = Variables.playerName[mordredPlayer] + "\n"; }
        if (enemyPlayer1 != 33) { evil1Name = Variables.playerName[enemyPlayer1] + "\n"; }
        if (enemyPlayer2 != 33) { evil2Name = Variables.playerName[enemyPlayer2] + "\n"; }
        if (enemyPlayer3 != 33) { evil3Name = Variables.playerName[enemyPlayer3] + "\n"; }

        s = "Jesteś zwykłym dobrym!";
        cardImage.sprite = Resources.Load<Sprite>("Good");
        if (counterPlayerShowed == merlinPlayer) {
            s = "Jesteś Merlinem!\n Poplecznikami Mordreda są:\n"+assasinName+morganaName+oberonName+evil1Name+evil2Name+evil3Name;
            cardImage.sprite = Resources.Load<Sprite>("Merlin");
        }
        if (counterPlayerShowed == assasinPlayer) {
            s = "Jesteś Skrytobójcą! \nPozostali poplecznicy mordreda to:\n"+morganaName+mordredName + evil1Name + evil2Name + evil3Name;
            cardImage.sprite = Resources.Load<Sprite>("Assasin");
        }
        if (counterPlayerShowed == persiwalPlayer) {
            s = "Jesteś Persiwalem!\nMerlinem jest: "+merlinName;if (Variables.morganabool) { s += " lub " + morganaName; }
        cardImage.sprite = Resources.Load<Sprite>("Persifal");
        }
        if (counterPlayerShowed == morganaPlayer) {
            s = "Jesteś Morganą!\nPozostali poplecznicy mordreda to:\n"+assasinName+mordredName + evil1Name + evil2Name + evil3Name;;
            cardImage.sprite = Resources.Load<Sprite>("Morgana");
        }
        if (counterPlayerShowed == mordredPlayer) {
            s = "Jesteś Mordredem!\nPozostali poplecznicy mordredato:\n" + morganaName + assasinName + evil1Name + evil2Name + evil3Name;
        cardImage.sprite = Resources.Load<Sprite>("Mordred");
        }
        if (counterPlayerShowed == oberonPlayer) {
            s = "Jesteś Oberonem! nie wiesz kto jest doby ani kto jest zły";
        cardImage.sprite = Resources.Load<Sprite>("Oberon");
        }
        if (counterPlayerShowed == enemyPlayer1) {
            s = "Jesteś Zwykłym złym!\nPozostali poplecznicy mordreda to:\n" + morganaName + mordredName + assasinName + evil2Name + evil3Name;
        cardImage.sprite = Resources.Load<Sprite>("Evil");
        }
        if (counterPlayerShowed == enemyPlayer2) {
            s = "Jesteś Zwykłym złym!\nPozostali poplecznicy mordreda to:\n" + morganaName + mordredName + evil1Name + assasinName + evil3Name;
            cardImage.sprite = Resources.Load<Sprite>("Evil");
        }
        if (counterPlayerShowed == enemyPlayer3) {
            s = "Jesteś Zwykłym złym!\nPozostali poplecznicy mordreda to:\n" + morganaName + mordredName + evil1Name + evil2Name + assasinName;
        cardImage.sprite = Resources.Load<Sprite>("Evil");
        }

        infotv.text = s;
    }

    public void onShowButtonClick() {
        buttononClicks--;
        if (buttononClicks==0){
            if (publicInfo){
                publicInfo = false;
                showCharacter();
                counterPlayerShowed++;
            }
            else {
                publicInfo = true;
                whichPlayer();
                if (counterPlayerShowed == Variables.amountofPlayers) { Meeting.active = false; }
            }
            buttononClicks = 2;
        }
        showButtontv.text = "" +buttononClicks;

    }


}
