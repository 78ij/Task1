using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CameraController: MonoBehaviour
{
    public float time, lasttime;
    public static bool startShake = false;  //camera是否开始震动  
    public static float seconds = 0.4347826f;    //震动持续秒数  
    public static bool started = false;    //是否已经开始震动  
    public static float quake = 0.4f;       //震动系数  
    float size;
    float zero = 0;
    Vector3 originalpos;
    private Vector3 camPOS;  //camera的起始位置  

    // Use this for initialization  
    void Start()
    {
        size = GetComponent<Camera>().orthographicSize;
        time = Time.time;
        lasttime = time;
        camPOS = transform.localPosition;
    }
    void Update()
    {
        if (Time.time > 69)
        {
            if (Time.time - lasttime >= 0.4347826086956522f && started == false)
        {
            started = true;
            lasttime = Time.time;
        }
        if(started == true)
        {
            //GetComponent<Camera>().orthographicSize = Mathf.MoveTowards(
                //    size,  size - 0.1f,
                 //   0.05f);
            transform.localPosition = camPOS + Random.insideUnitSphere * quake;
            if (Time.time - lasttime >= 0.1f)
            {
                started = false;
             //   GetComponent<Camera>().orthographicSize = Mathf.MoveTowards(
                //      size - 0.2f, size,
               //       0.01f);
                transform.localPosition = camPOS;
            }
        }
        }
    }

    // Update is called once per frame  
    void LateUpdate()
    {
     /*   if (startShake)
        {
            transform.localPosition = camPOS + Random.insideUnitSphere * quake;
        }

        if (started)
        {
            StartCoroutine(WaitForSecond(seconds));
            started = false;
        }*/
    }
    /// <summary>  
    /// 外部调用控制camera震动  
    /// </summary>  
    /// <param name="a">震动时间</param>  
    /// <param name="b">震动幅度</param>  
    public static void ShakeFor(float a, float b)
    {
        //      if (startShake)  
        //          return;  
        seconds = a;
        started = true;
        startShake = true;
        quake = b;
    }
    IEnumerator WaitForSecond(float a)
    {
        //      camPOS = transform.position;  

        yield return new WaitForSeconds(a);
        startShake = false;
        transform.localPosition = camPOS;
    }

}