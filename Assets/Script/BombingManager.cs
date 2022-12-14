using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombingManager : MonoBehaviour
{
    public int bombsNumber; //Æø°ÝÀÇ ¼ö
    public GameObject boom;
    bool BombOff;

    void Update()
    {
        if (!BombOff)
        {
            BombOff = true;
            BombMaking();
            StartCoroutine("BombDelay");
        }
    }
    private void BombMaking()
    {
        for (int i = 0; i < bombsNumber; i++)
        {
            Instantiate(boom);
        }

    }

    IEnumerator BombDelay()
    {
        yield return new WaitForSeconds(3.0f);
        BombOff = false;

    }
}
