using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
	public class Bullet : MonoBehaviour
	{
		public float Speed;

		public void Update()
		{
			Vector3 dv = new Vector3(0, -0.1f, 1);
			transform.Translate(dv*Time.deltaTime*Speed);
		}
	}
}
