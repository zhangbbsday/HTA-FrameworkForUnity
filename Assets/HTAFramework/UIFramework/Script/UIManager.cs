using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Transform uiOfAll;
    public string tagToSelect = "";
    public GameObject CurrentMenu { get; private set; }

    private static UIManager instance;
    public static UIManager Instacne
    {
        get
        {
            if (instance == null)
                throw new System.NullReferenceException("UI Manager not find!");

            return instance;
        }
    }
    private Dictionary<string, GameObject> UIContainer { get; set; } = new Dictionary<string, GameObject>();
    private Stack<GameObject> Menu { get; set; } = new Stack<GameObject>();

    private void Awake()
    {
        instance = this;
        DetectionError();
        SetUIObject();
    }

    public T FindUI<T>(string name)
    {
        if (!IsExisted(name))
            throw new System.ArgumentException($"Can't find {name}!");

        return UIContainer[name].GetComponent<T>();
    }

    public GameObject FindUI(string name)
    {
        if (!IsExisted(name))
            throw new System.ArgumentException($"Can't find {name}!");

        return UIContainer[name];
    }

    public void Show(GameObject gameObject, bool isMenu = false)
    {
        gameObject.SetActive(true);
        if (isMenu)
            CurrentMenu = gameObject;
    }

    public void Show(string name, bool isMenu = false)
    {
        if (!IsExisted(name))
            throw new System.ArgumentException($"Can't find {name}!");

        Show(UIContainer[name], isMenu);
    }

    public void Close(GameObject gameObject, bool isMenu = false)
    {
        gameObject.SetActive(false);
        if (isMenu)
            Menu.Push(gameObject);
    }

    public void Close(string name, bool isMenu = false)
    {
        if (!IsExisted(name))
            throw new System.ArgumentException($"Can't find {name}!");

        Close(UIContainer[name], isMenu);
    }

    public void Back()
    {
        if (Menu.Count == 0)
            throw new System.IndexOutOfRangeException("Stack has no gameObject!");

        var gameObject = Menu.Pop();
        Close(CurrentMenu);
        Show(gameObject, true);
    }

    private void DetectionError()
    {
        if (uiOfAll == null)
            throw new System.NullReferenceException("No GameObject!");
    }

    private void SetUIObject()
    {
        var childs = uiOfAll.GetComponentsInChildren<Transform>(true);

        foreach (Transform child in childs)
        {
            if (child.CompareTag(tagToSelect) && !UIContainer.ContainsKey(child.name))
                UIContainer[child.name] = child.gameObject;
        }

        if (UIContainer.Count == 0)
            Debug.LogError("No UI was loaded!");
    }

    private bool IsExisted(string name) => UIContainer.ContainsKey(name);
}
