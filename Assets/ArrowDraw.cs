
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;


public class ArrowDraw : MonoBehaviour
{
  
    [SerializeField]UnityEditor.UI.Image arrowImage;
    private Vector3 clickPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 dise=clickPosition-Input.mousePosition;
            Debug.Log(dise);
        }
    }
}
