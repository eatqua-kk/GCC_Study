using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public Image fill;
	public GameObject setting;
	public GameObject disable;

	private float fillFloat = 0.01f;
	private bool isFull = false;
	private bool isActive = false;

	public void ButtonOnClickSetting()
	{
		setting.SetActive (true);
	}


	// Update is called once per frame
	void Update () 
	{
		if (isFull == true)
        {
			return; // 종료
		}

		if (fill.fillAmount == 1)
        {
			isFull = true;
			Debug.Log (isFull);
            setting.SetActive(true);
			disable.SetActive (false);
        }

		Debug.Log (fill.fillAmount);
		fill.fillAmount += fillFloat;
	}
}
