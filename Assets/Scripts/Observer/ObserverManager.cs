using UnityEngine;
using System;
using System.Collections.Generic;

public enum NotificationType
{
    Clicked,
    Collided
}
public enum SubjectType
{
    Bird,
    Fish
}
public class ObserverManager : MonoBehaviour
{
    private static ObserverManager _instance = null;
    public static ObserverManager Instance => _instance;
    
    
    public static event Action OnClickButton;

    public List<Subject> subjects;
    public List<Observer> observers;


    public void Awake()
    {
        _instance = this;
    }

    public void ClickedButton()
    {
        OnClickButton?.Invoke();
    }

    public void RegisterSubject(Subject subject)
    {
        if(subjects == null)
        {
            subjects = new List<Subject>();
        }
        subjects.Add(subject);
    }

    public void RegisterObserver(Observer observer,SubjectType subjectType)
    {
        foreach(Subject subject in subjects)
        {
            if(subject.SubjectType == subjectType)
            {
                subject.RegisterObserver(observer);
            }
        }
    }
}
