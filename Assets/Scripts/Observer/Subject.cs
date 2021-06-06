using UnityEngine;
using System.Collections.Generic;

public abstract class Subject : MonoBehaviour
{
    [SerializeField] private SubjectType _subjectType;
    public SubjectType SubjectType => _subjectType;

    public List<Observer> observers;
    public void Notify(NotificationType notificationType)
    {
        foreach(Observer observer in observers)
        {
            observer.OnNotify(notificationType);
        }
    }

    public void RegisterObserver(Observer observer)
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }
        observers.Add(observer);
    }

    private void Start()
    {
        ObserverManager.Instance.RegisterSubject(this);
    }
}