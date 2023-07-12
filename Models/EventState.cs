namespace TaskService.Models
{
    public enum  EventState : ushort {PENDING,DOING,DONE}
    public enum EventType : ushort  {CREATION,UPDATE}

    public enum TaskField : ushort  {TITLE,DESCRIPTION,STATE}
}