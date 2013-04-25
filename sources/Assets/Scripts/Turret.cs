using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
	public class Turret : MonoBehaviour
	{
		public void Update()
		{
			var screenPoint = Input.mousePosition;
			screenPoint.z = Camera.main.transform.position.y - transform.position.y; //distance of the plane from the camera
			var position = Camera.main.ScreenToWorldPoint(screenPoint);
//			Vector3 position = new Vector3(Input.mousePosition.x,
//			                               0,
//			                               Input.mousePosition.y);
////			Debug.Log("position:" + position);
//			Vector3 worldPosition = Camera.mainCamera.ScreenToWorldPoint(position);
//			Debug.Log("world" + worldPosition);
//			worldPosition = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z);
			transform.LookAt(position);
		}
	}
}
