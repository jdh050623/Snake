using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDel : MonoBehaviour
{
	public void Start()
	{
		StartCoroutine(BoomDelay());

	}
	

	IEnumerator BoomDelay()
	{
		yield return new WaitForSeconds(1.0f);
		
		Destroy(gameObject);
	}
}
