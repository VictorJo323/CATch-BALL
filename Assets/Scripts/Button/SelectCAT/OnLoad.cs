using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Script : MonoBehaviour
{
    public GameObject targetObject; // Ȱ��ȭ �Ǵ� ��Ȱ��ȭ�� ��� GameObject

    void Start()
    {
        bool activateTarget = PlayerPrefs.GetInt("ActivateTarget", 0) == 1;

        if (targetObject != null)
        {
            targetObject.SetActive(activateTarget);
        }
    }
    
}
