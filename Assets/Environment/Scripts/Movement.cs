using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
	[SerializeField]
	private float rotationSpeed = 2f;

	[SerializeField]
	private float moveSpeed = 2f;

	private PlayerInput actions;
	private Rigidbody2D rb2D;

	private void Awake()
	{
		actions = new PlayerInput();
		actions.Player.Fire.performed += x => Check();
	}

	private void Check()
	{
		rb2D.velocity = new Vector2(0f, 0f);
	}

	private void OnEnable()
	{
		actions.Enable();
	}

	private void OnDisable()
	{
		actions.Disable();
	}

	private void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		var move = actions.Player.Move.ReadValue<Vector2>();

		if (move.y > 0f)
		{
			rb2D.AddForce(transform.up * 5);
		}
		rb2D.AddTorque(-move.x * rotationSpeed);
	}
}
