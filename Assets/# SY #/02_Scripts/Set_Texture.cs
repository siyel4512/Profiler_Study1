using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Set_Texture : MonoBehaviour
{
    public GameObject Raw_Image;
    public Transform Pos;

    public string url;

    // Start is called before the first frame update
    void Start()
    {
        url = Application.streamingAssetsPath;
        Debug.Log(url);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Create();
        }
    }

    private void Create()
    {
        Instantiate(Raw_Image, Pos);
    }
}
