using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTableManager : MonoBehaviour
{
    public GameObject task;
    private GameObject newTask;

    void Start()
    {
        
    }

    public void AddTask(TaskInfo taskInfo) {
        newTask = Instantiate(task, transform) as GameObject;
        Text textComponent = newTask.transform.GetChild(0).GetComponent<Text>();
        textComponent.text = taskInfo.GetName();
    }
}
