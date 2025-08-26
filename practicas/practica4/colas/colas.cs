using System;
namespace ColaFIFO
{
    public class ColaArreglo<T>
    {
        private T[] _elementos;
        private int _frente;
        private int _fondo;
        private int _conteo;
        private int _capacidad;

        public ColaArreglo(int capacidad)
        {
            _capacidad = capacidad;
            _elementos = new T[capacidad];
            _frente = 0;
            _fondo = -1;
            _conteo = 0;
        }
        public int Conteo => _conteo;
        public bool EstaVacia => _conteo == 0;
        public bool EstaLlena => _conteo == _capacidad;
        public void Encolar(T valor)
        {
            if (EstaLlena)
                throw new InvalidOperationException("La cola esta llena");
            _fondo = (_fondo + 1) % _capacidad;
            _elementos[_fondo] = valor;
            _conteo++;
        }
        public T Desencolar()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La cola está vacía");

            T valor = _elementos[_frente];
            _frente = (_frente + 1) % _capacidad;
            _conteo--;
            return valor;
        }
        public T Frente()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La cola está vacía");
            return _elementos[_frente];
        }
    }
}