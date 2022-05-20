using System;
using TestApp_VDcom.CustomCircleDoubleLinkedList;

namespace TestApp_VDcom.train
{
    class Train
    {
        private CircleDoubleLinkedList<Wagon> wagons;

        public Train(CircleDoubleLinkedList<Wagon> wagons)
        {
            this.wagons = wagons ?? throw new ArgumentNullException(nameof(wagons));
        }

        public Train()
        {
        }

        public CircleDoubleLinkedList<Wagon> Wagons { get => wagons; set => wagons = value; }

        public int getTrainSize()
        {
            //Пусть начальным будет head, чтобы не рандомить положение, все равно разницы не будет, т.к. список кольцевой
            DoubleNode<Wagon> current = wagons.Head;
            //Включаем свет в начальном вагоне
            current.Value.turnOn();

            DoubleNode<Wagon> node = current;
            int size = 0;

            //Пока в стартовом вагоне горит свет
            while(current.Value.Light == true)
            {
                size = 1;
                node = node.Next;
                //Пока не дойдем до следующего вагона с включенным светом
                while (node.Value.Light != true)
                {
                    size++;
                    node = node.Next;
                }

                //дошли до ближайшего вагона с включенным светом, выключаем его и возвращаемся к старту
                node.Value.turnOff();
                node = current;
            }
            //если свет в начальном вагоне не горит, значит мы его потушили при обходе, значит последний подсчет верный
            return size;
        }
    }
}
