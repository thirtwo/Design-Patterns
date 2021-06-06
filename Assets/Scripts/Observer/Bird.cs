public class Bird : Subject
{

    private void OnMouseDown()
    {
        Notify(NotificationType.Clicked);   
    }

}
