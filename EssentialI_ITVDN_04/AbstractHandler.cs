using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_04
{
    abstract class AbstractHandler
    {
        protected string _DocName;

         protected  AbstractHandler(string _DocName)
        { 
            this._DocName = _DocName;
        }

        protected void Open()
        {
            Console.WriteLine(_DocName +  " opened!");
        }

        protected void Create()
        {
            Console.WriteLine(_DocName + " сcreated!");
        }

        protected void Chenge()
        {
            Console.WriteLine(_DocName + " reducted!");
        }

        protected void ShowInfo()
        {
            this.Create();
            this.Open();
            this.Chenge();
        }


        public abstract void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string _DocName)
            : base(_DocName)
        {
  
        }

        public override void Save()
        {
            Console.WriteLine(_DocName + " save in .XML!");
        }

        public void ShowInfoXML()
        {
            base.ShowInfo();
            Save();
            Console.WriteLine(new string('-', 30));
        }

    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string _DocName)
            : base(_DocName)
        {

        }

        public override void Save()
        {
            Console.WriteLine(_DocName + " save in .TXT!");
        }

        public void ShowInfoTXT()
        {
            base.ShowInfo();
            Save();
            Console.WriteLine(new string('-', 30));
        }

    }

    class DOCHandler : AbstractHandler
    {

        public DOCHandler(string _DocName)
            : base(_DocName)
        {
        }



        public override void Save()
        {
            Console.WriteLine(_DocName + " save in .DOC!");
        }

        public void ShowInfoDOC()
        {
            base.ShowInfo();
            Save();
            Console.WriteLine(new string('-', 30));
        }

    }

}
