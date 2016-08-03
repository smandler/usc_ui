using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour {
    public InputField input_field;
    public Button but;

    void Start()
    {
        Button b = (Button)but.GetComponent<Button>();
        b.onClick.AddListener(delegate () { ShowField(); });


        //Debug.Log("displays connected: " + Display.displays.Length);
        // Display.displays[0] is the primary, default display and is always ON.
        // Check if additional displays are available and activate each.
        if (Display.displays.Length > 1)
            Display.displays[1].Activate();
        if (Display.displays.Length > 2)
            Display.displays[2].Activate();
        if (Display.displays.Length > 3)
            Display.displays[3].Activate();
    }

    public void ShowField()
    {
        InputField field = (InputField)input_field.GetComponent<InputField>();
        field.gameObject.SetActive(true);
        field.text = "I am active!";
    }
}
