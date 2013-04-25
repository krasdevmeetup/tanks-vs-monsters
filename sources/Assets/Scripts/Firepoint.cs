using UnityEngine;

namespace Assets.Scripts
{
	public class Firepoint : MonoBehaviour
	{
		private float _lastBulletTime;
		public float BulletDelay;

		public Transform Bullet;

		public void Update()
		{
			if (Input.GetMouseButton(0) && _lastBulletTime + BulletDelay <= Time.time)
			{
				Transform bullet = Instantiate(Bullet, transform.position, transform.rotation) as Transform;
				//bullet.transform.position = transform.position + new Vector3(0, 2.0f, 4.2f);
				_lastBulletTime = Time.time;
			}
		}
	}
}
