using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class loadPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tip;
    private GameObject Tip;
    private GameObject talk;
    private GameObject talk1;

    public Button send;
    public Canvas Canvas;
    void Start()
    {
        send.onClick.AddListener(loadTalking);
    }
    private void loadPrefabs(GameObject prefab,GameObject gameObject)
    {
        gameObject = Instantiate(prefab);
        gameObject.transform.SetParent(Canvas.transform, false);
    }//用来动态加载一个预制体，并将其设置为画布的子物体
    void loadTalking()
    {
        loadPrefabs(tip, Tip);
    }
}
