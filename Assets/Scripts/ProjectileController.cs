using UnityEngine;

public class ProjectileController : MonoBehaviour
{
	private Rigidbody2D r2D;
	public Vector2 force = new Vector2(50, 0);
	
	private void Awake()
	{
		r2D = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		r2D.AddForce(force);
		Destroy(gameObject, 2);
	}
}
