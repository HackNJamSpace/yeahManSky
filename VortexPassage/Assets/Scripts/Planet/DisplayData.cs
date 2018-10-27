using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour {

	public Text title, description;
    public bool showCanvas;
    Animator anim;
    public GameObject infoCanvas;

    void Start()
    {
        showCanvas = false;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("open", showCanvas);
    }

}
