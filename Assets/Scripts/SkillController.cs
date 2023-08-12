using UnityEngine;

public class SkillController : MonoBehaviour
{
    private void Update()
    {
		if (Input.GetKeyDown(KeyCode.F))
		{
			GameplayEvents.OnProjectileRequested?.Invoke(transform.position + transform.forward);
		}
    }
}
