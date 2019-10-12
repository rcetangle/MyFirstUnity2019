using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
	public Transform hourTransform;
	public Transform minutTransform;
	public Transform secTransform;
    // Start is called before the first frame update
    void Start()
    {
     	Debug.Log("START"+DateTime.Now.Hour);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
