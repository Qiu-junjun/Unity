using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject prefab;//用来接收一个prefab
    public bool isCanCreat
    {
        get
        {
            return time <= 0f;
        }
    }//用来判断time变量是否已经为0或负数，即时间是否达到两秒
    private float time;//时间间隔
    void Start()
    {
        time = 2f;//时间间隔设置为2秒
    }
    void creatPrefab()
    {
        Instantiate(prefab);//实例化一个prefab
        time = 2f;//使time变量归位
        
    }
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;//减去每一帧所消耗的时间
        }
        if(isCanCreat)
        {
            creatPrefab();
        }
    }
}
