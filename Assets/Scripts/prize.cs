using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class prize : MonoBehaviour
{
    public int index = 0;
    public float[] prizes = new float[3];
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(dropdown == null) { //dropdown 컴포넌트가 없다면
            index = 0; //인덱스는 0 -> 선택지가 없는 버튼 ex) 소주, 맥주
        } else { //있다면
            index = dropdown.value; //인덱스는 벨류(선택지의 인덱스)
        }
        
    }
}
