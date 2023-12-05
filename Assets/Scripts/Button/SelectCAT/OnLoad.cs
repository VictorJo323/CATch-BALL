using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Script : MonoBehaviour
{
    public GameObject targetObject; // 활성화 또는 비활성화할 대상 GameObject

    void Start()
    {
        bool activateTarget = PlayerPrefs.GetInt("ActivateTarget", 0) == 1;

        if (targetObject != null)
        {
            targetObject.SetActive(activateTarget);
        }
    }
    
}
