using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField]
	private float rotationSpeed = 10f;

	private void FixedUpdate()
	{
		transform.Rotate(new Vector3(0, 0, rotationSpeed));
	}
}
