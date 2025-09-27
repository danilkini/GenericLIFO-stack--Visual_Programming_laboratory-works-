using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLIFO_stack_
{
    public interface ILIFO<T>
    {
        void Push(T item);        // Добавить элемент в начало
        T Pop();                 // Изъять элемент из начала
        T Get(int index);        // Получить элемент по индексу
        int Count { get; }       // Общее число элементов
    }
    public interface ILIF<T> : ILIFO<T>
    {
        void Pull(int index);
    }
    public interface ILI<T> : ILIFO<T>, ILIF<T>
    {
      
        T pip();
    }
}

