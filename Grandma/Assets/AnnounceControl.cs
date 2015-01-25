using UnityEngine;
using System.Collections;

public class AnnounceControl : MonoBehaviour {

    //public GameObject button;

    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        float seconds = Time.time;
        bool oddeven = seconds % 2 == 0;
        renderer.enabled = oddeven;
    }

    public void AnnouncementManage()
    {
        
    }

}
