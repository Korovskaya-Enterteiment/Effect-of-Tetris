using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
  public Camera Cam;

  // Start is called before the first frame update
  void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
      RaycastHit hit;

      if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit)
				&& hit.transform.name != "Scene"
			)
      {
        Destroy(hit.transform.gameObject);
      }
    }
	}
}
