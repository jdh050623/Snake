using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSegment : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TagChange());
    }
    void Update()
    {
        if (SnakeController.p_SegmentDel)
        {
            Debug.Log("²¿¸®ÆÄ±«!!!");
            Destroy(gameObject);      
        }
    }
    IEnumerator TagChange()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.tag = "Segment";
    }
}
