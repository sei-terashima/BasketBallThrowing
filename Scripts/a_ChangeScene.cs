using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a_ChangeScene : MonoBehaviour
{
    public string sceneToLoad = "Title"; // インスペクタから変更可能なシーン名

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad); // 指定されたシーンをロード
    }
}
