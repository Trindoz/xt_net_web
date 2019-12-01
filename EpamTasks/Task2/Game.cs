using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface Imovable
    {
        void MoveTO();//по какому алгоритму двигаются игрок или монстр
        void Eat();//игрок есть бонус, монстр игрока
        void Death();//умер или игрок или монстр
    }
    interface IBonus
    {
        void Apple();
        void Cherry();
    }
    interface IObstacle 
    {
        void Tree();
        void Stone();
    }
    class Map : IObstacle, IBonus
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Apple()
        {
            throw new NotImplementedException();
        }

        public void Cherry()
        {
            throw new NotImplementedException();
        }

        public void Stone()
        {
            throw new NotImplementedException();
        }

        public void Tree()
        {
            throw new NotImplementedException();
        }
    }
    class Player : Map, Imovable
    {
        public void Death()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void MoveTO()
        {
            throw new NotImplementedException();
        }
    }
    class Monster : Map, Imovable
    {
        public void Death()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void MoveTO()
        {
            throw new NotImplementedException();
        }
    }
}
