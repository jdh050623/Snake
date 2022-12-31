using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Text : MonoBehaviour
{
    public TextMeshProUGUI t_MaxScore;
    public TextMeshProUGUI t_Score;

    [Header("아이템 내용")]
    public TextMeshProUGUI t_ObtainedItem;
    
    
    
    
    //public TextMeshProUGUI t_damage;

    Color alpha;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t_MaxScore.text = "최고 점수 : " + SnakeController.MaxScore.ToString();
        t_Score.text = "점수 : " + SnakeController.Score.ToString();

        if (SnakeController.changeText == 0)
        {
            t_ObtainedItem.text = "노란 공을 먹어주세요!";
        }

        if (SnakeController.changeText == 1)
        {
            t_ObtainedItem.text = "폭발 증가!";
        }

        if (SnakeController.changeText == 2)
        {
            t_ObtainedItem.text = "추가 점수!!";
        }

        if (SnakeController.changeText == 3)
        {
            t_ObtainedItem.text = "안개 생성!!";
        }

        if (SnakeController.changeText == 4)
        {
            t_ObtainedItem.text = "꼬리 초기화!!!!!";
        }
    }
}
