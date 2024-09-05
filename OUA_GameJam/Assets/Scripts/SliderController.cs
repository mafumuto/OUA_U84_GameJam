using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float distanceValue;
    public float increaseAmount=0.9f;
    public Image image;
    //public Button button;
    public Vector3 deneme;
    public delegate float SuccesArea();
    public static event SuccesArea Successful;

    [Header("Rastgele Konum Aralýklarý")]
    public float
        minPos = 10.0f,
        maxPos = 90.0f,
        minHeight = 40.0f,
        maxHeight = 70.0f;
    [SerializeField] private float randomPos = 10.0f;
    [SerializeField] private float randomHeight= 50.0f;
    [SerializeField] private Rect imageRect;
    [SerializeField] public float successDist=25.0f;
    [SerializeField] private Vector3 imagePos;
    public RectTransform imageRectTransform;


    // Start is called before the first frame update
    void Start()
    {
        imageRectTransform = image.GetComponent<RectTransform>();
        slider.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void EnableSlider()
    {
        slider.gameObject.SetActive(true);
    }

    public void DisableSlider()
    {
        slider.gameObject.SetActive(false);
    }

    public void UpdateAmount()
    {
        //_slider = slider;
        slider.value += increaseAmount * Time.fixedDeltaTime;
    }
    public float GetDistanceValue()
    {
        distanceValue = Vector3.Distance(transform.position, image.transform.position);
        return distanceValue;
    }

    public void ResetSliderValue()
    {
        slider.value = 0;
    }
    public void RandomizeSuccessArea()
    {
        randomPos = UnityEngine.Random.Range(minPos, maxPos);
        randomHeight = UnityEngine.Random.Range(minHeight, maxHeight);
        imageRect = imageRectTransform.rect;
        /*
        imageRect.y = randomPos;
        imageRect.height = randomHeight;
        successDist = imageRect.height / 2;
        bu þekilde olmuyor
        */
        deneme.Set(imageRectTransform.anchoredPosition3D.x, randomPos, imageRectTransform.anchoredPosition3D.z);
        imageRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, randomHeight);
        imageRectTransform.SetLocalPositionAndRotation(deneme, Quaternion.identity);
        successDist = randomHeight / 2;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SuccessArea"))
        {
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
