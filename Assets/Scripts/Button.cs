using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn() { //공용 버튼
        var cost = EventSystem.current.currentSelectedGameObject.GetComponent<prize>(); //누른 버튼의 prize컴포넌트 가져오기
        GM.AddPrize(cost.prizes[cost.index]);
    }

    public void AC() { //초기화
        GM.cost = 0;
    }
}
