using System;

namespace HelloWorld.Exercises
{
    public class Stopwatch
    {
        /*
         To use this try to make a while loop, and set an if condition for the quitting of the application
        and also an input key for the Stop() method of the stopwatch.
         */

        private DateTime _startTime;
        private DateTime _endTime;
        private bool _hasStarted;
        public void Start()
        {
            _startTime = DateTime.Now;
            _hasStarted = true;
        }

        public TimeSpan Stop()
        {
            _endTime = DateTime.Now;
            if (!_hasStarted)
            {
                Console.Clear();
                throw new InvalidOperationException("Double Stopped!");
            }
            _hasStarted = false;

            var duration = _endTime - _startTime;
            return duration;
        }
    }
}