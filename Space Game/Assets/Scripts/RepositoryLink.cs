using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepositoryLink : MonoBehaviour
{
    [SerializeField] Button button;
 
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenRepository);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Opens up link to repository
    public void OpenRepository()
    {
        Application.OpenURL("https://github.com/Orbitz4k/Game");
    }
}
