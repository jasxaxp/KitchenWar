using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(delegate {TaskOnClick("First"); });
        m_YourSecondButton.onClick.AddListener(delegate {TaskOnClick("Second"); });
        m_YourThirdButton.onClick.AddListener(delegate {TaskOnClick("Third"); });
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
			}
			else if (upg2 == false)
			{
				upg2 = true;
				GameObject obj = GameObject.FindWithTag("salt tower");
				obj.GetComponent<Upgrade2>().enabled = true;
			}
		}
		else if (message == "Second")
		{
			if (upg11 == false)
			{
				upg11 = true;
				GameObject obj = GameObject.FindWithTag("pepper shoot");
				obj.GetComponent<Upgrade1>().enabled = true;
			}
			else if (upg21 == false)
			{
				upg21 = true;
				GameObject obj = GameObject.FindWithTag("pepper tower");
				obj.GetComponent<Upgrade2>().enabled = true;
			}
		}
		else if (message == "Third")
		{
			if (upg12 == false)
			{
				upg12 = true;
				GameObject obj = GameObject.FindWithTag("sauce shoot");
				obj.GetComponent<Upgrade1>().enabled = true;
			}
			else if (upg22 == false)
			{
				upg22 = true;
				GameObject obj = GameObject.FindWithTag("sauce tower");
				obj.GetComponent<Upgrade2>().enabled = true;
			}
		}
    }
}
