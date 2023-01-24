using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoodeCharacter : MonoBehaviour {

    public Button b1, b2, b3, b4, b5, b6;
    Color offColor = new Color(255f, 255f, 255f, 0.27f), onColor = new Color(255f, 255f, 255f, 1f);
    int maxenemy=2,currentEnemy=1;

    private void Start()
    {
        if (Variables.amountofPlayers >= 7) { maxenemy = 3; }
        if (Variables.amountofPlayers == 10) { maxenemy = 4; }
        int i;
        i = PlayerPrefs.GetInt("activeb3", 0);
        if (i == 1) { Variables.persiwalbool = true; } else { Variables.persiwalbool = false; }
        i = PlayerPrefs.GetInt("activeb4", 0);
        if (i == 1) { Variables.morganabool = true; } else { Variables.morganabool = false; }
        i = PlayerPrefs.GetInt("activeb5", 0);
        if (i == 1) { Variables.oberonbool = true; } else { Variables.oberonbool = false; }
        i = PlayerPrefs.GetInt("activeb6", 0);
        if (i == 1) { Variables.mordredbool = true; } else { Variables.mordredbool = false; }
        Load();
        
    }
    void Load()
    {
        if (Variables.persiwalbool) { b3.image.color = onColor; } else { b3.image.color = offColor; }
        if (Variables.morganabool) { b4.image.color = onColor; } else { b4.image.color = offColor; }
        if (Variables.oberonbool) { b5.image.color = onColor; } else { b5.image.color = offColor; }
        if (Variables.mordredbool) { b6.image.color = onColor; } else { b6.image.color = offColor; }
    }
    public void onClickb1()
    {

    }
    public void onClickb2()
    {

    }
    public void onClickb3()
    {
        if (Variables.persiwalbool)
        {
            b3.image.color = offColor;
            Variables.persiwalbool = false;
        }
        else
        {
                b3.image.color = onColor;
                Variables.persiwalbool = true;
        }
    }
    public void onClickb4()
    {
        if (Variables.morganabool)
        {
            b4.image.color = offColor;
            Variables.morganabool = false;
            currentEnemy--;
        }
        else
        {
            if (currentEnemy < maxenemy)
            {
                b4.image.color = onColor;
                Variables.morganabool = true;
                currentEnemy++;
            }
        }
    }
    public void onClickb5()
    {
        if (Variables.oberonbool)
        {
            b5.image.color = offColor;
            Variables.oberonbool = false;
            currentEnemy--;
        }
        else
        {
            if (currentEnemy < maxenemy)
            {
                b5.image.color = onColor;
                Variables.oberonbool = true;
                currentEnemy++;
            }
        }
    }
    public void onClickb6()
    {
        if (Variables.mordredbool)
        {
            b6.image.color = offColor;
            Variables.mordredbool = false;
            currentEnemy--;
        }
        else
        {
            if (currentEnemy < maxenemy)
            {
                b6.image.color = onColor;
                Variables.mordredbool = true;
                currentEnemy++;
            }
        }
    }

    public void listen()
    {
       /* if (Variables.persiwalbool) { PlayerPrefs.SetInt("activeb3", 1); } else { PlayerPrefs.SetInt("activeb3", 0); }
        if (Variables.morganabool) { PlayerPrefs.SetInt("activeb4", 1); } else { PlayerPrefs.SetInt("activeb4", 0); }
        if (Variables.oberonbool) { PlayerPrefs.SetInt("activeb5", 1); } else { PlayerPrefs.SetInt("activeb5", 0); }
        if (Variables.mordredbool) { PlayerPrefs.SetInt("activeb6", 1); } else { PlayerPrefs.SetInt("activeb6", 0); }*/
        SceneManager.LoadScene("Gameplay");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("EnterPlayer");
    }

}
