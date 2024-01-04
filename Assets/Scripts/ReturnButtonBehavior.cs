using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReturnButtonBehaviour : MonoBehaviour {
	[SerializeField] private Button yourButton;
    [SerializeField] private GameObject my_go;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		//Debug.Log ("You have clicked the button!");
        my_go.SetActive(false);
	}
}