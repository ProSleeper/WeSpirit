using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItem : MonoBehaviour
{
    float dTime;
    Vector3 dVector3;

	void Update()
    {

        dTime += Time.deltaTime;

        dVector3 += Vector3.down * 9.8f * Time.deltaTime * 3;
        this.transform.localPosition += dVector3;

        if (dTime > 3.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
