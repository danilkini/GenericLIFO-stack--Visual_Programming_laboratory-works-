using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLIFO_stack_
{
    internal class Class1
    {
        public class GenericLIFO<T> : ILIFO<T>
        {
            private Stack<T> items = new Stack<T>();
            public void Push(T item)
            {
                items.Push(item); // Используем встроенный метод Push для добавления элемента в стек
            }

            public T Pop()
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("Стек пуст.");
                }

                return items.Pop(); // Используем встроенный метод Pop для удаления элемента с вершины стека
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");

                // Для получения элемента по индексу нужно либо преобразовать стек в массив,
                // либо использовать вспомогательный список. Стек не поддерживает индексацию напрямую.
                return items.ToArray()[index];
            }

            public int Count => items.Count; // Возвращаем общее число элементов
        }
    }
}
