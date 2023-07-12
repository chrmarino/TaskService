namespace TaskService.Models
{
    public class Event 
    {
        public EventType Type {get;set;}
        public DateTime Timestamp {get;set;}
        public TaskField Field {get; set;}


    }
}