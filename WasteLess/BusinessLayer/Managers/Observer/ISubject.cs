using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Models;

namespace BusinessLayer.Managers.Observer
{
    public interface ISubject
    {
        public abstract void Attach(BUser observer);

        public abstract void Detach(BUser observer);

        public abstract void Notify();

    }

}
