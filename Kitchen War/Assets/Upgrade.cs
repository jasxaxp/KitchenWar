using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton;
	public Button m_YourSecondButton;
	public Button m_YourThirdButton;
	public bool upg1 = false;
	public bool upg11 = false;
	public bool upg12 = false;
	public bool upg2 = false;
	public bool upg21 = false;
	public bool upg22 = false;


    public Text saltText;
    public Text pepperText;
    public Text sauceText;
	int Value1 = 5;
	int Value2 = 10; 

    
	


    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(delegate {TaskOnClick("First"); });
        m_YourSecondButton.onClick.AddListener(delegate {TaskOnClick("Second"); });
        m_YourThirdButton.onClick.AddListener(delegate {TaskOnClick("Third"); });

	
		saltText.text = Value1.ToString() + " Upgrade Salt Tower";
		pepperText.text = Value1.ToString() + " Upgrade Pepper Tower";
		sauceText.text = Value1.ToString() + " Upgrade Sauce Tower";
    }


    void TaskOnClick(string message)
    {
        if (message == "First")
		{
			if (upg1 == false)
			{
				upg1 = true;
				GameObject obj = GameObject.FindWithTag("salt shoot");
				obj.GetComponent<Upgrade1>().enabled = true;
				saltText.text = Value2.ToString() + " Upgrade Salt Tower";
			}
			else if (upg2 == false)
			{
				upg2 = true;
				GameObject obj = GameObject.FindWithTag("salt tower");
				obj.GetComponent<Upgrade2>().enabled = true;
				saltText.text = " No more Upgrades Available";
				
			}
		}
		else if (message == "Second")
		{
			if (upg11 == false)
			{
				upg11 = true;
				GameObject obj = GameObject.FindWithTag("pepper shoot");
				obj.GetComponent<Upgrade1>().enabled = true;
				pepperText.text = Value2.ToString() + " Upgrade Pepper Tower";
			}
			else if (upg21 == false)
			{
				upg21 = true;
				GameObject obj = GameObject.FindWithTag("pepper tower");
				obj.GetComponent<Upgrade2>().enabled = true;
				pepperText.text = " No more Upgrades Available";
		}
		else if (message == "Third")
		{
			if (upg12 == false)
			{
				upg12 = true;
				GameObject obj = GameObject.FindWithTag("sauce shoot");
				obj.GetComponent<Upgrade1>().enabled = true;
				sauceText.text = Value2.ToString() + " Upgrade Sauce Tower";
				
			}
			else if (upg22 == false)
			{
				upg22 = true;
				GameObject obj = GameObject.FindWithTag("sauce tower");
				obj.GetComponent<Upgrade2>().enabled = true;
				sauceText.text = " No more Upgrades Available";
				
			}
		}
    }
}
}
