using EventlyDataLibrary.DataAccess;
using EventlyDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventlyDataLibrary.BusinessLogic
{
    public static class EventProcessor
    {
        public static int CreateEvent(string eventName, string eventDescription, DateTime eventDate)
        {
            EventModel data = new EventModel
            {
                EventName = eventName,
                EventDescription = eventDescription,
                EventDate = eventDate
            };

            string sql = @"insert into dbo.Event (EventName, EventDescription, EventDate)
                           values (@EventName, @EventDescription, @EventDate);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EventModel> LoadEvents()
        {
            string sql = @"select * from dbo.Event;";
            return SqlDataAccess.LoadData<EventModel>(sql);
        }
    }
}
