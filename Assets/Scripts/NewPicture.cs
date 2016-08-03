using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class NewPicture : MonoBehaviour {
    public string url = Application.dataPath + "/snake.jpg"; //"c:/usc/home/smandler/Desktop/GitHub/usc_cave/snake.jpg";
    private WWW ww;
    public GameObject ImageOnPanel;

    void Start()
    {
         
      //  ww = new WWW(url);
      //  yield return ww;
       // StartGame();
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { StartGame(); });
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

    public void StartGame()
    {

        RawImage image = (RawImage)ImageOnPanel.GetComponent<RawImage>();
        image.texture = LoadPNG(url);
    }
}
