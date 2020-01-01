using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public static class UIEventManager
{
    public enum NameIgnorance
    {
        Number
    }

    public static void LinkEvent(Button ui, object type, NameIgnorance ignorance = NameIgnorance.Number)
    {
        string methodName = Ignore(ui.name, ignorance);
        MethodInfo method = type.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        ui.onClick.AddListener(() => { method.Invoke(type, null); });
    }

    public static void LinkEvent(Slider ui, object type, NameIgnorance ignorance = NameIgnorance.Number)
    {
        string methodName = Ignore(ui.name, ignorance);
        MethodInfo method = type.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        ui.onValueChanged.AddListener((value) => { method.Invoke(type, new object[] { value }); });
    }

    public static void LinkEvent(Scrollbar ui, object type, NameIgnorance ignorance = NameIgnorance.Number)
    {
        string methodName = Ignore(ui.name, ignorance);
        MethodInfo method = type.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        ui.onValueChanged.AddListener((value) => { method.Invoke(type, new object[] { value }); });
    }
    public static void LinkEvent(Toggle ui, object type, NameIgnorance ignorance = NameIgnorance.Number)
    {
        string methodName = Ignore(ui.name, ignorance);
        MethodInfo method = type.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        ui.onValueChanged.AddListener((value) => { method.Invoke(type, new object[] { value }); });
    }

    public static void LinkEvent(Dropdown ui, object type, NameIgnorance ignorance = NameIgnorance.Number)
    {
        string methodName = Ignore(ui.name, ignorance);
        MethodInfo method = type.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        ui.onValueChanged.AddListener((value) => { method.Invoke(type, new object[] { value }); });
    }

    private static string Ignore(string name, NameIgnorance ignorance)
    {
        switch (ignorance)
        {
            case NameIgnorance.Number:
                return IgnoreNumber(name);
            default:
                return null;
        }
    }
    private static string IgnoreNumber(string name)
    {
        StringBuilder str = new StringBuilder();

        foreach (char c in name)
        {
            if (!char.IsDigit(c))
                str.Append(c);
        }

        return str.ToString();
    }
}
