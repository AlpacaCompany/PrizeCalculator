using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Gm;
    public TextMeshProUGUI TotalText;
    public TextMeshProUGUI Countext;
    public float cost;
    public float count;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Countext.text = "터치 횟수 : " + count.ToString();
        TotalText.text = cost.ToString() + "원"; // 가격 텍스트에 표시
    }

    public void AddPrize(float add) {
        cost += add; //가격 추가
        //TotalText.text = cost.ToString() + "원"; //가격텍스트에 표시
    }
}
