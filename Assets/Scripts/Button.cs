using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Button : MonoBehaviour
{
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GM.Countext.text.Substring(0, GM.Countext.text.Length - 3 -(GM.count.ToString().Length)));
        Debug.Log(GM.Countext.text.Substring(0, GM.Countext.text.Length - 4).Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn() { //공용 버튼
        var cost = EventSystem.current.currentSelectedGameObject.GetComponent<prize>(); //누른 버튼의 prize컴포넌트 가져오기
        GM.AddPrize(cost.prizes[cost.index]);
        if(GM.Countext.text.Substring(0, GM.Countext.text.Length - 3 -(GM.count.ToString().Length)) == EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TextMeshProUGUI>().text) { //같은 항목이라면
            GM.count++; //갯수 추가
            GM.Countext.text = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TextMeshProUGUI>().text + " : " + GM.count; //터치 개수 표시
        } else { //다른 항목이라면
            GM.count = 1; //개수 초기화
            GM.Countext.text = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TextMeshProUGUI>().text + " : " + GM.count; //터치 개수 표시
        }
    }

    public void AC() { //초기화
        GM.cost = 0;
        GM.count = 0;
        GM.Countext.text = "터치 횟수 : 0";
    }
}
