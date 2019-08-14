using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Database
{
    class DbQueue<T> where T : DbQueueObject
    {
        private const string TAG = "DbQueue";

        private readonly Queue<T> queue = new Queue<T>();
        private volatile int capacity;
        private volatile bool stopped;

        // Extra for logging
        public LoggingLevel LoggingLevel { get; set; }
        public int HighestCapacity { get; private set; } // Highest number of elements at once in the queue
        public TimeSpan AverageTimeInQueue { get; private set; } // Average time of one element in queue
        public int TotalCount { get; private set; } // Total processed items

        public DbQueue(int capacity, LoggingLevel loggingLevel)
        {
            this.capacity = capacity;
            this.stopped = false;
            LoggingLevel = loggingLevel;
        }

        public void Stop()
        {
            stopped = true;
            lock(queue)
            {
                if (LoggingLevel >= LoggingLevel.Some)
                {
                    LogQueueStats();
                }
                Monitor.PulseAll(queue);
            }
        }

        public void Start()
        {
            stopped = false;
            HighestCapacity = 0;
            AverageTimeInQueue = new TimeSpan(0);
            TotalCount = 0;
            lock (queue)
            {
                Monitor.PulseAll(queue);
            }
        }

        public void Put(T element)
        {
            lock(queue)
            {
                while (queue.Count >= capacity)
                {
                    if (LoggingLevel >= LoggingLevel.Some)
                    {
                        LogFull();
                    }
                    Monitor.Wait(queue);
                }

                if (!stopped)
                {
                    if (LoggingLevel == LoggingLevel.Insane)
                    {
                        LogAdd(element);
                    }

                    queue.Enqueue(element);

                    if (LoggingLevel == LoggingLevel.Insane)
                    {
                        if (Count > HighestCapacity)
                        {
                            HighestCapacity = Count;
                        }
                        element.InsertTime = DateTime.Now;
                    }

                    Monitor.PulseAll(queue);
                }
            }
        }

        public bool Take(out T element)
        {
            element = default(T);
            lock(queue)
            {
                while(queue.Count == 0)
                {
                    if (!stopped)
                    {
                        if (LoggingLevel >= LoggingLevel.Some)
                        {
                            LogEmpty();
                        }
                        try
                        {
                            Monitor.Wait(queue);
                        }
                        catch (ThreadInterruptedException)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                if (!stopped)
                {
                    element = queue.Dequeue();

                    if (LoggingLevel == LoggingLevel.Insane)
                    {
                        LogRemove(element);
                        element.RemoveTime = DateTime.Now;
                        UpdateStats(element);
                    }

                    try
                    {
                        Monitor.PulseAll(queue);
                    }
                    catch (ThreadInterruptedException)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public int Count
        {
            get { return queue.Count; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public bool IsRunning
        {
            get { return !stopped; }
        }


        #region QUEUE LOGGING

        private void UpdateStats(T element)
        {
            TotalCount++;
            TimeSpan span = element.TimeInQueue;
            AverageTimeInQueue = new TimeSpan((AverageTimeInQueue.Add(span)).Ticks / TotalCount);
        }

        private void LogFull()
        {
            Debug.WriteLine("Queue reached maximum: " + Capacity, TAG);
        }

        private void LogEmpty()
        {
            Debug.WriteLine("Queue empty", TAG);
        }

        private void LogAdd(T element)
        {
            Debug.WriteLine("Add to queue: " + element + ", size=" + Count, TAG);
        }

        private void LogRemove(T element)
        {
            Debug.WriteLine("Remove from queue: " + element + ", size=" + Count, TAG);
        }

        private void LogQueueStats()
        {
            Debug.WriteLine("Queue Status: ");
            Debug.WriteLine(" - Processing: " + Count);
            Debug.WriteLine(" - Max capacity: " + Capacity);
            
            Debug.WriteLine(" - Total processed: " + TotalCount);
            Debug.WriteLine(" - Highest reached capacity: " + HighestCapacity);
            Debug.WriteLine(" - Average time/element: " + AverageTimeInQueue);
        }

        #endregion
    }
}
