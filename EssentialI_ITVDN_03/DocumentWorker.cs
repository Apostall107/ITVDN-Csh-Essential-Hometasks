using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_03
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии \"Pro\".");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии \"Pro\".");
        }

        public virtual void CheckOptions()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }

    }

    class ProDocumentWorker : DocumentWorker
    {
        
        public sealed override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в старом формате. (Для сохранения в новом формате, нужна версия Expert)");
        }



    }



    class ExpertDocumentWorker : ProDocumentWorker
    {
        
        public sealed override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в новом формате.");
        }
    }




}
