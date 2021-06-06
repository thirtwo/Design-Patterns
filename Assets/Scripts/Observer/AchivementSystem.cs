using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementSystem : Observer
{
    public override void OnNotify(NotificationType notificationType)
    {
        if(notificationType == NotificationType.Clicked)
        {
            Debug.Log("Achivement Accomplished");
        }
    }

    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.Bird);
    }

}
