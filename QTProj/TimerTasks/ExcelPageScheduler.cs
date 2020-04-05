using Quartz;
using Quartz.Impl;

namespace QTProj.TimerTasks
{
    public class ExcelPageScheduler
    {
        public static async void Start()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<ExcelPageGenerator>().Build();

            ITrigger trigger = TriggerBuilder.Create()  
                .WithIdentity("trigger1", "group1")     
                .StartNow()                            
                .WithSimpleSchedule(x => x            
                    .WithIntervalInHours(1)          
                    .RepeatForever())                   
                .Build();                               

            await scheduler.ScheduleJob(job, trigger);        
        }
    }
}