using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyFactory : AMyFactory
{
    [SerializeField] MyObject myObjectPrefab;

    public override void AddMyObjectsToDic(IMyObject myObject)
    {
        myObjectDic.Add(myObject.MyObjectName, myObject);
    }

    public override IMyObject GetMyObject(Vector3 position)
    {
        // create a Prefab instance and get the product component
        GameObject instance = Instantiate(myObjectPrefab.gameObject,
       position, Quaternion.identity);
        MyObject newProduct = instance.GetComponent<MyObject>();
        // each product contains its own logic
        newProduct.Initialize();
        return newProduct;
    }


}
