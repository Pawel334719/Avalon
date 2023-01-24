using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerEnterMenager : MonoBehaviour {

    public Button goButton, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10;
    public InputField player1if, player2if, player3if, player4if, player5if, player6if, player7if, player8if, player9if, player10if;
    public static int amountofPlayers=0,beginnerplayer=0;


    // Use this for initialization
    void Start () {
        goButton.interactable = false;
        player6if.interactable = false;
        player7if.interactable = false;
        player8if.interactable = false;
        player9if.interactable = false;
        player10if.interactable = false;
        i6.interactable = false;
        i7.interactable = false;
        i8.interactable = false;
        i9.interactable = false;
        i10.interactable = false;
       
    }

    // Update is called once per frame
    void Update () {
        if (player1if.text != "" && player2if.text != "" && player3if.text != "" && player4if.text != "" && player5if.text != "") {
            player6if.interactable = true;
            goButton.interactable = true;
            
        }
        if (player6if.text != "") {
            player7if.interactable = true;
            i6.interactable = true;
            
        }
        if (player7if.text != "") {
            player8if.interactable = true;
            i7.interactable = true;
        }
        if (player8if.text != "") {
            player9if.interactable = true;
            i8.interactable = true;

        }
        if (player9if.text != "") {
            player10if.interactable = true;
            i9.interactable = true;
        }
        if (player10if.text != "") {
            i10.interactable = true;

        }
    }
    public void onGoClick() {
        if (player1if.text != "") amountofPlayers++;
        if (player2if.text != "") amountofPlayers++;
        if (player3if.text != "") amountofPlayers++;
        if (player4if.text != "") amountofPlayers++;
        if (player5if.text != "") amountofPlayers++;
        if (player6if.text != "") amountofPlayers++;
        if (player7if.text != "") amountofPlayers++;
        if (player8if.text != "") amountofPlayers++;
        if (player9if.text != "") amountofPlayers++;
        if (player10if.text != "") amountofPlayers++;

        Variables.playerName[0] = player1if.text;
        Variables.playerName[1] = player2if.text;
        Variables.playerName[2] = player3if.text;
        Variables.playerName[3] = player4if.text;
        Variables.playerName[4] = player5if.text;
        Variables.playerName[5] = player6if.text;
        Variables.playerName[6] = player7if.text;
        Variables.playerName[7] = player8if.text;
        Variables.playerName[8] = player9if.text;
        Variables.playerName[9] = player10if.text;
        Variables.amountofPlayers = amountofPlayers;
        Variables.beginnerplayer = beginnerplayer;
        Debug.Log("players:" + amountofPlayers);
        Debug.Log("players:" + Variables.amountofPlayers);
        SceneManager.LoadScene("ChooseCharacter");
    }
    public void setBeginnerPlayer1() { beginnerplayer = 0;reloadImages(beginnerplayer); }
    public void setBeginnerPlayer2() { beginnerplayer = 1; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer3() { beginnerplayer = 2; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer4() { beginnerplayer = 3; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer5() { beginnerplayer = 4; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer6() { beginnerplayer = 5; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer7() { beginnerplayer = 6; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer8() { beginnerplayer = 7; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer9() { beginnerplayer = 8; reloadImages(beginnerplayer); }
    public void setBeginnerPlayer10() { beginnerplayer = 9; reloadImages(beginnerplayer); }

    void reloadImages(int i) {
        if (i == 0) { i1.image.sprite = Resources.Load<Sprite>("FirstPlayer"); }else { i1.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 1) { i2.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i2.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 2) { i3.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i3.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 3) { i4.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i4.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 4) { i5.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i5.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 5) { i6.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i6.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 6) { i7.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i7.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 7) { i8.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i8.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 8) { i9.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i9.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        if (i == 9) { i10.image.sprite = Resources.Load<Sprite>("FirstPlayer"); } else { i10.image.sprite = Resources.Load<Sprite>("noFirstPlayer"); }
        Variables.beginnerplayer = i;
    }
}
