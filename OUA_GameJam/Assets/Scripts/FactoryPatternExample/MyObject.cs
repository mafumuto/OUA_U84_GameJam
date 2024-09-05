using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour, IMyObject
{
    /*
     * �zel nesne
     * burada �rnek olmas� i�in sadece hepsinde isim �zelli�i var ba�ka bir �ey de olabilir
     */
    [SerializeField] private string Fname = "Special Object";
    public string MyObjectName { get => Fname; set => Fname=value; }

    //private ParticleSystem myParticleSystem;

    public void Initialize()
    {
        gameObject.name = MyObjectName;
        /*
        myParticleSystem = GetComponentInChildren<ParticleSystem>();
        myParticleSystem?.Stop();
        myParticleSystem?.Play();
        */
    }
}
