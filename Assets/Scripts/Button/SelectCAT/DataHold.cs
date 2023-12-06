using UnityEngine;

public class DataHolder : MonoBehaviour
{
    public static DataHolder Instance;

    private GameObject targetObject;

    public bool button1 { get; set; }
    public bool button2 { get; set; }

    private void Awake()
    {
        // Singleton 패턴 사용
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 대상 GameObject 설정 메서드
    public void Button1()
    {
        button1 = true;
        button2 = false;
    }

    public void Button2()
    {
        button1 = false;
        button2 = true;
    }
}
