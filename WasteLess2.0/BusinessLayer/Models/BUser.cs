using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Functions;
using BusinessLayer.Managers;
using DataAccessLayer.Entities;

namespace BusinessLayer.Models
{
    public class BUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }

        public void Update(string umail)
        {
            FoodItemAccess fia = new FoodItemAccess();
            List<FoodItem> foodList = fia.GetUnmarkedFoodItems();
            if (foodList.Count > 0)
            {
                NotificationManager nm = new NotificationManager();
                string message = nm.ComposeDueNotificationMessage(foodList);
                MailManager mailManager = new MailManager();
                BMailBot bMailBot = mailManager.getBMailBot();
                mailManager.sendMail(bMailBot.Username, bMailBot.Password, umail, "New Items Expired", message);
                fia.UpdateMarked(foodList);
            }

        }

    }

}
