using UnityEngine;

public class MouseListener : MonoBehaviour
{

    private GameObject[] guiObjects;

    // Start is called before the first frame update
    void Start()
    {
        guiObjects = GameObject.FindGameObjectsWithTag("GUI");
        foreach(GameObject gui in guiObjects)
        {
            gui.AddComponent(typeof(MouseListnerEvents));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
