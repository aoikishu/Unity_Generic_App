using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCreator : MonoBehaviour
{
    public GameObject templatePanelPrefab;
    private GameObject panel;

    public void TogglePanel(bool value)
    {
        panel.SetActive(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        panel = Instantiate(templatePanelPrefab, transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
