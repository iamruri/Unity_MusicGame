using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class loadScript : MonoBehaviour
{
    //読み込むテキストが書き込まれている.txtファイル
    [SerializeField]private TextAsset textAsset;
    //テキストファイルから読み込んだデータ
    private string loadText;
    //改行で分割して配列に入れる
    private string[] splitText;
    private string[] splitText2;
    //現在表示中のテキスト
    private int textNum;
    //ループ用変数
    private int x, z;
    public int end;
    //一時的に保持する箱
    private string hozi;
    //ノーツ、ライン、時間の情報を入れる箱
    public int[] note = new int[100];
    public int[] line = new int[100];
    public float[] time = new float[100];

    void Start()
    {
        //txtファイルをloadtextにぶち込む
        loadText = textAsset.text;
        splitText = loadText.Split(char.Parse("\n"));
        textNum = 0;
        //読み込んだテキストファイルの行数をカウント
        var input = loadText;
        var lineCount = input.ToList().Where(c => c.Equals('\n')).Count() + 1;
        z = 0;
        end = 0;
        for (textNum = 0; textNum < lineCount; textNum++)
        {
            hozi = splitText[textNum];
            splitText2 = hozi.Split(',');
            for (x = 0; x < 3; x++)
            {
                if (x == 0)
                {
                    note[z] = int.Parse(splitText2[x]);
                }
                else if (x == 1)
                {
                    line[z] = int.Parse(splitText2[x]);
                }
                else
                {
                    time[z] = float.Parse(splitText2[x]);
                }
            }
            z++;
        }
        end = 1;
    }
}