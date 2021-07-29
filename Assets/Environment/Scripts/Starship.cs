using UnityEngine;

public class Starship : MonoBehaviour
{
	private PlayerInput actions;
	public Bullet bullet;

	private void Awake()
	{
		actions = new PlayerInput();
		actions.Player.FireBullet.performed += x => BulletFire();
	}

	private void OnEnable()
	{
		actions.Enable();
	}

	private void OnDisable()
	{
		actions.Disable();
	}

	private void BulletFire()
	{
		var starshipPos = transform.position;
		var starshipRot = transform.rotation;
		var newBullet = Instantiate<Bullet>(bullet, new Vector2(starshipPos.x, starshipPos.y), starshipRot); // Quaternion.identity);
		newBullet.Fire();
	}
}
