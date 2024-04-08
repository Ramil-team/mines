using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class StaticConfig
{
    static public ElemScripts[,] allElemcastleList = new ElemScripts[3, 6];
    static public float[] percentList = new float[5];
    public static Sprite [] stateCastlePlayList = new Sprite[3];
    public static Sprite[] SweetsCastlePlayList = new Sprite[13];
    //public static Button minusStavka


    public static Text[] mbWinTxt;

    public static OrderItem currentOrderItem;
    //static public float percent = 0;
    public static int valueIncognitoElem;


    public static int currentStreak;
    public static string lastLogin;
    public static bool isRewardGot;

    public static GameObject buyCoin;
    public static GameObject buyHearth;
    public static GameObject miniPause;
    public static GameObject loseWindowCastle;
    public static GameObject loseWindowOrder;
    public static GameObject winWindowOrder;
    public static GameObject winWindowCastle;
    public static Text valueWinCoins;
    public static float nbWin;


    public static GridCastleScript GridCastleScript;

    public static SaveLoadManager SaveLoadManager;

    public static int currentActiveStringCastlePlay = 0;
    //public static float coins = PlayerPrefs.GetFloat("ValueCoin");
    //public static float hearts = PlayerPrefs.GetFloat("ValueHearth");



    //public static float coins = SaveLoadManager.saveStatic.coins;
    //public static float hearts = SaveLoadManager.saveStatic.hearth;

    public static float coins;
    public static float hearts;

    public static bool isWinCastle = false;
    public static bool isWinOrder = false;

    public static AchivmentsControll AchivmentsControll;

    public static float currentStavka = 0;
    public static Text mainWindowCoins;
    public static Text mainWindowHearts;


    public static AchivmentsControll.Achivka[] achievements;

    // public static int a1v;
    // public static int a2v;
    // public static int a3v;
    // public static int a4v;
    //
    // public static bool a1bool;
    // public static bool a2bool;
    // public static bool a3bool;
    // public static bool a4bool;

}
