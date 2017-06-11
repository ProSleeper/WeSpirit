using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    public GameObject Knight;
    UIButton startbutton;
    int Attack;
    int Defence;

    void Start()
    {
        startbutton = this.GetComponent<UIButton>();
        startbutton.onClick.Add(new EventDelegate(this, "GoBattle"));
    }

    void GoBattle()
    {
        GameObject temp = Instantiate(Knight);
        temp.transform.SetParent(GameObject.Find("Actor").transform);
        temp.transform.localPosition = new Vector3(0, 2, 0);
        SettingStatus(temp);
        
        Destroy(this.transform.parent.gameObject);
    }

    void SettingStatus(GameObject knight)
    {
        GameObject temp = this.transform.parent.FindChild("Inventory").gameObject;
        int totalAP = 0;
        int totalDP = 0;
        for (int i = 0; i < temp.transform.childCount; i++)
        {
            GameObject child = temp.transform.GetChild(i).gameObject;
            if (child.transform.childCount != 0)
            {
                totalAP += child.transform.GetChild(0).GetComponent<BaseItem>().AttackPower;
                totalDP += child.transform.GetChild(0).GetComponent<BaseItem>().DefencePower;
            }
        }

        knight.GetComponentInChildren<Attack>().DAMAGE = totalAP;
        knight.GetComponentInChildren<Attack>().DEFENCE = totalDP;
    }
}
