namespace Task4
{
    public class EventPublisher
    {
        
        public delegate void EventHandler(object sender, EventArgs e);

        
        public event EventHandler EventOccurred;

        
        public void RaiseEvent()
        {
            OnEventOccurred();
        }

        protected virtual void OnEventOccurred()
        {
            EventOccurred?.Invoke(this, EventArgs.Empty);
        }
    }

    
    public class Observer1
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Обозреватель 1 реагирует на событие");
        }
    }

   
    public class Observer2
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Обозреватель 2 реагирует на событие");
        }
    }

    class Program
    {
        static void Main()
        {
            EventPublisher publisher = new EventPublisher();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            
            publisher.EventOccurred += observer1.HandleEvent;
            publisher.EventOccurred += observer2.HandleEvent;
            publisher.EventOccurred += (sender, e) => Console.WriteLine("Дополнительный обработчик реагирует на событие");

            
            publisher.RaiseEvent();

            
            publisher.EventOccurred -= observer1.HandleEvent;

            
            publisher.RaiseEvent();
        }
    }
}
