using UnityEngine;
[System.Serializable]
public class TaskInfo
{
    public string name;

    public TaskInfo(string name) {
        this.name = name;
    }

    public string GetName() { return name; }
}
