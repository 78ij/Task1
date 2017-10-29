using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonEvent : MonoBehaviour {
    public GameObject start;
    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update () {
		
	}

}
