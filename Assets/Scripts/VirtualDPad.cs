using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://stackoverflow.com/questions/38565746/tap-detection-on-a-gameobject-in-unity
//https://forum.unity.com/threads/replace-void-onmousedown-for-android.891394/
public class VirtualDPad : MonoBehaviour
{
    //public Text directionText;
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;
    public static string direction;

	// Update is called once per frame
	void Update()
    {
		for (int i = 0; i < Input.touchCount; i++)
		{
			theTouch = Input.GetTouch(i);

			if (theTouch.phase == TouchPhase.Began)
			{
				touchStartPosition = theTouch.position;
				Debug.Log("Touched");
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

				if (hit != null && hit.collider != null)
				{
					Debug.Log("Something Hit by i:" + i + hit.collider.name);
					if (hit.collider.CompareTag("HiddenObjectTag"))
					{
						//SendMessage is bad?
						//hit.collider.gameObject.SendMessage("onItemTouched", SendMessageOptions.DontRequireReceiver);
						//GetComponent instead
						hit.collider.gameObject.GetComponent<ClickControl>().onItemTouched();
					}


					//GameObject.Find(hit.collider.gameObject.name) -> onItemTouched();
				}
			}

			else if (theTouch.phase == TouchPhase.Ended) //theTouch.phase == TouchPhase.Moved ||
			{
				touchEndPosition = theTouch.position;

				float x = touchEndPosition.x - touchStartPosition.x;
				float y = touchEndPosition.y - touchStartPosition.y;

				if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
				{
					direction = "Tapped";
				}

				else if (Mathf.Abs(x) > Mathf.Abs(y))
				{
					direction = x > 0 ? "Right" : "Left";
				}

				else
				{
					direction = y > 0 ? "Up" : "Down";
				}
			}
		}
	}
}
