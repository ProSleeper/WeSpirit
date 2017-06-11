using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComOnButton : MonoBehaviour
{

    public GameObject UIKnight;
    public GameObject UISoldier;

    UIButton startbutton;

	void Start ()
	{
        startbutton = this.GetComponent<UIButton>();
        startbutton.onClick.Add(new EventDelegate(this, "CreateUICharacter"));
	}

    void CreateUICharacter()
    {
        GameObject temp = NGUITools.AddChild(NGUITools.GetRoot(this.gameObject), UIKnight);
        temp.transform.localPosition = new Vector3(-1500, 150, 0);
    }
}
