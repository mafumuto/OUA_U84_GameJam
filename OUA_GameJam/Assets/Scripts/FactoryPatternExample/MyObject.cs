using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour, IMyObject
{
    /*
     * Özel nesne
     * burada örnek olmasý için sadece hepsinde isim özelliði var baþka bir þey de olabilir
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
