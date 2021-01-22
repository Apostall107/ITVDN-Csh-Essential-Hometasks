using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_07
{
    interface IforTrain
    {
        void AddTrain(Train[] bigTrain);
        void Show(Train[] bigTrain);
        void Sort(Train[] bigTrain);
        void Search(Train[] bigTrain);

    }
}
