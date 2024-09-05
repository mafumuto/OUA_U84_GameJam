using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;


public class ObjectPool : MonoBehaviour
{
    /*
     * hiçbir þey anlamadým
     */
    private RevisedProjectile projectilePrefab;
    [SerializeField] private uint initPoolSize;
    private IObjectPool<RevisedProjectile> objectPool;

    // throw an exception if we try to return an existing item, already in the pool
    [SerializeField] private bool collectionCheck=true;
    // extra options to control the pool capacity and maximum size
    [SerializeField] private int defaultCapacity = 20;
    [SerializeField] private int maxSize = 100;

    private void Awake()
    {
        objectPool = new UnityEngine.Pool.ObjectPool<RevisedProjectile>(CreateProjectile,
        OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
        collectionCheck, defaultCapacity, maxSize);
    }
    // invoked when creating an item to populate the object pool
    private RevisedProjectile CreateProjectile()
    {
        RevisedProjectile projectileInstance = Instantiate<RevisedProjectile>(projectilePrefab);
        projectileInstance.ObjectPool = objectPool;
        return projectileInstance;
    }
    // invoked when returning an item to the object pool
    private void OnReleaseToPool(RevisedProjectile pooledObject)
    {
        pooledObject.gameObject.SetActive(false);
    }
    // invoked when retrieving the next item from the object pool
    private void OnGetFromPool(RevisedProjectile pooledObject)
    {
        pooledObject.gameObject.SetActive(true);
    }
    // invoked when we exceed the maximum number of pooled items (i.e. destroy the pooled object)
 private void OnDestroyPooledObject(RevisedProjectile pooledObject)
    {
        Destroy(pooledObject.gameObject);
    }
}

public class RevisedProjectile : MonoBehaviour
{

    private IObjectPool<RevisedProjectile> objectPool;
    // public property to give the projectile a reference to its ObjectPool
    public IObjectPool<RevisedProjectile> ObjectPool { set => objectPool = value; }
 
}
