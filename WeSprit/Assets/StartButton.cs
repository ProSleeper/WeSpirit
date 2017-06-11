using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{

    public GameObject Actor;

    UIButton startbutton;

	void Start ()
	{
        Actor = GameObject.Find("Actor") as GameObject;
        startbutton = this.GetComponent<UIButton>();
        startbutton.onClick.Add(new EventDelegate(this, "SetDirection"));
	}

    void SetDirection()
    {
        Actor.transform.GetChild(0).GetComponentInChildren<Attack>().MoveDirection = -1;
        Actor.transform.GetChild(1).GetComponentInChildren<Attack>().MoveDirection = 1;
    }
}
