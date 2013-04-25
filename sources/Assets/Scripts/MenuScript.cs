using UnityEngine;

namespace Assets.Scripts
{
	public class MenuScript : MonoBehaviour 
	{


		public void OnGUI()
		{
			if (GUI.Button(new Rect(0, 0, 100, 50), "Play"))
			{
				Application.LoadLevel("game");
			}
		}
	}
}
