using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class comic : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }
	
	public Sprite vol1;
	public Sprite vol3;
	public Sprite vol2;
	public Button first;
	private int slaids = 0;
	public Button imagedisplay;

	
	
	public void ChangeButtonImage()
	{
		slaids += 1;
		switch (slaids)
		{
			case 1:
				imagedisplay.image.sprite = vol1;
				break;
			case 2:
				imagedisplay.image.sprite = vol3;
				break;
			case 3:
				imagedisplay.image.sprite = vol2;
				break;
			case 4:
				StartCoroutine(FadeOut());
				break;
		}

	}

	private IEnumerator FadeOut()
	{
		for (float t = 0; t <= 1; t += Time.deltaTime)
		{
			Color newColor = imagedisplay.image.color;
			newColor.a = Mathf.Lerp(1, 0, t);
			imagedisplay.image.color = newColor;
			yield return null;
		}

		SceneManager.LoadScene("forestlvl");
	}
}
