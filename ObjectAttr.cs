using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectItem
{
    public string key;
    public string objectId;
    public string ownerId;
    public float ownerTime = 0;
    public int frameCnt = 0;

    public Vector3 position = Vector3.zero;
    public Vector3 scale = Vector3.zero;
    public Quaternion rotation = Quaternion.identity;

    [Serializable]
    public class List
    {
        public string myID = "";
        public List<ObjectItem> obList = new List<ObjectItem>();
    }
}



[Serializable]

public class ObjectAttr : MonoBehaviour
{
    public ObjectItem item = new ObjectItem();

    void Update()
    {
        item.objectId = this.name;
        item.position = this.transform.localPosition;
        item.scale = this.transform.localScale;
        item.rotation = this.transform.localRotation;
        
        if(1==1){
        int i=1;
        }else{
        int i=1;
        }
    }


}
