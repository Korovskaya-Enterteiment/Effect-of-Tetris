using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisHandler : MonoBehaviour
{
	public GameObject I, J, L, O, S, T, Z;
  public float TetrisSpeed;
  float time;
  GameObject Tetrino;

  // Start is called before the first frame update
  void Start()
	{

  }

    // Update is called once per frame
	void Update()
	{
		time += Time.deltaTime;

		if (time > TetrisSpeed)
		{
      int random = Random.Range(0, 7);

			switch (random)
			{
				case 0:
          Tetrino = I;
          break;

				case 1:
          Tetrino = J;
          break;

				case 2:
          Tetrino = L;
          break;

				case 3:
          Tetrino = O;
          break;

				case 4:
          Tetrino = S;
          break;

				case 5:
          Tetrino = T;
          break;

				case 6:
          Tetrino = Z;
          break;
			}

      Instantiate(Tetrino, transform.position, transform.rotation);

			time = 0;
		}
	}
}
