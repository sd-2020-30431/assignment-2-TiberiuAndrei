using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Models;

namespace BusinessLayer.Managers.Observer
{
    public class ConcreteSubject : ISubject
    {
        private List<BUser> ObserverList;
        public ConcreteSubject()
        {
            ObserverList = new List<BUser>();
        }

        public void Attach(BUser observer)
        {
            ObserverList.Add(observer);
        }

        public void Detach(BUser observer)
        {
            ObserverList.Remove(observer);
        }

        public void Notify()
        {
            foreach (BUser o in ObserverList)
            {

                o.Update(o.Mail);

            }
        }
    }
}
