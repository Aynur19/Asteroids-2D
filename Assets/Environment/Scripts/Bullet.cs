using System.Collections;

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
	private Rigidbody2D rb2D;

	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

	public void Fire()
	{
		rb2D.AddForce(transform.up * Constants.bulletImpulseForce, ForceMode2D.Impulse);

		StartCoroutine(BulletDestroy());
	}

	private IEnumerator BulletDestroy()
	{
		yield return new WaitForSeconds(3.0f);

		if (gameObject != null)
		{
			Destroy(gameObject);
		}
	}
}
