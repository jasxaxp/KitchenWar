using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSidetoSide : MonoBehaviour
{
	float rotationSpeed = 4f;
    void Start()
    {
		
    }

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
      
        transform.Rotate(Vector3.down, XaxisRotation);
    }
}
