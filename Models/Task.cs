namespace TaskService.Models 
{
    public class Task
    {
        
        public String Id = string.Empty;
        public String UserID = string.Empty;

        public  String Title {get;set;} = string.Empty;
        public String Description{get;set;} = string.Empty;
        public List<EventType> Events {get; set;} = null!;

        public EventState State {get;set;}
        public String Group {get; set;} = string.Empty;

    }
}