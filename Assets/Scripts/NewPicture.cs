using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class NewPicture : MonoBehaviour {
    public string url = Application.dataPath + "/snake.jpg"; //"c:/usc/home/smandler/Desktop/GitHub/usc_cave/snake.jpg";
    public GameObject ImageOnPanel;

    void Start()
    {
         
      //  ww = new WWW(url);
      //  yield return ww;
       // StartGame();
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { LoadPicture(); });
    }

    public static Texture2D LoadPNG(string filePath)
    {

        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }

    public void LoadPicture()
    {

        RawImage image = (RawImage)ImageOnPanel.GetComponent<RawImage>();
        image.texture = LoadPNG(url);
    }
}
