using UnityEngine;
using System.Collections;

public class DinoController : MonoBehaviour
{
    private InstantTrackerController _trackerController;
    private GameObject _buttonsParent;

	// Use this for initialization
	void Start ()
	{
	    _trackerController = GameObject.Find("Controller").gameObject.GetComponent<InstantTrackerController>();
	    _buttonsParent = GameObject.Find("Buttons Parent");

	    _trackerController._gridRenderer.enabled = false;
        _buttonsParent.SetActive(false);
	}

    void OnEnable()
    {
        _trackerController._gridRenderer.enabled = false;
        _buttonsParent.SetActive(false);
    }

    void OnDisable()
    {
        _buttonsParent.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
