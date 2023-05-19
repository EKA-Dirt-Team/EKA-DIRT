using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comic : MonoBehaviour
{
	public Sprite vol1;
	public Sprite vol3;
	public Sprite vol2;
	public Button first;
	private int slaids = 0;

	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void ChangeButtonImage()
	{
		slaids += 1;
		if (slaids == 1)
		{
			first.image.sprite = vol1;
		}
		
		if (slaids == 2)
		{
			first.image.sprite = vol3;
		}
		if (slaids == 3)
		{
			first.image.sprite = vol2;
		}

		if (slaids == 4)
		{
			SceneManager.LoadScene("dads");
		}
	}
}
