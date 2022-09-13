using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Gm;
    public TextMeshProUGUI TotalText;
    public float cost;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TotalText.text = cost.ToString() + "원";
    }

    public void AddPrize(float add) {
        cost += add; //가격 추가
        TotalText.text = cost.ToString() + "원";
    }
}
