using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
	private void Update()
	{
		Vector3 m = new Vector3(TotalController.Ins.inGameControls.move.x, 0, TotalController.Ins.inGameControls.move.y) * Time.deltaTime;
		transform.Translate(m);
	}

}
