using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour 
{
	public Canvas clickUp;
	//public Canvas perSecondUp;
	//public Canvas optionsMenu;
	public Button cUp;
	//public Button psUp;
	//public Button oP;

	void Start () 
	{
		clickUp = clickUp.GetComponent <Canvas> ();
		cUp = cUp.GetComponent <Button> ();
		cUp.enabled = true;

		//perSecondUp = perSecondUp.GetComponent <Canvas> ();
		//psUp = psUp.GetComponent <Button> ();

		//optionsMenu = optionsMenu.GetComponent <Canvas> ();
		//oP = oP.GetComponent <Button> ();

		clickUp.enabled = false;
		//perSecondUp.enabled = false;
		//optionsMenu.enabled = false;
	}

	public void clickMenuPress ()
	{
		clickUp.enabled = true;
		cUp.enabled = false;
	}
}
