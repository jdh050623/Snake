using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Text : MonoBehaviour
{
    public TextMeshProUGUI t_MaxScore;
    public TextMeshProUGUI t_Score;

    [Header("������ ����")]
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
        t_MaxScore.text = "�ְ� ���� : " + SnakeController.MaxScore.ToString();
        t_Score.text = "���� : " + SnakeController.Score.ToString();

        if (SnakeController.changeText == 0)
        {
            t_ObtainedItem.text = "��� ���� �Ծ��ּ���!";
        }

        if (SnakeController.changeText == 1)
        {
            t_ObtainedItem.text = "���� ����!";
        }

        if (SnakeController.changeText == 2)
        {
            t_ObtainedItem.text = "�߰� ����!!";
        }

        if (SnakeController.changeText == 3)
        {
            t_ObtainedItem.text = "�Ȱ� ����!!";
        }

        if (SnakeController.changeText == 4)
        {
            t_ObtainedItem.text = "���� �ʱ�ȭ!!!!!";
        }
    }
}
