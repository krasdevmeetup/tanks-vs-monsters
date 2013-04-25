using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
	public class Tank : MonoBehaviour
	{
		

		public float Speed;
		public float RotationSpeed;

		public void Update()
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				Vector3 dv = new Vector3(0, 0, 1);
				transform.Translate(dv * Speed * Time.deltaTime);
			}

			if (Input.GetKey(KeyCode.DownArrow))
			{
				Vector3 dv = new Vector3(0, 0, -1);
				transform.Translate(dv * Speed * Time.deltaTime);
			}

			if (Input.GetKey(KeyCode.RightArrow))
			{
				transform.RotateAroundLocal(Vector3.up, RotationSpeed*Time.deltaTime);

			}

			if (Input.GetKey(KeyCode.LeftArrow))
			{
				transform.RotateAroundLocal(Vector3.up, -RotationSpeed * Time.deltaTime);
			}

			
		}


	}
}
