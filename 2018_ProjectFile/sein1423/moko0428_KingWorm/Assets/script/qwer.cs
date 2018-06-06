using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qwer : MonoBehaviour {

    public GameObject IO;
    public Image loading;
    private bool fillAmount = false;
    private float load = 0.0f;

	public void open()
    {
        IO.SetActive(true);
    }

    public void close()
    {
        IO.SetActive(false);
    }

    public void loadingclick()
    {
        loading_bar();
    }
    public void loading_bar()
    {
            load += 0.1f;
			loading.fillAmount = load;
            if(load >= 1f)
            {
                fillAmount = true;
            }
    }
}
