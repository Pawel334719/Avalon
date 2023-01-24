using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    public static bool morganabool = false, oberonbool = false, persiwalbool = false, mordredbool = false;
    public static int amountofPlayers, beginnerplayer=0;
    public static string[] playerName = new string[10];

    public static int zgoda, sprzeciw;
    public static int goodScore = 0, evilScore = 0, PersonNeed,runda = 1, votingNumber = 0;
    public static string[] taskInfo = new string[5];
    public static bool doubleFail;
    public static int[] personNeed = new int[5];

}
