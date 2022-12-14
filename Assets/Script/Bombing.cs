using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{
	[SerializeField]
	private BoxCollider2D mapCollider2D;

    public void Start()
    {		
		SetupRandomPosition();
		StartCoroutine(BombDelay());

	}
	/*void Start()
	{
		StartCoroutine(Del());
	}
	IEnumerator Del()
	{
		yield return new WaitForSeconds(0.3f);
		Destroy(gameObject);
	}*/
	private void SetupRandomPosition()
	{
		Bounds bounds = mapCollider2D.bounds;

		int x = UnityEngine.Random.Range(-7, 7);//(int)bounds.min.x, (int)bounds.max.x + 1);
		int y = UnityEngine.Random.Range(-7, 7);//(int)bounds.min.y, (int)bounds.max.y + 1);
		Debug.Log(x);
		Debug.Log(y);
		transform.position = new Vector2(x, y);
	}

	IEnumerator BombDelay()
    {
		yield return new WaitForSeconds(3.0f);
		Destroy(gameObject);
	}
}
