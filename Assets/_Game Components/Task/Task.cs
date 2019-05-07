using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Task : MonoBehaviour
{
    public TaskInfo taskInfo;
    private TaskInterface taskInterface;

    void Start() {
        taskInterface = FindObjectOfType<TaskInterface>();

        Text text = transform.GetChild(0).GetComponentInChildren<Text>();
        text.text = taskInfo.name;
    }

    void Update() {
        
    }

    public void OpenTask() {
        print("task opens");
    }

    public void DragTask() {
        //print("task is being dragged");
        //gather information of the task here
        GameObject childImageObject = transform.GetChild(0).gameObject;
        //call the task interface & send task information
        taskInterface.DragTask(taskInfo,childImageObject);
        //childImageObject.SetActive(false);
    }

    public void EndDragTask() {
        //remove button image from mouse pointer
        taskInterface.EndDrag();
        //detect mouse hover over which UI object
        //send data to that object to initialize object creation
    }
}
