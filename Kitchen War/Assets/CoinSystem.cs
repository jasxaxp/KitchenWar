using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinSystem : MonoBehaviour
{
	public Text scoreText;
	public static int total = 5;
    // Start is called before the first frame update
    void Start()
    {
		scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		scoreText.text = total.ToString();
    }
}
