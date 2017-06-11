using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlace : MonoBehaviour
{
    Vector3 CurrentPos;
    Vector3 GoalPos;
    float dTime;



	void Start ()
	{
        CurrentPos = this.transform.localPosition;
        GoalPos = new Vector3(-900, 150, 0);
    }

    private void Update()
    {
        dTime += Time.deltaTime;

        this.transform.localPosition = Vector3.Lerp(CurrentPos, GoalPos, dTime/2);
        if (dTime > 2)
        {
            this.transform.FindChild("Inventory").gameObject.SetActive(true);
            this.transform.FindChild("GoButton").gameObject.SetActive(true);
        }

    }

}
