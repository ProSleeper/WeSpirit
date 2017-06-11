using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDragDropItemOverride : UIDragDropItem
{
    public Sprite Compact;
    public Sprite Detail;

    UI2DSprite MySpriteComponent;

    protected override void OnDragDropMove(Vector2 delta, GameObject surface)
    {
        MySpriteComponent = this.GetComponent<UI2DSprite>();
        mTrans.localPosition += mTrans.InverseTransformDirection((Vector3)delta);

        if (surface.name.Equals("Detail"))
        {
            MySpriteComponent.sprite2D = Detail;
            this.transform.SetParent(surface.transform);
        }
        else if (surface.name.Equals("Compact"))
        {
            MySpriteComponent.sprite2D = Compact;
        }
        else if (surface.name.Equals("Mercenary"))
        {
            MySpriteComponent.sprite2D = Compact;
        }
        else if (surface.name.Contains("Surface"))
        {
            MySpriteComponent.sprite2D = Compact;
        }

        ////this.GetComponent<UIWidget>
        ////MySpriteComponent.

            //this.GetComponent<UIWidget>().MakePixelPerfect();

    }

    protected override void OnDragDropRelease(GameObject surface)
    {
        if (surface != null)
        {
            ExampleDragDropSurface dds = surface.GetComponent<ExampleDragDropSurface>();
            //if (surface.name.Equals("Mercenary"))
            //{
            //    Destroy(this);
            //    this.gameObject.AddComponent<GiveItem>();
            //    this.GetComponent<UIWidget>().depth = 2;
            //}
            if (dds.name.Equals("Mercenary"))
            {
                MySpriteComponent.sprite2D = Compact;
                this.transform.SetParent(dds.transform);
            }
            if (dds.name.Contains("Surface"))
            {
                //this.transform.SetParent(dds.gameObject.transform);
                //GameObject child = NGUITools.AddChild(dds.gameObject, this.gameObject);
                //child.transform.localScale = dds.transform.localScale;

                //Transform trans = child.transform;
                //trans.position = UICamera.lastWorldPosition;

                //if (dds.rotatePlacedObject)
                //{
                //    trans.rotation = Quaternion.LookRotation(UICamera.lastHit.normal) * Quaternion.Euler(90f, 0f, 0f);
                //}


                //if (mButton != null) mButton.isEnabled = true;
                //else if (mCollider != null) mCollider.enabled = true;
                //else if (mCollider2D != null) mCollider2D.enabled = true;

                // Destroy this icon as it's no longer needed
                //NGUITools.Destroy(gameObject);


                MySpriteComponent.sprite2D = Compact;
                this.transform.SetParent(dds.transform);
                this.transform.localPosition = Vector3.zero;

            }

        }
        //base.OnDragDropRelease(this.gameObject);
        if (mCollider != null) mCollider.enabled = true;
        //this.GetComponent<UIButton>().normalSprite2D = MySpriteComponent.sprite2D;
    }


}
