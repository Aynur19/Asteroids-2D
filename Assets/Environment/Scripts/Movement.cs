using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField]
	private float rotationSpeed = 10f;

	private PlayerInput actions;

	private void Awake()
	{
		actions = new PlayerInput();
	}

	private void OnEnable()
	{
		actions.Enable();
	}

	private void OnDisable()
	{
		actions.Disable();
	}

	private void FixedUpdate()
	{
		var move = actions.Player.Move.ReadValue<Vector2>();

		transform.Rotate(new Vector3(0, 0, -move.x * rotationSpeed));
	}
}
