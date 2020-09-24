using System;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.text = "" + Math.Round(this.playerTransform.position.z);
    }
}
